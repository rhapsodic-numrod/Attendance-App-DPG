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

namespace Attendance_App.AdminForms
{
    public partial class UpdateAccount : Form
    {
        public UpdateAccount()
        {
            InitializeComponent();
        }
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        private void btnUpdateNumber_Click(object sender, EventArgs e)
        {
            string query = "dbo.updateMobileNo";
            SqlCommand updateMobileCommand = new SqlCommand(query, conn);
            updateMobileCommand.CommandType = CommandType.StoredProcedure;
            updateMobileCommand.Parameters.AddWithValue("@userID", CurrentLogin.currentID);
            updateMobileCommand.Parameters.AddWithValue("@newMobile", txtBoxNewNumber.Text);
            updateMobileCommand.Parameters.AddWithValue("@role", CurrentLogin.currentRole);
            updateMobileCommand.Parameters.Add("@result", SqlDbType.VarChar, 250); //specify output parameter
            updateMobileCommand.Parameters["@result"].Direction = ParameterDirection.Output;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
               // updateMobileCommand.ExecuteNonQuery(); //read whats in the output paramaters
                int rowsAffected = updateMobileCommand.ExecuteNonQuery();
                string outputValue = updateMobileCommand.Parameters["@result"].Value.ToString(); //store the value in the output parameter
                if (rowsAffected > 0)
                {
                    MessageBox.Show(outputValue);
                }
                else
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

        private void btnGoToChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePass = new ChangePassword();
            changePass.Show();
        }
    }
}
