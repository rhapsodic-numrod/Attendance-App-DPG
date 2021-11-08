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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        public int Role { get; set; }
        #region Radion buttons
        private void radioStudent_CheckedChanged(object sender, EventArgs e)
        {
            Role = 1;
        }

        private void radioLecturer_CheckedChanged(object sender, EventArgs e)
        {
            Role = 2;
        }

        private void radioAdmin_CheckedChanged(object sender, EventArgs e)
        {
            Role = 3;
        }
        #endregion

        private void btnGetUserInfo_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "searchByUserID";
            SqlCommand viewCommand = new SqlCommand(query, conn);
            viewCommand.CommandType = CommandType.StoredProcedure;
            viewCommand.Parameters.AddWithValue("@userID", txtBoxUserID.Text);
            viewCommand.Parameters.AddWithValue("@role", Role);
            viewCommand.Parameters.Add("@result", SqlDbType.VarChar, 250); //specify output parameter
            viewCommand.Parameters["@result"].Direction = ParameterDirection.Output;

            SqlDataReader reader = viewCommand.ExecuteReader();
            //string outputValue = viewCommand.Parameters["@result"].Value.ToString(); //store the value in the output parameter
            if (reader.HasRows)
            {
                MessageBox.Show("User found");
                while (reader.Read())
                {
                    txtBoxFName.Text = reader.GetValue(1).ToString();
                    txtBoxMName.Text = reader.GetValue(2).ToString();
                    txtBoxLName.Text = reader.GetValue(3).ToString();
                    txtBoxEmail.Text = reader.GetValue(4).ToString();
                    txtBoxPhoneNum.Text = reader.GetValue(6).ToString();
                }
            }
            else
            {
                MessageBox.Show("User does not exist");
            }
            reader.Close();
            conn.Close();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (radioAdmin.Checked == true || radioStudent.Checked == true || radioLecturer.Checked == true)
            {
                if (txtBoxUserID.Text != "")
                {
                    if (txtBoxFName.Text != "" && txtBoxEmail.Text != "" && txtBoxLName.Text != "" && txtBoxPhoneNum.Text != "")
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string query = "updateUser";
                        SqlCommand updateCommand = new SqlCommand(query, conn);
                        updateCommand.CommandType = CommandType.StoredProcedure;
                        updateCommand.Parameters.AddWithValue("@userID", txtBoxUserID.Text);
                        updateCommand.Parameters.AddWithValue("@firstName", txtBoxFName.Text);
                        updateCommand.Parameters.AddWithValue("@middleName", txtBoxMName.Text);
                        updateCommand.Parameters.AddWithValue("@lastName", txtBoxLName.Text);
                        updateCommand.Parameters.AddWithValue("@email", txtBoxEmail.Text);
                        updateCommand.Parameters.AddWithValue("@mobile", txtBoxPhoneNum.Text);
                        updateCommand.Parameters.AddWithValue("@role", Role);
                        updateCommand.Parameters.Add("@result", SqlDbType.VarChar, 250); //specify output parameter
                        updateCommand.Parameters["@result"].Direction = ParameterDirection.Output;

                        int rows = updateCommand.ExecuteNonQuery();
                        string outputValue = updateCommand.Parameters["@result"].Value.ToString(); //store the value in the output parameter
                        if (rows > 0)
                        {
                            MessageBox.Show(outputValue);
                        }
                        else
                        {
                            MessageBox.Show(outputValue);
                        }
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid! Add values to all required fields");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid! Enter a user ID.");
                }
            }
            else
            {
                MessageBox.Show("Invalid! Select a user role");
            }
        }
    }
}
