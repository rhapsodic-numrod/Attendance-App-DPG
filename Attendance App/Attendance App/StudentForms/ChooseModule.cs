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
    public partial class ChooseModule : Form
    {
        public ChooseModule()
        {
            InitializeComponent();
        }

        private void ChooseModule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendanceDatabaseDataSet.Module' table. You can move, or remove it, as needed.
            this.moduleTableAdapter.Fill(this.attendanceDatabaseDataSet.Module);

        }
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        private void btnChooseModule_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "dbo.StudentAddModule";
            SqlCommand selectClass = new SqlCommand(query, conn);
            selectClass.CommandType = CommandType.StoredProcedure;
            selectClass.Parameters.AddWithValue("@userID", CurrentLogin.currentID);
            selectClass.Parameters.AddWithValue("@moduleID", txtBoxModuleID.Text);
            selectClass.Parameters.Add("@result", SqlDbType.VarChar, 250); //specify output parameter
            selectClass.Parameters["@result"].Direction = ParameterDirection.Output;

            bool isNumber = int.TryParse(txtBoxModuleID.Text, out _);
            if (isNumber)
            {
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
            else
            {
                MessageBox.Show("Module ID must be a number");
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
