
namespace Attendance_App.AdminForms
{
    partial class AdminMainForm
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panelAccountSubMenu = new System.Windows.Forms.Panel();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panelUsersSubMenu = new System.Windows.Forms.Panel();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelAccountSubMenu.SuspendLayout();
            this.panelUsersSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.panelSideMenu.Controls.Add(this.panelUsersSubMenu);
            this.panelSideMenu.Controls.Add(this.btnUsers);
            this.panelSideMenu.Controls.Add(this.panelAccountSubMenu);
            this.panelSideMenu.Controls.Add(this.btnAccount);
            this.panelSideMenu.Controls.Add(this.btnHome);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(245, 611);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(245, 159);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 159);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(245, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(0, 209);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(245, 50);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.UseVisualStyleBackColor = false;
            // 
            // panelAccountSubMenu
            // 
            this.panelAccountSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(109)))), ((int)(((byte)(122)))));
            this.panelAccountSubMenu.Controls.Add(this.btnUpdateAccount);
            this.panelAccountSubMenu.Controls.Add(this.btnViewAccount);
            this.panelAccountSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccountSubMenu.Location = new System.Drawing.Point(0, 259);
            this.panelAccountSubMenu.Name = "panelAccountSubMenu";
            this.panelAccountSubMenu.Size = new System.Drawing.Size(245, 95);
            this.panelAccountSubMenu.TabIndex = 3;
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
            this.btnViewAccount.Size = new System.Drawing.Size(245, 40);
            this.btnViewAccount.TabIndex = 0;
            this.btnViewAccount.Text = "View Account";
            this.btnViewAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAccount.UseVisualStyleBackColor = true;
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
            this.btnUpdateAccount.Size = new System.Drawing.Size(245, 40);
            this.btnUpdateAccount.TabIndex = 1;
            this.btnUpdateAccount.Text = "Update Account";
            this.btnUpdateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(0, 354);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(245, 50);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(0, 40);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUpdateUser.Size = new System.Drawing.Size(245, 40);
            this.btnUpdateUser.TabIndex = 1;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(0, 0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddUser.Size = new System.Drawing.Size(245, 40);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // panelUsersSubMenu
            // 
            this.panelUsersSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(109)))), ((int)(((byte)(122)))));
            this.panelUsersSubMenu.Controls.Add(this.btnSearchUser);
            this.panelUsersSubMenu.Controls.Add(this.btnUpdateUser);
            this.panelUsersSubMenu.Controls.Add(this.btnAddUser);
            this.panelUsersSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsersSubMenu.Location = new System.Drawing.Point(0, 404);
            this.panelUsersSubMenu.Name = "panelUsersSubMenu";
            this.panelUsersSubMenu.Size = new System.Drawing.Size(245, 124);
            this.panelUsersSubMenu.TabIndex = 5;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchUser.FlatAppearance.BorderSize = 0;
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser.Location = new System.Drawing.Point(0, 80);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSearchUser.Size = new System.Drawing.Size(245, 40);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Text = "Search User";
            this.btnSearchUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchUser.UseVisualStyleBackColor = true;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminMainForm";
            this.Text = "Attendance App";
            this.panelSideMenu.ResumeLayout(false);
            this.panelAccountSubMenu.ResumeLayout(false);
            this.panelUsersSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelUsersSubMenu;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel panelAccountSubMenu;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelLogo;
    }
}