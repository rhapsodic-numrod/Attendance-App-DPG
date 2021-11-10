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
    public partial class ViewClasses : Form
    {
        public ViewClasses()
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
    }
}
