using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_App.AdminForms
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }
        public int userRole { get; set; }
        #region Radio buttons
        private void radioStudent_CheckedChanged(object sender, EventArgs e)
        {
            userRole = 1;
        }

        private void radioLecturer_CheckedChanged(object sender, EventArgs e)
        {
            userRole = 2;
        }

        private void radioAdmin_CheckedChanged(object sender, EventArgs e)
        {
            userRole = 3;
        }
        #endregion
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            
            string query = "";
            if (radioAdmin.Checked)
            {
                query = "dbo.addAdmin";// @fName, @mName, @lName, @email,@mobile, @result";
            }
            else if (radioLecturer.Checked)
            {
                query = "dbo.addLecturer";// @fName, @mName, @lName, @email,@mobile, @result";
            } 
            else if (radioStudent.Checked)
            {
                query = "dbo.addStudent";// @fName, @mName, @lName, @email,@mobile, @result";
            }
            SqlCommand addUserCommand = new SqlCommand(query, conn);
            //SqlDataReader rdr = null;
            addUserCommand.CommandType = CommandType.StoredProcedure;
            addUserCommand.Parameters.AddWithValue("@firstName", txtBoxFname.Text);
            addUserCommand.Parameters.AddWithValue("@middleName", txtBoxMName.Text);
            addUserCommand.Parameters.AddWithValue("@lastName", txtBoxLName.Text);
            addUserCommand.Parameters.AddWithValue("@email", txtBoxEmail.Text);
            addUserCommand.Parameters.AddWithValue("@mobile", txtBoxPhoneNo.Text);
            addUserCommand.Parameters.Add("@result", SqlDbType.VarChar, 250); //specify output parameter
            addUserCommand.Parameters["@result"].Direction = ParameterDirection.Output; //state that it's an output parameter
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                int rowsAffected = addUserCommand.ExecuteNonQuery();
                string outputValue = addUserCommand.Parameters["@result"].Value.ToString(); //store the value in the output parameter
                if (rowsAffected > 0)
                {
                    MessageBox.Show(outputValue);
                } else
                {
                    MessageBox.Show(outputValue);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
