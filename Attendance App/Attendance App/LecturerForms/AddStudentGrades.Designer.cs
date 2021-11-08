
namespace Attendance_App.LecturerForms
{
    partial class AddStudentGrades
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
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.ViewAttendanceText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.txtBoxStudGrade = new System.Windows.Forms.TextBox();
            this.txtBoxStudName = new System.Windows.Forms.TextBox();
            this.txtBoxStudID = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblStudName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStudentsDetails = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentsDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseForm.BackColor = System.Drawing.Color.Crimson;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(681, 21);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(32, 32);
            this.btnCloseForm.TabIndex = 15;
            this.btnCloseForm.Text = "✖";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(88, 67);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(134, 24);
            this.comboBoxCourse.TabIndex = 21;
            // 
            // ViewAttendanceText
            // 
            this.ViewAttendanceText.AutoSize = true;
            this.ViewAttendanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAttendanceText.Location = new System.Drawing.Point(171, 108);
            this.ViewAttendanceText.Name = "ViewAttendanceText";
            this.ViewAttendanceText.Size = new System.Drawing.Size(356, 31);
            this.ViewAttendanceText.TabIndex = 22;
            this.ViewAttendanceText.Text = "Add Student Grade - Course";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.btnAddGrade);
            this.panel1.Controls.Add(this.btnGetInfo);
            this.panel1.Controls.Add(this.txtBoxStudGrade);
            this.panel1.Controls.Add(this.txtBoxStudName);
            this.panel1.Controls.Add(this.txtBoxStudID);
            this.panel1.Controls.Add(this.lblGrade);
            this.panel1.Controls.Add(this.lblStudName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewStudentsDetails);
            this.panel1.Location = new System.Drawing.Point(88, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 406);
            this.panel1.TabIndex = 20;
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.btnAddGrade.FlatAppearance.BorderSize = 0;
            this.btnAddGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrade.ForeColor = System.Drawing.Color.White;
            this.btnAddGrade.Location = new System.Drawing.Point(358, 198);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(102, 36);
            this.btnAddGrade.TabIndex = 3;
            this.btnAddGrade.Text = "Add Grade";
            this.btnAddGrade.UseVisualStyleBackColor = false;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.btnGetInfo.FlatAppearance.BorderSize = 0;
            this.btnGetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetInfo.ForeColor = System.Drawing.Color.White;
            this.btnGetInfo.Location = new System.Drawing.Point(385, 65);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(75, 36);
            this.btnGetInfo.TabIndex = 3;
            this.btnGetInfo.Text = "Get Info";
            this.btnGetInfo.UseVisualStyleBackColor = false;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // txtBoxStudGrade
            // 
            this.txtBoxStudGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudGrade.Location = new System.Drawing.Point(198, 162);
            this.txtBoxStudGrade.Name = "txtBoxStudGrade";
            this.txtBoxStudGrade.Size = new System.Drawing.Size(101, 24);
            this.txtBoxStudGrade.TabIndex = 2;
            // 
            // txtBoxStudName
            // 
            this.txtBoxStudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudName.Location = new System.Drawing.Point(198, 115);
            this.txtBoxStudName.Name = "txtBoxStudName";
            this.txtBoxStudName.Size = new System.Drawing.Size(168, 24);
            this.txtBoxStudName.TabIndex = 2;
            // 
            // txtBoxStudID
            // 
            this.txtBoxStudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudID.Location = new System.Drawing.Point(198, 70);
            this.txtBoxStudID.Name = "txtBoxStudID";
            this.txtBoxStudID.Size = new System.Drawing.Size(168, 24);
            this.txtBoxStudID.TabIndex = 2;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(98, 165);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(78, 17);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.Text = "Grade (%):";
            // 
            // lblStudName
            // 
            this.lblStudName.AutoSize = true;
            this.lblStudName.Location = new System.Drawing.Point(98, 118);
            this.lblStudName.Name = "lblStudName";
            this.lblStudName.Size = new System.Drawing.Size(49, 17);
            this.lblStudName.TabIndex = 1;
            this.lblStudName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID:";
            // 
            // dataGridViewStudentsDetails
            // 
            this.dataGridViewStudentsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentsDetails.Location = new System.Drawing.Point(48, 262);
            this.dataGridViewStudentsDetails.Name = "dataGridViewStudentsDetails";
            this.dataGridViewStudentsDetails.Size = new System.Drawing.Size(478, 122);
            this.dataGridViewStudentsDetails.TabIndex = 0;
            // 
            // AddStudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 611);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.ViewAttendanceText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCloseForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddStudentGrades";
            this.Text = "AddStudentGrades";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentsDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label ViewAttendanceText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox txtBoxStudGrade;
        private System.Windows.Forms.TextBox txtBoxStudName;
        private System.Windows.Forms.TextBox txtBoxStudID;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblStudName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStudentsDetails;
    }
}