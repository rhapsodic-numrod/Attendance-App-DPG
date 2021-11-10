
namespace Attendance_App.LecturerForms
{
    partial class LecturerMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelClassesSubMenu = new System.Windows.Forms.Panel();
            this.btnAddStudentGrades = new System.Windows.Forms.Button();
            this.btnViewClassAttendance = new System.Windows.Forms.Button();
            this.btnViewClasses = new System.Windows.Forms.Button();
            this.btnClasses = new System.Windows.Forms.Button();
            this.panelAccountSubMenu = new System.Windows.Forms.Panel();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelInnerForms = new System.Windows.Forms.Panel();
            this.btnChooseClasses = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelClassesSubMenu.SuspendLayout();
            this.panelAccountSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.panelSideMenu.Controls.Add(this.btnLogOut);
            this.panelSideMenu.Controls.Add(this.panelClassesSubMenu);
            this.panelSideMenu.Controls.Add(this.btnClasses);
            this.panelSideMenu.Controls.Add(this.panelAccountSubMenu);
            this.panelSideMenu.Controls.Add(this.btnAccount);
            this.panelSideMenu.Controls.Add(this.btnHome);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(240, 611);
            this.panelSideMenu.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(0, 572);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(223, 50);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panelClassesSubMenu
            // 
            this.panelClassesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(109)))), ((int)(((byte)(122)))));
            this.panelClassesSubMenu.Controls.Add(this.btnChooseClasses);
            this.panelClassesSubMenu.Controls.Add(this.btnAddStudentGrades);
            this.panelClassesSubMenu.Controls.Add(this.btnViewClassAttendance);
            this.panelClassesSubMenu.Controls.Add(this.btnViewClasses);
            this.panelClassesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClassesSubMenu.Location = new System.Drawing.Point(0, 404);
            this.panelClassesSubMenu.Name = "panelClassesSubMenu";
            this.panelClassesSubMenu.Size = new System.Drawing.Size(223, 168);
            this.panelClassesSubMenu.TabIndex = 5;
            this.panelClassesSubMenu.Visible = false;
            // 
            // btnAddStudentGrades
            // 
            this.btnAddStudentGrades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddStudentGrades.FlatAppearance.BorderSize = 0;
            this.btnAddStudentGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudentGrades.ForeColor = System.Drawing.Color.White;
            this.btnAddStudentGrades.Location = new System.Drawing.Point(0, 80);
            this.btnAddStudentGrades.Name = "btnAddStudentGrades";
            this.btnAddStudentGrades.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddStudentGrades.Size = new System.Drawing.Size(223, 40);
            this.btnAddStudentGrades.TabIndex = 2;
            this.btnAddStudentGrades.Text = "Add Student Grades";
            this.btnAddStudentGrades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudentGrades.UseVisualStyleBackColor = true;
            this.btnAddStudentGrades.Click += new System.EventHandler(this.btnAddStudentGrades_Click);
            // 
            // btnViewClassAttendance
            // 
            this.btnViewClassAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewClassAttendance.FlatAppearance.BorderSize = 0;
            this.btnViewClassAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewClassAttendance.ForeColor = System.Drawing.Color.White;
            this.btnViewClassAttendance.Location = new System.Drawing.Point(0, 40);
            this.btnViewClassAttendance.Name = "btnViewClassAttendance";
            this.btnViewClassAttendance.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnViewClassAttendance.Size = new System.Drawing.Size(223, 40);
            this.btnViewClassAttendance.TabIndex = 1;
            this.btnViewClassAttendance.Text = "View Class Attendance";
            this.btnViewClassAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewClassAttendance.UseVisualStyleBackColor = true;
            this.btnViewClassAttendance.Click += new System.EventHandler(this.btnViewClassAttendance_Click);
            // 
            // btnViewClasses
            // 
            this.btnViewClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewClasses.FlatAppearance.BorderSize = 0;
            this.btnViewClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewClasses.ForeColor = System.Drawing.Color.White;
            this.btnViewClasses.Location = new System.Drawing.Point(0, 0);
            this.btnViewClasses.Name = "btnViewClasses";
            this.btnViewClasses.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnViewClasses.Size = new System.Drawing.Size(223, 40);
            this.btnViewClasses.TabIndex = 0;
            this.btnViewClasses.Text = "View Classes";
            this.btnViewClasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewClasses.UseVisualStyleBackColor = true;
            this.btnViewClasses.Click += new System.EventHandler(this.btnViewClasses_Click);
            // 
            // btnClasses
            // 
            this.btnClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btnClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClasses.FlatAppearance.BorderSize = 0;
            this.btnClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClasses.ForeColor = System.Drawing.Color.White;
            this.btnClasses.Location = new System.Drawing.Point(0, 354);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClasses.Size = new System.Drawing.Size(223, 50);
            this.btnClasses.TabIndex = 4;
            this.btnClasses.Text = "Classes";
            this.btnClasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClasses.UseVisualStyleBackColor = false;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // panelAccountSubMenu
            // 
            this.panelAccountSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(109)))), ((int)(((byte)(122)))));
            this.panelAccountSubMenu.Controls.Add(this.btnUpdateAccount);
            this.panelAccountSubMenu.Controls.Add(this.btnViewAccount);
            this.panelAccountSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccountSubMenu.Location = new System.Drawing.Point(0, 259);
            this.panelAccountSubMenu.Name = "panelAccountSubMenu";
            this.panelAccountSubMenu.Size = new System.Drawing.Size(223, 95);
            this.panelAccountSubMenu.TabIndex = 3;
            this.panelAccountSubMenu.Visible = false;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateAccount.FlatAppearance.BorderSize = 0;
            this.btnUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAccount.Location = new System.Drawing.Point(0, 40);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUpdateAccount.Size = new System.Drawing.Size(223, 40);
            this.btnUpdateAccount.TabIndex = 1;
            this.btnUpdateAccount.Text = "Update Account";
            this.btnUpdateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click_1);
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewAccount.FlatAppearance.BorderSize = 0;
            this.btnViewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAccount.ForeColor = System.Drawing.Color.White;
            this.btnViewAccount.Location = new System.Drawing.Point(0, 0);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnViewAccount.Size = new System.Drawing.Size(223, 40);
            this.btnViewAccount.TabIndex = 0;
            this.btnViewAccount.Text = "View Account";
            this.btnViewAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAccount.UseVisualStyleBackColor = true;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click_1);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(0, 209);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(223, 50);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 159);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(223, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(223, 159);
            this.panelLogo.TabIndex = 0;
            // 
            // panelInnerForms
            // 
            this.panelInnerForms.BackColor = System.Drawing.Color.White;
            this.panelInnerForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInnerForms.Location = new System.Drawing.Point(240, 0);
            this.panelInnerForms.Name = "panelInnerForms";
            this.panelInnerForms.Size = new System.Drawing.Size(744, 611);
            this.panelInnerForms.TabIndex = 2;
            // 
            // btnChooseClasses
            // 
            this.btnChooseClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChooseClasses.FlatAppearance.BorderSize = 0;
            this.btnChooseClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseClasses.ForeColor = System.Drawing.Color.White;
            this.btnChooseClasses.Location = new System.Drawing.Point(0, 120);
            this.btnChooseClasses.Name = "btnChooseClasses";
            this.btnChooseClasses.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnChooseClasses.Size = new System.Drawing.Size(223, 40);
            this.btnChooseClasses.TabIndex = 3;
            this.btnChooseClasses.Text = "Choose Classes";
            this.btnChooseClasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseClasses.UseVisualStyleBackColor = true;
            this.btnChooseClasses.Click += new System.EventHandler(this.btnChooseClasses_Click);
            // 
            // LecturerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panelInnerForms);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LecturerMainForm";
            this.Text = "Attendance App";
            this.panelSideMenu.ResumeLayout(false);
            this.panelClassesSubMenu.ResumeLayout(false);
            this.panelAccountSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelClassesSubMenu;
        private System.Windows.Forms.Button btnAddStudentGrades;
        private System.Windows.Forms.Button btnViewClassAttendance;
        private System.Windows.Forms.Button btnViewClasses;
        private System.Windows.Forms.Button btnClasses;
        private System.Windows.Forms.Panel panelAccountSubMenu;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelInnerForms;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnChooseClasses;
    }
}