using Attendance_App.AppClasses;
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

namespace Attendance_App.LecturerForms
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtBoxNewPassword.Text != "" && txtBoxPasswordConfirm.Text != "" && txtBoxPreviousPassword.Text != "")
            {
                if (txtBoxNewPassword.Text == txtBoxPasswordConfirm.Text)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "changePassword";
                    SqlCommand changePassCommand = new SqlCommand(query, conn);
                    changePassCommand.CommandType = CommandType.StoredProcedure;
                    changePassCommand.Parameters.AddWithValue("@userID", CurrentLogin.currentID);
                    changePassCommand.Parameters.AddWithValue("@currentPassword", txtBoxPreviousPassword.Text);
                    changePassCommand.Parameters.AddWithValue("@newPassword", txtBoxNewPassword.Text);
                    changePassCommand.Parameters.AddWithValue("@role", CurrentLogin.currentRole);
                    changePassCommand.Parameters.Add("@result", SqlDbType.VarChar, 250); //specify output parameter
                    changePassCommand.Parameters["@result"].Direction = ParameterDirection.Output;

                    int rows = changePassCommand.ExecuteNonQuery();
                    string outputValue = changePassCommand.Parameters["@result"].Value.ToString();
                    if (rows > 0)
                    {
                        MessageBox.Show(outputValue);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(outputValue);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords are not the same");
                }
            }
            else
            {
                MessageBox.Show("Invalid! all fields are required");
            }
        }
    }
}
