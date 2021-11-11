
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelUsersSubMenu = new System.Windows.Forms.Panel();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panelAccountSubMenu = new System.Windows.Forms.Panel();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelInnerForms = new System.Windows.Forms.Panel();
            this.pictureBoxNustLogo = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelUsersSubMenu.SuspendLayout();
            this.panelAccountSubMenu.SuspendLayout();
            this.panelInnerForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNustLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.panelSideMenu.Controls.Add(this.btnLogOut);
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
            this.panelSideMenu.Size = new System.Drawing.Size(240, 611);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(0, 528);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(240, 50);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            this.panelUsersSubMenu.Size = new System.Drawing.Size(240, 124);
            this.panelUsersSubMenu.TabIndex = 5;
            this.panelUsersSubMenu.Visible = false;
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
            this.btnSearchUser.Size = new System.Drawing.Size(240, 40);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Text = "Search User";
            this.btnSearchUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
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
            this.btnUpdateUser.Size = new System.Drawing.Size(240, 40);
            this.btnUpdateUser.TabIndex = 1;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
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
            this.btnAddUser.Size = new System.Drawing.Size(240, 40);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(0, 354);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(240, 50);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // panelAccountSubMenu
            // 
            this.panelAccountSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(109)))), ((int)(((byte)(122)))));
            this.panelAccountSubMenu.Controls.Add(this.btnUpdateAccount);
            this.panelAccountSubMenu.Controls.Add(this.btnViewAccount);
            this.panelAccountSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccountSubMenu.Location = new System.Drawing.Point(0, 259);
            this.panelAccountSubMenu.Name = "panelAccountSubMenu";
            this.panelAccountSubMenu.Size = new System.Drawing.Size(240, 95);
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
            this.btnUpdateAccount.Size = new System.Drawing.Size(240, 40);
            this.btnUpdateAccount.TabIndex = 1;
            this.btnUpdateAccount.Text = "Update Account";
            this.btnUpdateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
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
            this.btnViewAccount.Size = new System.Drawing.Size(240, 40);
            this.btnViewAccount.TabIndex = 0;
            this.btnViewAccount.Text = "View Account";
            this.btnViewAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAccount.UseVisualStyleBackColor = true;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
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
            this.btnAccount.Size = new System.Drawing.Size(240, 50);
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
            this.btnHome.Size = new System.Drawing.Size(240, 50);
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
            this.panelLogo.Size = new System.Drawing.Size(240, 159);
            this.panelLogo.TabIndex = 0;
            // 
            // panelInnerForms
            // 
            this.panelInnerForms.Controls.Add(this.pictureBoxNustLogo);
            this.panelInnerForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInnerForms.Location = new System.Drawing.Point(240, 0);
            this.panelInnerForms.Name = "panelInnerForms";
            this.panelInnerForms.Size = new System.Drawing.Size(744, 611);
            this.panelInnerForms.TabIndex = 1;
            // 
            // pictureBoxNustLogo
            // 
            this.pictureBoxNustLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxNustLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNustLogo.Image")));
            this.pictureBoxNustLogo.Location = new System.Drawing.Point(149, 106);
            this.pictureBoxNustLogo.Name = "pictureBoxNustLogo";
            this.pictureBoxNustLogo.Size = new System.Drawing.Size(495, 378);
            this.pictureBoxNustLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNustLogo.TabIndex = 0;
            this.pictureBoxNustLogo.TabStop = false;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panelInnerForms);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminMainForm";
            this.Text = "Attendance App";
            this.panelSideMenu.ResumeLayout(false);
            this.panelUsersSubMenu.ResumeLayout(false);
            this.panelAccountSubMenu.ResumeLayout(false);
            this.panelInnerForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNustLogo)).EndInit();
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
        private System.Windows.Forms.Panel panelInnerForms;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBoxNustLogo;
    }
}