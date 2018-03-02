using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class searchWindow : Form
    {
        //initalizes the search window
        public searchWindow()
        {
            InitializeComponent();
        }

        //if the search button is clicked...
        private void dtbSearchBtn_Click(object sender, EventArgs e)
        {
            //creates a temporary person
            PersonV2 temp = new PersonV2();

            //searches the database for the firstname and lastname entered in the search field (if firstname and lastname were specified, that is)
            DataSet ds = temp.SearchPersonV2(txtFirstName.Text, txtLastName.Text);

            //Assigns results from the dataset above to the data table variable below
            dtbGridResults.DataSource = ds;
            dtbGridResults.DataMember = ds.Tables["Person_Temp"].ToString();


        }

        /// <summary>
        /// the data grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dtbGridResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Assigns the people from the results above to the data grid
            string strPersonID = dtbGridResults.Rows[e.RowIndex].Cells[0].Value.ToString();

            //shows a message with the person's ID
            MessageBox.Show("Person ID: " + strPersonID);

            //converts the strPersonID to an int, intPersonID
            int intPersonID = Convert.ToInt32(strPersonID);

            //opens up a new form with the data for the person who's cell was double clicked filled out
            Form1 test = new Form1(intPersonID);
            test.ShowDialog();
        }
    }
}
