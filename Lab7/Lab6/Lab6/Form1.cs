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
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="intPersonID"></param>
        public Form1(int intPersonID)
        {
            InitializeComponent();

            PersonV2 temp = new PersonV2();
            SqlDataReader dr = temp.FindOnePerson(intPersonID);

            while(dr.Read())
            {
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            PersonV2 temp = new PersonV2();

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


            if(!temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.AddARecord();
            }
            else
            {
                lblFeedback.Text = temp.Feedback;
            }
        }


    }
}
