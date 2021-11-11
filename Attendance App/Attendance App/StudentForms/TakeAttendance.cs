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

namespace Attendance_App.StudentForms
{
    public partial class TakeAttendance : Form
    {
        public TakeAttendance()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        private void TakeAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendanceDatabaseDataSet1.studentModules' table. You can move, or remove it, as needed.
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "dbo.studentModuleFilter";
            SqlCommand filterCommand = new SqlCommand(query, conn);
            filterCommand.CommandType = CommandType.StoredProcedure;
            filterCommand.Parameters.AddWithValue("@userID", CurrentLogin.currentID);
            DataTable filteredTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(filterCommand);
            //adapter
            adapter.Fill(filteredTable);

            comboBoxModule.DataSource = filteredTable;
            

            conn.Close();
        }
        public void absentAttendance(string classID)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "dbo.takeAttendance";
            SqlCommand presentAttendance = new SqlCommand(query, conn);
            presentAttendance.CommandType = CommandType.StoredProcedure;
            presentAttendance.Parameters.AddWithValue("@userID", CurrentLogin.currentID);
            presentAttendance.Parameters.AddWithValue("@classID", classID);
            presentAttendance.Parameters.AddWithValue("@status", 0);
            presentAttendance.Parameters.Add("@result", SqlDbType.VarChar, 250); //specify output parameter
            presentAttendance.Parameters["@result"].Direction = ParameterDirection.Output;

            int rows = presentAttendance.ExecuteNonQuery();
            string outputValue = presentAttendance.Parameters["@result"].Value.ToString();
            if (rows > 0)
            {
                MessageBox.Show(outputValue);
            }
            else
            {
                MessageBox.Show(outputValue);
            }
        }
        private void comboBoxModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "dbo.classesThatCanBeAttended";
         
            if (comboBoxModule.SelectedValue != null)
            {
                int moduleVal;
                Int32.TryParse(comboBoxModule.SelectedValue.ToString(), out moduleVal);
                SqlCommand viewClassesTaken = new SqlCommand(query, conn);
                viewClassesTaken.CommandType = CommandType.StoredProcedure;
                viewClassesTaken.Parameters.AddWithValue("@studentID", CurrentLogin.currentID);
                viewClassesTaken.Parameters.AddWithValue("@moduleID", moduleVal);
                SqlDataAdapter adapter = new SqlDataAdapter(viewClassesTaken);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewClassesToBeAttended.DataSource = table;
                if (table != null)
                {
                    if (table.Rows.Count != 0)
                    {
                        btnPresent.Visible = true;
                    }
                    else
                    {
                        btnPresent.Visible = false;
                    }
                }
                conn.Close();
            }
        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "dbo.takeAttendance";
            SqlCommand presentAttendance = new SqlCommand(query, conn);
            presentAttendance.CommandType = CommandType.StoredProcedure;
            presentAttendance.Parameters.AddWithValue("@userID", CurrentLogin.currentID);
            presentAttendance.Parameters.AddWithValue("@classID", txtBoxClassID.Text);
            presentAttendance.Parameters.AddWithValue("@status", 1);
            presentAttendance.Parameters.Add("@result", SqlDbType.VarChar, 250); //specify output parameter
            presentAttendance.Parameters["@result"].Direction = ParameterDirection.Output;

            int rows = presentAttendance.ExecuteNonQuery();
            string outputValue = presentAttendance.Parameters["@result"].Value.ToString();
            if (rows > 0)
            {
                MessageBox.Show(outputValue);
                btnPresent.Visible = false;
                btnAbsent.Visible = false;
            }
            else
            {
                MessageBox.Show(outputValue);
            }

        }

        private void btnAbsent_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "dbo.takeAttendance";
            SqlCommand presentAttendance = new SqlCommand(query, conn);
            presentAttendance.CommandType = CommandType.StoredProcedure;
            presentAttendance.Parameters.AddWithValue("@userID", CurrentLogin.currentID);
            presentAttendance.Parameters.AddWithValue("@classID", txtBoxClassID.Text);
            presentAttendance.Parameters.AddWithValue("@status", 0);
            presentAttendance.Parameters.Add("@result", SqlDbType.VarChar, 250); //specify output parameter
            presentAttendance.Parameters["@result"].Direction = ParameterDirection.Output;

            int rows = presentAttendance.ExecuteNonQuery();
            string outputValue = presentAttendance.Parameters["@result"].Value.ToString();
            if (rows > 0)
            {
                MessageBox.Show(outputValue);
                btnPresent.Visible = false;
                btnAbsent.Visible = false;
            }
            else
            {
                MessageBox.Show(outputValue);
            }
        }
    }
}
