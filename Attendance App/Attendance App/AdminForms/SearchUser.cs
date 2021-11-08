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
    public partial class SearchUser : Form
    {
        public SearchUser()
        {
            InitializeComponent();
        }
        public int Role { get; set; }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);

        private void SearchUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allUsers._allUsers' table. You can move, or remove it, as needed.
            this.allUsersTableAdapter.Fill(this.allUsers._allUsers);

        }

        private void txtBoxSearchParam_TextChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "EXEC generalSearch @searchParam";
            SqlCommand searchCommand = new SqlCommand(query, conn);
            searchCommand.Parameters.AddWithValue("@searchParam", txtBoxSearchParam.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(searchCommand);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewResults.DataSource = table;
            conn.Close();
        }
    }
}
