using Attendance_App.AppClasses;
using Attendance_App.StudentForms;
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
    public partial class MakeAttendanceAvailable : Form
    {
        public MakeAttendanceAvailable()
        {
            InitializeComponent();
            showData();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);

        private void showData()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "dbo.viewClassesYouTeach";
            SqlCommand viewClassesTaught = new SqlCommand(query, conn);
            viewClassesTaught.CommandType = CommandType.StoredProcedure;
            viewClassesTaught.Parameters.AddWithValue("@userID", CurrentLogin.currentID);
            SqlDataAdapter adapter = new SqlDataAdapter(viewClassesTaught);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewAllClassesYouTeach.DataSource = table;
            conn.Close();
        }

        private void btnMakeAvailable_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "dbo.classAvailability";
            SqlCommand changeAvailability = new SqlCommand(query, conn);
            changeAvailability.CommandType = CommandType.StoredProcedure;
            changeAvailability.Parameters.AddWithValue("@userID", CurrentLogin.currentID);
            changeAvailability.Parameters.AddWithValue("@classID", txtBoxClassID.Text);
            changeAvailability.Parameters.AddWithValue("@status", 1);
            changeAvailability.Parameters.Add("@result", SqlDbType.VarChar, 250); //specify output parameter
            changeAvailability.Parameters["@result"].Direction = ParameterDirection.Output;

            bool isNumber = int.TryParse(txtBoxClassID.Text, out _);
            if (isNumber)
            {
                int rows = changeAvailability.ExecuteNonQuery();
                string outputValue = changeAvailability.Parameters["@result"].Value.ToString();
                if (rows > 0)
                {
                    MessageBox.Show(outputValue);
                    Attendance.canTakeAttendance = true;
                }
                else
                {
                    MessageBox.Show(outputValue);
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Class ID must be a number");
            }
        }

        private void btnMakeUnavailable_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "dbo.classAvailability";
            SqlCommand changeAvailability = new SqlCommand(query, conn);
            changeAvailability.CommandType = CommandType.StoredProcedure;
            changeAvailability.Parameters.AddWithValue("@userID", CurrentLogin.currentID);
            changeAvailability.Parameters.AddWithValue("@classID", txtBoxClassID.Text);
            changeAvailability.Parameters.AddWithValue("@status", 0);
            changeAvailability.Parameters.Add("@result", SqlDbType.VarChar, 250); //specify output parameter
            changeAvailability.Parameters["@result"].Direction = ParameterDirection.Output;

            bool isNumber = int.TryParse(txtBoxClassID.Text, out _);
            if (isNumber)
            {
                int rows = changeAvailability.ExecuteNonQuery();
                string outputValue = changeAvailability.Parameters["@result"].Value.ToString();
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
                MessageBox.Show("Class ID must be a number");
            }
        }
    }
}
