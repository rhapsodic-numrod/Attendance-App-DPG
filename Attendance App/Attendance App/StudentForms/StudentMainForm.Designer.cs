namespace Attendance_App.StudentForms
{
    partial class StudentMainForm
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
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelAccountSubMenu = new System.Windows.Forms.Panel();
            this.panelInnerForms = new System.Windows.Forms.Panel();
            this.ClassesText = new System.Windows.Forms.Label();
            this.ClassNameLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.TakeAttendanceLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ExamEligibilityLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ExamEligibilityStatusLabel = new System.Windows.Forms.Label();
            this.ExamEligibilityModuleLabel = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelAccountSubMenu.SuspendLayout();
            this.panelInnerForms.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btnAccount.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.panelSideMenu.Controls.Add(this.panelAccountSubMenu);
            this.panelSideMenu.Controls.Add(this.btnAccount);
            this.panelSideMenu.Controls.Add(this.btnHome);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(240, 844);
            this.panelSideMenu.TabIndex = 1;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
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
            // panelInnerForms
            // 
            this.panelInnerForms.Controls.Add(this.tableLayoutPanel2);
            this.panelInnerForms.Controls.Add(this.ExamEligibilityLabel);
            this.panelInnerForms.Controls.Add(this.tableLayoutPanel1);
            this.panelInnerForms.Controls.Add(this.ClassesText);
            this.panelInnerForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInnerForms.Location = new System.Drawing.Point(240, 0);
            this.panelInnerForms.Name = "panelInnerForms";
            this.panelInnerForms.Size = new System.Drawing.Size(943, 844);
            this.panelInnerForms.TabIndex = 2;
            // 
            // ClassesText
            // 
            this.ClassesText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassesText.AutoSize = true;
            this.ClassesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassesText.Location = new System.Drawing.Point(427, 18);
            this.ClassesText.Name = "ClassesText";
            this.ClassesText.Size = new System.Drawing.Size(112, 31);
            this.ClassesText.TabIndex = 1;
            this.ClassesText.Text = "Classes";
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassNameLabel.Location = new System.Drawing.Point(3, 0);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(221, 26);
            this.ClassNameLabel.TabIndex = 3;
            this.ClassNameLabel.Text = "Name";
            this.ClassNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClassNameLabel.Click += new System.EventHandler(this.ClassNameLabel_Click);
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLabel.Location = new System.Drawing.Point(230, 0);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(221, 26);
            this.StartTimeLabel.TabIndex = 4;
            this.StartTimeLabel.Text = "Start Time";
            this.StartTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartTimeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TakeAttendanceLabel
            // 
            this.TakeAttendanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TakeAttendanceLabel.AutoSize = true;
            this.TakeAttendanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakeAttendanceLabel.Location = new System.Drawing.Point(457, 0);
            this.TakeAttendanceLabel.Name = "TakeAttendanceLabel";
            this.TakeAttendanceLabel.Size = new System.Drawing.Size(232, 26);
            this.TakeAttendanceLabel.TabIndex = 5;
            this.TakeAttendanceLabel.Text = "Take Attendance";
            this.TakeAttendanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tableLayoutPanel1.Controls.Add(this.TakeAttendanceLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.StartTimeLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ClassNameLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(136, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.932657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.41347F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.41347F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.41347F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.41347F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.41347F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 333);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ExamEligibilityLabel
            // 
            this.ExamEligibilityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExamEligibilityLabel.AutoSize = true;
            this.ExamEligibilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamEligibilityLabel.Location = new System.Drawing.Point(375, 437);
            this.ExamEligibilityLabel.Name = "ExamEligibilityLabel";
            this.ExamEligibilityLabel.Size = new System.Drawing.Size(195, 31);
            this.ExamEligibilityLabel.TabIndex = 7;
            this.ExamEligibilityLabel.Text = "Exam Eligibility";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.ExamEligibilityStatusLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ExamEligibilityModuleLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(136, 471);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.90991F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.21622F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.41347F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.41347F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.41347F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.41347F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(692, 333);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // ExamEligibilityStatusLabel
            // 
            this.ExamEligibilityStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExamEligibilityStatusLabel.AutoSize = true;
            this.ExamEligibilityStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamEligibilityStatusLabel.Location = new System.Drawing.Point(349, 0);
            this.ExamEligibilityStatusLabel.Name = "ExamEligibilityStatusLabel";
            this.ExamEligibilityStatusLabel.Size = new System.Drawing.Size(340, 31);
            this.ExamEligibilityStatusLabel.TabIndex = 4;
            this.ExamEligibilityStatusLabel.Text = "ExamEligibilityStatus";
            this.ExamEligibilityStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExamEligibilityModuleLabel
            // 
            this.ExamEligibilityModuleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExamEligibilityModuleLabel.AutoSize = true;
            this.ExamEligibilityModuleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamEligibilityModuleLabel.Location = new System.Drawing.Point(3, 0);
            this.ExamEligibilityModuleLabel.Name = "ExamEligibilityModuleLabel";
            this.ExamEligibilityModuleLabel.Size = new System.Drawing.Size(340, 31);
            this.ExamEligibilityModuleLabel.TabIndex = 3;
            this.ExamEligibilityModuleLabel.Text = "Module";
            this.ExamEligibilityModuleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1183, 844);
            this.Controls.Add(this.panelInnerForms);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "StudentMainForm";
            this.Text = "StudentMainForm";
            this.panelSideMenu.ResumeLayout(false);
            this.panelAccountSubMenu.ResumeLayout(false);
            this.panelInnerForms.ResumeLayout(false);
            this.panelInnerForms.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelAccountSubMenu;
        private System.Windows.Forms.Panel panelInnerForms;
        private System.Windows.Forms.Label TakeAttendanceLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label ClassNameLabel;
        private System.Windows.Forms.Label ClassesText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ExamEligibilityStatusLabel;
        private System.Windows.Forms.Label ExamEligibilityModuleLabel;
        private System.Windows.Forms.Label ExamEligibilityLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}