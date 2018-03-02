using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab6
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// initializes Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// initializes Form1, and takes in a person's ID#.
        /// </summary>
        /// <param name="intPersonID"></param>
        public Form1(int intPersonID)
        {
            //constructor
            InitializeComponent();

            //creates a new temporary person
            PersonV2 temp = new PersonV2();

            //reads data from the person whose ID is specified
            SqlDataReader dr = temp.FindOnePerson(intPersonID);

            //while there is still data to read...
            while(dr.Read())
            {
                //it pulls the information for the person who's ID was sent in
                txtFirstName.Text = dr["FirstName"].ToString();
                txtMiddleName.Text = dr["MiddleName"].ToString();
                txtLastName.Text = dr["LastName"].ToString();

                txtAddress.Text = dr["Address"].ToString();
                txtAddress2.Text = dr["Address2"].ToString();

                txtCity.Text = dr["City"].ToString();
                txtState.Text = dr["State"].ToString();
                txtZipCode.Text = dr["ZipCode"].ToString();

                txtPhone.Text = dr["Phone"].ToString();
                txtCellPhone.Text = dr["CellPhone"].ToString();
                txtEmail.Text = dr["Email"].ToString();

                txtFacebook.Text = dr["Facebook"].ToString();
                lblPersonIDNum.Text = dr["PersonID"].ToString();                
            }
        }

        //when the submit button is clicked...
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //creates a temporary person
            PersonV2 temp = new PersonV2();

            //Assigns the values to the person according to the information specified in the form
            temp.FirstName = txtFirstName.Text;
            temp.MiddleName = txtMiddleName.Text;
            temp.LastName = txtLastName.Text;

            temp.Address = txtAddress.Text;
            temp.Address2 = txtAddress2.Text;

            temp.City = txtCity.Text;
            temp.State = txtState.Text;
            temp.ZipCode = txtZipCode.Text;

            temp.Phone = txtPhone.Text;
            temp.CellPhone = txtCellPhone.Text;
            temp.Email = txtEmail.Text;
            temp.Facebook = txtFacebook.Text;

            //If there aren't any errors...
            if(!temp.Feedback.Contains("ERROR:"))
            {
                //... it adds the person to the database
                lblFeedback.Text = temp.AddARecord();
            }
            //if there are errors...
            else
            {
                //... it gives a feedback error to the form.
                lblFeedback.Text = temp.Feedback;
            }
        }


    }
}
