using Attendance_App.AppClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_App.StudentForms
{
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClassNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Button Hide and Show
        private void hideSubMenu()
        {
            if (panelAccountSubMenu.Visible == true)
            {
                panelAccountSubMenu.Visible = false;
            }
            if (panelClassesSubMenu.Visible == true)
            {
                panelClassesSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false) //if the submenu not visible
            {
                hideSubMenu();          // hide all other submenus
                subMenu.Visible = true; // then make the submenu visible
            }
            else
            {
                subMenu.Visible = false; // other wise hide the submenu if it is visible
            }
        }

        #endregion

        #region Main button Actions
        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAccountSubMenu);
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClassesSubMenu);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            CurrentLogin.currentID = null;
            CurrentLogin.currentID = null;
            Login loginForm = new Login();
            this.Close();
            loginForm.Show();
        }

        #endregion

        #region Account submenu options
        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            ChildForms.openChildForm(new ViewAccount(), panelInnerForms);
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            ChildForms.openChildForm(new UpdateAccount(), panelInnerForms);
        }
        #endregion

        #region Classes submenu options
        private void btnViewClasses_Click(object sender, EventArgs e)
        {
            ChildForms.openChildForm(new ViewClasses(), panelInnerForms);
        }

        private void btnViewClassAttendance_Click(object sender, EventArgs e)
        {

        }

        private void btnChooseModules_Click(object sender, EventArgs e)
        {
            ChildForms.openChildForm(new ChooseModule(), panelInnerForms);
        }
        #endregion
    }
}
