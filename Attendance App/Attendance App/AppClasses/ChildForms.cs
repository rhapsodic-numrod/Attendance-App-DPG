using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_App.AdminForms;
using Attendance_App.LecturerForms;

namespace Attendance_App.AppClasses
{
    class ChildForms
    {
        private static Form activeForm = null;
        public static void openChildForm(Form childForm, Panel childPanel)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childPanel.Controls.Add(childForm);
            childPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
