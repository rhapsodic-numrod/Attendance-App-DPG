using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_App.AppClasses;

namespace Attendance_App.AdminForms
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }
        #region Button Hide and Show
        private void hideSubMenu()
        {
            if (panelAccountSubMenu.Visible == true)
            {
                panelAccountSubMenu.Visible = false;
            }
            if (panelUsersSubMenu.Visible == true)
            {
                panelUsersSubMenu.Visible = false;
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
        #region Main Buttons
        private void btnAccount_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAccountSubMenu);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUsersSubMenu);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }
        #endregion

        ChildForms form = new ChildForms();
        #region Account Sub Menu
        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            form.openChildForm(new ViewAccount(), panelInnerForms);
            hideSubMenu();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            form.openChildForm(new UpdateAccount(), panelInnerForms);
            hideSubMenu();
        }

        #endregion
        #region Users Sub Menu
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            form.openChildForm(new AddUserForm(), panelInnerForms);
            hideSubMenu();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            form.openChildForm(new UpdateUser(), panelInnerForms);
            hideSubMenu();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            form.openChildForm(new SearchUser(), panelInnerForms);
            hideSubMenu();
        }
        #endregion
    }
}
