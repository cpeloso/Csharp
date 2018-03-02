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
        public searchWindow()
        {
            InitializeComponent();
        }

        private void dtbSearchBtn_Click(object sender, EventArgs e)
        {
            //gets data
            PersonV2 temp = new PersonV2();

            DataSet ds = temp.SearchPersonV2(txtFirstName.Text, txtLastName.Text);

            dtbGridResults.DataSource = ds;
            dtbGridResults.DataMember = ds.Tables["Person_Temp"].ToString();


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dtbGridResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strPersonID = dtbGridResults.Rows[e.RowIndex].Cells[0].Value.ToString();

            MessageBox.Show("Person ID: " + strPersonID);

            int intPersonID = Convert.ToInt32(strPersonID);

            Form1 test = new Form1(intPersonID);
            test.ShowDialog();
        }
    }
}
