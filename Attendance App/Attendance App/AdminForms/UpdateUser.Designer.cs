
namespace Attendance_App.AdminForms
{
    partial class UpdateUser
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
            this.updateUserText = new System.Windows.Forms.Label();
            this.panelUpdateBox = new System.Windows.Forms.Panel();
            this.txtBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.btnGetUserInfo = new System.Windows.Forms.Button();
            this.txtBoxFName = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtBoxMName = new System.Windows.Forms.TextBox();
            this.lblMName = new System.Windows.Forms.Label();
            this.txtBoxUserID = new System.Windows.Forms.TextBox();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioLecturer = new System.Windows.Forms.RadioButton();
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.lblEnterUserID = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.panelUpdateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateUserText
            // 
            this.updateUserText.AutoSize = true;
            this.updateUserText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateUserText.Location = new System.Drawing.Point(273, 58);
            this.updateUserText.Name = "updateUserText";
            this.updateUserText.Size = new System.Drawing.Size(167, 31);
            this.updateUserText.TabIndex = 0;
            this.updateUserText.Text = "Update User";
            // 
            // panelUpdateBox
            // 
            this.panelUpdateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.panelUpdateBox.Controls.Add(this.txtBoxPhoneNum);
            this.panelUpdateBox.Controls.Add(this.lblMobileNumber);
            this.panelUpdateBox.Controls.Add(this.btnGetUserInfo);
            this.panelUpdateBox.Controls.Add(this.txtBoxFName);
            this.panelUpdateBox.Controls.Add(this.lblFname);
            this.panelUpdateBox.Controls.Add(this.txtBoxEmail);
            this.panelUpdateBox.Controls.Add(this.lblEmail);
            this.panelUpdateBox.Controls.Add(this.txtBoxLName);
            this.panelUpdateBox.Controls.Add(this.lblLName);
            this.panelUpdateBox.Controls.Add(this.txtBoxMName);
            this.panelUpdateBox.Controls.Add(this.lblMName);
            this.panelUpdateBox.Controls.Add(this.txtBoxUserID);
            this.panelUpdateBox.Controls.Add(this.radioAdmin);
            this.panelUpdateBox.Controls.Add(this.radioLecturer);
            this.panelUpdateBox.Controls.Add(this.radioStudent);
            this.panelUpdateBox.Controls.Add(this.lblEnterUserID);
            this.panelUpdateBox.Location = new System.Drawing.Point(93, 119);
            this.panelUpdateBox.Name = "panelUpdateBox";
            this.panelUpdateBox.Size = new System.Drawing.Size(560, 406);
            this.panelUpdateBox.TabIndex = 1;
            // 
            // txtBoxPhoneNum
            // 
            this.txtBoxPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPhoneNum.Location = new System.Drawing.Point(198, 333);
            this.txtBoxPhoneNum.Name = "txtBoxPhoneNum";
            this.txtBoxPhoneNum.Size = new System.Drawing.Size(281, 24);
            this.txtBoxPhoneNum.TabIndex = 28;
            // 
            // lblMobileNumber
            // 
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Location = new System.Drawing.Point(86, 336);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(107, 17);
            this.lblMobileNumber.TabIndex = 27;
            this.lblMobileNumber.Text = "Mobile Number:";
            // 
            // btnGetUserInfo
            // 
            this.btnGetUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.btnGetUserInfo.FlatAppearance.BorderSize = 0;
            this.btnGetUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetUserInfo.ForeColor = System.Drawing.Color.White;
            this.btnGetUserInfo.Location = new System.Drawing.Point(419, 70);
            this.btnGetUserInfo.Name = "btnGetUserInfo";
            this.btnGetUserInfo.Size = new System.Drawing.Size(76, 40);
            this.btnGetUserInfo.TabIndex = 26;
            this.btnGetUserInfo.Text = "Get Info";
            this.btnGetUserInfo.UseVisualStyleBackColor = false;
            this.btnGetUserInfo.Click += new System.EventHandler(this.btnGetUserInfo_Click);
            // 
            // txtBoxFName
            // 
            this.txtBoxFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFName.Location = new System.Drawing.Point(198, 130);
            this.txtBoxFName.Name = "txtBoxFName";
            this.txtBoxFName.Size = new System.Drawing.Size(281, 24);
            this.txtBoxFName.TabIndex = 25;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(86, 133);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(80, 17);
            this.lblFname.TabIndex = 24;
            this.lblFname.Text = "First Name:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(198, 284);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(281, 24);
            this.txtBoxEmail.TabIndex = 23;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(86, 287);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 17);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email Adress:";
            // 
            // txtBoxLName
            // 
            this.txtBoxLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLName.Location = new System.Drawing.Point(198, 233);
            this.txtBoxLName.Name = "txtBoxLName";
            this.txtBoxLName.Size = new System.Drawing.Size(281, 24);
            this.txtBoxLName.TabIndex = 21;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(86, 236);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(80, 17);
            this.lblLName.TabIndex = 20;
            this.lblLName.Text = "Last Name:";
            // 
            // txtBoxMName
            // 
            this.txtBoxMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMName.Location = new System.Drawing.Point(198, 184);
            this.txtBoxMName.Name = "txtBoxMName";
            this.txtBoxMName.Size = new System.Drawing.Size(281, 24);
            this.txtBoxMName.TabIndex = 19;
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Location = new System.Drawing.Point(86, 187);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(94, 17);
            this.lblMName.TabIndex = 18;
            this.lblMName.Text = "Middle Name:";
            // 
            // txtBoxUserID
            // 
            this.txtBoxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserID.Location = new System.Drawing.Point(198, 77);
            this.txtBoxUserID.Name = "txtBoxUserID";
            this.txtBoxUserID.Size = new System.Drawing.Size(189, 24);
            this.txtBoxUserID.TabIndex = 16;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Location = new System.Drawing.Point(403, 18);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(65, 21);
            this.radioAdmin.TabIndex = 15;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            this.radioAdmin.CheckedChanged += new System.EventHandler(this.radioAdmin_CheckedChanged);
            // 
            // radioLecturer
            // 
            this.radioLecturer.AutoSize = true;
            this.radioLecturer.Location = new System.Drawing.Point(244, 18);
            this.radioLecturer.Name = "radioLecturer";
            this.radioLecturer.Size = new System.Drawing.Size(79, 21);
            this.radioLecturer.TabIndex = 14;
            this.radioLecturer.TabStop = true;
            this.radioLecturer.Text = "Lecturer";
            this.radioLecturer.UseVisualStyleBackColor = true;
            this.radioLecturer.CheckedChanged += new System.EventHandler(this.radioLecturer_CheckedChanged);
            // 
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.Location = new System.Drawing.Point(89, 18);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(75, 21);
            this.radioStudent.TabIndex = 13;
            this.radioStudent.TabStop = true;
            this.radioStudent.Text = "Student";
            this.radioStudent.UseVisualStyleBackColor = true;
            this.radioStudent.CheckedChanged += new System.EventHandler(this.radioStudent_CheckedChanged);
            // 
            // lblEnterUserID
            // 
            this.lblEnterUserID.AutoSize = true;
            this.lblEnterUserID.Location = new System.Drawing.Point(86, 80);
            this.lblEnterUserID.Name = "lblEnterUserID";
            this.lblEnterUserID.Size = new System.Drawing.Size(95, 17);
            this.lblEnterUserID.TabIndex = 0;
            this.lblEnterUserID.Text = "Enter user ID:";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Crimson;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(681, 21);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(32, 32);
            this.btnCloseForm.TabIndex = 10;
            this.btnCloseForm.Text = "✖";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(574, 548);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(117, 41);
            this.btnUpdateUser.TabIndex = 11;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 611);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.panelUpdateBox);
            this.Controls.Add(this.updateUserText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            this.panelUpdateBox.ResumeLayout(false);
            this.panelUpdateBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateUserText;
        private System.Windows.Forms.Panel panelUpdateBox;
        private System.Windows.Forms.Label lblEnterUserID;
        private System.Windows.Forms.TextBox txtBoxUserID;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.RadioButton radioLecturer;
        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.TextBox txtBoxFName;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtBoxMName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Button btnGetUserInfo;
        private System.Windows.Forms.TextBox txtBoxPhoneNum;
        private System.Windows.Forms.Label lblMobileNumber;
    }
}