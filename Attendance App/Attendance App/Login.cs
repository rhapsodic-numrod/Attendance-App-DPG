using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_App.AdminForms;
using Attendance_App.LecturerForms;
using Attendance_App.StudentForms;
using Attendance_App.AppClasses;
using System.Configuration;

namespace Attendance_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public int Role { get; set; }
        static string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        private void loginBtn_Click(object sender, EventArgs e)
        {

            //SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            //DataTable dtbl = new DataTable();
            //sda.Fill(dtbl);
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tenge\Documents\GitHub\Attendance-App-DPG\database structure\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            //SqlConnection conn = new SqlConnection(myconnstring);
            // "Select * from dbo.Login Where studentID = '" +txtBoxID.Text.Trim()+ "' and studentPassword = '" + txtBoxPassword.Text.Trim() + "'";
            // Open Connection
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            //Create Command
            if (txtBoxID.Text != "" && txtBoxPassword.Text != "")
            {
                string query = "LoginUser";
                SqlCommand loginCommand = new SqlCommand(query, conn);
                loginCommand.CommandType = CommandType.StoredProcedure;
                //add COMMAND parameters
                loginCommand.Parameters.AddWithValue("@userID", txtBoxID.Text);
                loginCommand.Parameters.AddWithValue("@password", txtBoxPassword.Text);
                loginCommand.Parameters.AddWithValue("@role", Role);
                loginCommand.Parameters.Add("@result", SqlDbType.VarChar, 250); //specify output parameter
                loginCommand.Parameters["@result"].Direction = ParameterDirection.Output;
                //Creates a reader and executes command
                SqlDataReader reader = loginCommand.ExecuteReader();
                // If the reader finds a row
                bool successfull = (reader.HasRows) ? true : false;
                // Close reader
                reader.Close();
                string outputValue = loginCommand.Parameters["@result"].Value.ToString();
                //I think this one is self explanatory
                if (successfull)
                {
                    CurrentLogin.currentID = txtBoxID.Text;
                    CurrentLogin.currentRole = Role;
                    MessageBox.Show(outputValue);
                    if (Role == 1) //Student
                    {
                        MessageBox.Show("Welcome back " + txtBoxID.Text);

                        StudentMainForm objStudentMainForm = new StudentForms.StudentMainForm();
                        this.Hide();
                        objStudentMainForm.Show();

                    }
                    else if (Role == 2) //Lecturer
                    {
                        MessageBox.Show("Welcome back " + txtBoxID.Text);
                        LecturerMainForm lecturerHome = new LecturerMainForm();
                        this.Hide();
                        lecturerHome.Show();
                    }
                    else if (Role == 3) //Admin
                    {
                        MessageBox.Show("Welcome back " + txtBoxID.Text);
                        //Close the login form and go to the admin home form
                        AdminMainForm adminHome = new AdminMainForm();
                        this.Hide();
                        adminHome.Show();
                    }
                }
                else
                {
                    MessageBox.Show(outputValue);
                }
            }
            else
            {
                MessageBox.Show("Username or Password Missing!");
            }
        }
        #region Role radio selection
        private void studentRadio_CheckedChanged(object sender, EventArgs e)
        {
            Role = 1;
            label1.Text = "Student ID"; //Says Student Number on run. Just check that later

        }

        private void lecturerRadio_CheckedChanged(object sender, EventArgs e)
        {
            Role = 2;
            label1.Text = "Employee ID";
        }

        private void adminRadio_CheckedChanged(object sender, EventArgs e)
        {
            Role = 3;
            label1.Text = "Admin ID";
        }
        #endregion
        private void changePasswordChar(TextBox txtBox)
        {
            if (txtBox.PasswordChar == '*')
            {
                txtBox.PasswordChar = '\0'; //if you will see the password as text instead of a *
            }
            else
            {
                txtBox.PasswordChar = '*';
            }
        }
        private void checkBoxViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            changePasswordChar(txtBoxPassword);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
            //Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
