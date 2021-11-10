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
    public partial class ChooseClass : Form
    {
        public ChooseClass()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        private void btnChooseClass_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "dbo.LecturerChooseClass";
            SqlCommand selectClass = new SqlCommand(query, conn);
            selectClass.CommandType = CommandType.StoredProcedure;
            selectClass.Parameters.AddWithValue("@userID", CurrentLogin.currentID);
            selectClass.Parameters.AddWithValue("@classID", txtBoxClassID.Text);
            selectClass.Parameters.Add("@result", SqlDbType.VarChar, 250); //specify output parameter
            selectClass.Parameters["@result"].Direction = ParameterDirection.Output;

            SqlDataReader reader = selectClass.ExecuteReader();
            string outputValue = selectClass.Parameters["@result"].Value.ToString(); //store the value in the output parameter
            if (reader.HasRows)
            {
                MessageBox.Show(outputValue);
            }
            else
            {
                MessageBox.Show(outputValue);
            }
            reader.Close();
            conn.Close();
        }

        private void dataGridViewAvailableClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChooseClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classesAvailable._classesAvailable' table. You can move, or remove it, as needed.
            this.classesAvailableTableAdapter.Fill(this.classesAvailable._classesAvailable);

        }
    }
}
