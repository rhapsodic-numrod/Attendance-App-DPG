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
    public partial class AddStudentGrades : Form
    {
        public AddStudentGrades()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "searchByUserID";
            SqlCommand searchCommand = new SqlCommand(query, conn);
            searchCommand.CommandType = CommandType.StoredProcedure;
            searchCommand.Parameters.AddWithValue("@userID", txtBoxStudID.Text);
            searchCommand.Parameters.AddWithValue("@role", 1);
            searchCommand.Parameters.Add("@result", SqlDbType.VarChar, 250); //specify output parameter
            searchCommand.Parameters["@result"].Direction = ParameterDirection.Output;

            SqlDataReader reader = searchCommand.ExecuteReader();
            while (reader.Read())
            {
                txtBoxStudName.Text = reader.GetValue(1).ToString() + " " + reader.GetValue(3).ToString();
            }
            reader.Close();
            conn.Close();
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            //TODO: Add functionality for adding grade
        }
        private void viewLecturerModule()
        {

        }
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lecturerModulesTableAdapter.Fill(this.attendanceDatabaseDataSet3.lecturerModules, CurrentLogin.currentID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
