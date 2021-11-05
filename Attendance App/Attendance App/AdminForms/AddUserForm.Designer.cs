
namespace Attendance_App.AdminForms
{
    partial class AddUserForm
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
            this.addUserText = new System.Windows.Forms.Label();
            this.panelAddUserContainer = new System.Windows.Forms.Panel();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtBoxFname = new System.Windows.Forms.TextBox();
            this.txtBoxLName = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.txtBoxMName = new System.Windows.Forms.TextBox();
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.radioLecturer = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panelAddUserContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // addUserText
            // 
            this.addUserText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserText.AutoSize = true;
            this.addUserText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addUserText.Location = new System.Drawing.Point(312, 55);
            this.addUserText.Name = "addUserText";
            this.addUserText.Size = new System.Drawing.Size(127, 31);
            this.addUserText.TabIndex = 0;
            this.addUserText.Text = "Add User";
            // 
            // panelAddUserContainer
            // 
            this.panelAddUserContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAddUserContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.panelAddUserContainer.Controls.Add(this.radioAdmin);
            this.panelAddUserContainer.Controls.Add(this.radioLecturer);
            this.panelAddUserContainer.Controls.Add(this.radioStudent);
            this.panelAddUserContainer.Controls.Add(this.txtBoxMName);
            this.panelAddUserContainer.Controls.Add(this.txtBoxPhoneNo);
            this.panelAddUserContainer.Controls.Add(this.txtBoxEmail);
            this.panelAddUserContainer.Controls.Add(this.txtBoxLName);
            this.panelAddUserContainer.Controls.Add(this.txtBoxFname);
            this.panelAddUserContainer.Controls.Add(this.lblPhoneNo);
            this.panelAddUserContainer.Controls.Add(this.lblEmail);
            this.panelAddUserContainer.Controls.Add(this.lblLName);
            this.panelAddUserContainer.Controls.Add(this.lblMName);
            this.panelAddUserContainer.Controls.Add(this.lblFname);
            this.panelAddUserContainer.Location = new System.Drawing.Point(101, 109);
            this.panelAddUserContainer.Name = "panelAddUserContainer";
            this.panelAddUserContainer.Size = new System.Drawing.Size(560, 412);
            this.panelAddUserContainer.TabIndex = 1;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(59, 58);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(85, 18);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name:";
            this.lblFname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMName.Location = new System.Drawing.Point(59, 119);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(99, 18);
            this.lblMName.TabIndex = 1;
            this.lblMName.Text = "Middle Name:";
            this.lblMName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(59, 180);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(84, 18);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name:";
            this.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(59, 241);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(107, 18);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email Address:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(59, 302);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(56, 18);
            this.lblPhoneNo.TabIndex = 4;
            this.lblPhoneNo.Text = "Mobile:";
            this.lblPhoneNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxFname
            // 
            this.txtBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFname.Location = new System.Drawing.Point(207, 55);
            this.txtBoxFname.Name = "txtBoxFname";
            this.txtBoxFname.Size = new System.Drawing.Size(286, 24);
            this.txtBoxFname.TabIndex = 5;
            // 
            // txtBoxLName
            // 
            this.txtBoxLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLName.Location = new System.Drawing.Point(207, 177);
            this.txtBoxLName.Name = "txtBoxLName";
            this.txtBoxLName.Size = new System.Drawing.Size(286, 24);
            this.txtBoxLName.TabIndex = 6;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(207, 238);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(286, 24);
            this.txtBoxEmail.TabIndex = 7;
            // 
            // txtBoxPhoneNo
            // 
            this.txtBoxPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPhoneNo.Location = new System.Drawing.Point(207, 302);
            this.txtBoxPhoneNo.Name = "txtBoxPhoneNo";
            this.txtBoxPhoneNo.Size = new System.Drawing.Size(286, 24);
            this.txtBoxPhoneNo.TabIndex = 8;
            // 
            // txtBoxMName
            // 
            this.txtBoxMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMName.Location = new System.Drawing.Point(207, 116);
            this.txtBoxMName.Name = "txtBoxMName";
            this.txtBoxMName.Size = new System.Drawing.Size(286, 24);
            this.txtBoxMName.TabIndex = 9;
            // 
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.Location = new System.Drawing.Point(92, 357);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(75, 21);
            this.radioStudent.TabIndex = 10;
            this.radioStudent.TabStop = true;
            this.radioStudent.Text = "Student";
            this.radioStudent.UseVisualStyleBackColor = true;
            // 
            // radioLecturer
            // 
            this.radioLecturer.AutoSize = true;
            this.radioLecturer.Location = new System.Drawing.Point(247, 357);
            this.radioLecturer.Name = "radioLecturer";
            this.radioLecturer.Size = new System.Drawing.Size(79, 21);
            this.radioLecturer.TabIndex = 11;
            this.radioLecturer.TabStop = true;
            this.radioLecturer.Text = "Lecturer";
            this.radioLecturer.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Location = new System.Drawing.Point(406, 357);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(65, 21);
            this.radioAdmin.TabIndex = 12;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(574, 548);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(87, 41);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            // 
            // AddUserForm
            // 
            this.AcceptButton = this.btnAddUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 611);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.panelAddUserContainer);
            this.Controls.Add(this.addUserText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.panelAddUserContainer.ResumeLayout(false);
            this.panelAddUserContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addUserText;
        private System.Windows.Forms.Panel panelAddUserContainer;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.RadioButton radioLecturer;
        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.TextBox txtBoxMName;
        private System.Windows.Forms.TextBox txtBoxPhoneNo;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxLName;
        private System.Windows.Forms.TextBox txtBoxFname;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Button btnAddUser;
    }
}