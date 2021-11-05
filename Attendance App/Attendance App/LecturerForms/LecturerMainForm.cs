using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_App.LecturerForms
{
    public partial class LecturerMainForm : Form
    {
        public LecturerMainForm()
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

        #region Main Button Actions
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
        #endregion
    }
}
