using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public int Role { get; set; }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (Role == 1) //Student
            {
                MessageBox.Show("Welcome back " + txtBoxID.Text);
            } 
            else if (Role == 2) //Lecturer
            {
                MessageBox.Show("Welcome back " + txtBoxID.Text);
            }
            else if (Role == 3) //Admin
            {
                MessageBox.Show("Welcome back " + txtBoxID.Text);
            }
        }
        #region Role radio selection
        private void studentRadio_CheckedChanged(object sender, EventArgs e)
        {
            Role = 1;
        }

        private void lecturerRadio_CheckedChanged(object sender, EventArgs e)
        {
            Role = 2;
        }

        private void adminRadio_CheckedChanged(object sender, EventArgs e)
        {
            Role = 3;
        }
        #endregion

        private void checkBoxViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxPassword.PasswordChar == '*')
            {
                txtBoxPassword.PasswordChar = '\0'; //if you will see the password as text instead of a *
            }
            else
            {
                txtBoxPassword.PasswordChar = '*';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
