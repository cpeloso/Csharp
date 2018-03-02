using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab6
{
    class PersonV2:person
    {
        //new properties
        private String cellPhone;
        private String facebook;

        //mutators/accessors
        public String CellPhone
        {
            get
            {
                return cellPhone;
            }

            set
            {
                if (validationLibrary.IsValidPhoneNumber(value))
                {
                    cellPhone = value;
                }
                else
                {
                    feedback += "\nERROR: Invalid Cellphone Number.";
                }
            }

        }

        public String Facebook
        {
            get
            {
                return facebook;
            }

            set
            {
                if(validationLibrary.FaceBookWebsiteCheck(value))
                {
                    facebook = value;
                }

                else
                {
                    feedback += "\nERROR: Invalid Facebook Link.";
                }
            }
        }

        public String AddARecord()
        {
            //Asssigns strResult a value of nothing
            string strResult = "";

            //creates a new connection variable
            SqlConnection Conn = new SqlConnection();

            //Uses the GetConnected() Function to connect to my Sql database
            Conn.ConnectionString = @GetConnected();
            
            //Creates a string variable and assigns a SQL command to it
            string strSQL = "INSERT INTO Table_1 (FirstName,MiddleName,LastName,Address,Address2,City,State,ZipCode,Phone,CellPhone,Email,Facebook) VALUES (@FirstName,@MiddleName,@LastName,@Address,@Address2,@City,@State,@ZipCode,@Phone,@CellPhone,@Email,@Facebook)";

            //Creates a new SQL command variable
            SqlCommand comm = new SqlCommand();

            //Sends the strSQL variable to the SQL server
            comm.CommandText = strSQL;

            //Tells the command variable which database to send it to
            comm.Connection = Conn;

            //Adds all the different values entered in the menu
            comm.Parameters.AddWithValue("@FirstName", FirstName);
            comm.Parameters.AddWithValue("@MiddleName", MiddleName);
            comm.Parameters.AddWithValue("@LastName", LastName);

            comm.Parameters.AddWithValue("@Address", Address);
            comm.Parameters.AddWithValue("@Address2", Address2);

            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@ZipCode", ZipCode);

            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@CellPhone", CellPhone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Facebook", Facebook);

            //Tries to establish a connection
            try
            {
                //If it works properly it opens the connection
                Conn.Open();

                int intRecs = comm.ExecuteNonQuery();

                //Prints to the screen the amount of records successfully inserted
                strResult = $"SUCCESS: Inserted {intRecs} Record(s).";

                //Closes the connection
                Conn.Close();
            }

            //If there's any errors...
            catch (Exception err)
            {
                //...sets the strResult variable = to the errors
                strResult = "ERROR: " + err.Message;
            }

            finally
            {

            }

            //returns strResult to wherever it was called from
            return strResult;
        }

        //constructor


       public DataSet SearchPersonV2(String strFirstName,String strLastName)
        {
            //creates a new dataset
            DataSet ds = new DataSet();

            //Creates a new SQL command variable
            SqlCommand comm = new SqlCommand();

            //creates a new string variable and sets it equal to a SQL command
            String strSQL = "SELECT PersonID, FirstName, MiddleName, LastName, Address, Address2, City, State, ZipCode, Phone, CellPhone, Email, Facebook FROM Table_1 WHERE 0=0";
            
            //If a value is entered in the first name search field...
            if(strFirstName.Length > 0)
            {
                //...it adds the search term to the strSQL search variable
                strSQL += " AND FirstName LIKE @FirstName";
                comm.Parameters.AddWithValue("@FirstName", "%" + strFirstName + "%");
            }

            //does the same as above but for last name instead
            if(strLastName.Length > 0)
            {
                strSQL += " AND LastName LIKE @LastName";
                comm.Parameters.AddWithValue("@LastName", "%" + strLastName + "%");
            }
            
            //creates a new sql connection variable
            SqlConnection conn = new SqlConnection();

            //connects to my sql database using the getconnected() function
            string strConn = @GetConnected();
            conn.ConnectionString = strConn;

            //uses the sql connection above to run commands through the database
            comm.Connection = conn;
            comm.CommandText = strSQL;

            //creates a new data adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            //opens a connection
            conn.Open();

            //
            //da.Fill(ds, "Person_Temp");
            conn.Close();

            return ds;            
        }

        public SqlDataReader FindOnePerson(int intPersonID)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string strConn = @GetConnected();

            string sqlString = "SELECT * FROM Table_1 WHERE PersonID = @PersonID;";

            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@PersonID", intPersonID);

            conn.Open();

            return comm.ExecuteReader();
        }

        private String GetConnected()
        {
            return "Server=sql.neit.edu,4500;Database=SE245_CPeloso;User Id=SE245_CPeloso;Password=008000399;";
        }

        public PersonV2(): base()
        {
            cellPhone = "";
            facebook = "";
        }

    }
}
