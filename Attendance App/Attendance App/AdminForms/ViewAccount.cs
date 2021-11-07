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
    public partial class ViewAccount : Form
    {
        public ViewAccount()
        {
            InitializeComponent();
            viewData();
        }
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        public void viewData()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "searchByUserID";
            SqlCommand viewCommand = new SqlCommand(query, conn);
            viewCommand.CommandType = CommandType.StoredProcedure;
            viewCommand. Parameters.AddWithValue("@userID", CurrentLogin.currentID);
            viewCommand.Parameters.AddWithValue("@role", CurrentLogin.currentRole);
            viewCommand.Parameters.Add("@result", SqlDbType.VarChar, 250); //specify output parameter
            viewCommand.Parameters["@result"].Direction = ParameterDirection.Output;

            SqlDataReader reader = viewCommand.ExecuteReader();
            while (reader.Read())
            {
                txtBoxFname.Text = reader.GetValue(1).ToString();
                txtBoxMName.Text = reader.GetValue(2).ToString();
                txtBoxLName.Text = reader.GetValue(3).ToString();
                txtBoxEmail.Text = reader.GetValue(4).ToString();
                txtBoxPhoneNo.Text = reader.GetValue(5).ToString();
            }
            reader.Close();
            conn.Close();
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
