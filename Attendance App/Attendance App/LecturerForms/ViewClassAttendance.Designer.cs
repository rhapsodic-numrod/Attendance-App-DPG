
namespace Attendance_App.LecturerForms
{
    partial class ViewClassAttendance
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
            this.components = new System.ComponentModel.Container();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewClassAttendance = new System.Windows.Forms.DataGridView();
            this.ViewAttendanceText = new System.Windows.Forms.Label();
            this.attendanceReport = new Attendance_App.attendanceReport();
            this.attendanceReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceReportTableAdapter = new Attendance_App.attendanceReportTableAdapters.attendanceReportTableAdapter();
            this.attendanceReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceReportBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.attendanceDatabaseDataSet5 = new Attendance_App.attendanceDatabaseDataSet5();
            this.viewClassesYouTeachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewClassesYouTeachTableAdapter = new Attendance_App.attendanceDatabaseDataSet5TableAdapters.viewClassesYouTeachTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceReportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceReportBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClassesYouTeachBindingSource)).BeginInit();
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.dataGridViewClassAttendance);
            this.panel1.Location = new System.Drawing.Point(97, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 383);
            this.panel1.TabIndex = 16;
            // 
            // dataGridViewClassAttendance
            // 
            this.dataGridViewClassAttendance.AllowUserToAddRows = false;
            this.dataGridViewClassAttendance.AllowUserToDeleteRows = false;
            this.dataGridViewClassAttendance.AutoGenerateColumns = false;
            this.dataGridViewClassAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.attendanceDateDataGridViewTextBoxColumn,
            this.classIDDataGridViewTextBoxColumn,
            this.attendanceStatusDataGridViewCheckBoxColumn});
            this.dataGridViewClassAttendance.DataSource = this.attendanceReportBindingSource2;
            this.dataGridViewClassAttendance.Location = new System.Drawing.Point(49, 43);
            this.dataGridViewClassAttendance.Name = "dataGridViewClassAttendance";
            this.dataGridViewClassAttendance.ReadOnly = true;
            this.dataGridViewClassAttendance.Size = new System.Drawing.Size(478, 294);
            this.dataGridViewClassAttendance.TabIndex = 0;
            // 
            // ViewAttendanceText
            // 
            this.ViewAttendanceText.AutoSize = true;
            this.ViewAttendanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAttendanceText.Location = new System.Drawing.Point(239, 97);
            this.ViewAttendanceText.Name = "ViewAttendanceText";
            this.ViewAttendanceText.Size = new System.Drawing.Size(307, 31);
            this.ViewAttendanceText.TabIndex = 19;
            this.ViewAttendanceText.Text = "View Attendance Report";
            // 
            // attendanceReport
            // 
            this.attendanceReport.DataSetName = "attendanceReport";
            this.attendanceReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceReportBindingSource
            // 
            this.attendanceReportBindingSource.DataMember = "attendanceReport";
            this.attendanceReportBindingSource.DataSource = this.attendanceReport;
            // 
            // attendanceReportTableAdapter
            // 
            this.attendanceReportTableAdapter.ClearBeforeFill = true;
            // 
            // attendanceReportBindingSource1
            // 
            this.attendanceReportBindingSource1.DataSource = this.attendanceReport;
            this.attendanceReportBindingSource1.Position = 0;
            // 
            // attendanceReportBindingSource2
            // 
            this.attendanceReportBindingSource2.DataMember = "attendanceReport";
            this.attendanceReportBindingSource2.DataSource = this.attendanceReportBindingSource1;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "studentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "studentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceDateDataGridViewTextBoxColumn
            // 
            this.attendanceDateDataGridViewTextBoxColumn.DataPropertyName = "attendanceDate";
            this.attendanceDateDataGridViewTextBoxColumn.HeaderText = "attendanceDate";
            this.attendanceDateDataGridViewTextBoxColumn.Name = "attendanceDateDataGridViewTextBoxColumn";
            this.attendanceDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classIDDataGridViewTextBoxColumn
            // 
            this.classIDDataGridViewTextBoxColumn.DataPropertyName = "classID";
            this.classIDDataGridViewTextBoxColumn.HeaderText = "classID";
            this.classIDDataGridViewTextBoxColumn.Name = "classIDDataGridViewTextBoxColumn";
            this.classIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceStatusDataGridViewCheckBoxColumn
            // 
            this.attendanceStatusDataGridViewCheckBoxColumn.DataPropertyName = "attendanceStatus";
            this.attendanceStatusDataGridViewCheckBoxColumn.HeaderText = "attendanceStatus";
            this.attendanceStatusDataGridViewCheckBoxColumn.Name = "attendanceStatusDataGridViewCheckBoxColumn";
            this.attendanceStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // attendanceDatabaseDataSet5
            // 
            this.attendanceDatabaseDataSet5.DataSetName = "attendanceDatabaseDataSet5";
            this.attendanceDatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewClassesYouTeachBindingSource
            // 
            this.viewClassesYouTeachBindingSource.DataMember = "viewClassesYouTeach";
            this.viewClassesYouTeachBindingSource.DataSource = this.attendanceDatabaseDataSet5;
            // 
            // viewClassesYouTeachTableAdapter
            // 
            this.viewClassesYouTeachTableAdapter.ClearBeforeFill = true;
            // 
            // ViewClassAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 611);
            this.Controls.Add(this.ViewAttendanceText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCloseForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewClassAttendance";
            this.Text = "ViewClassAttendance";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceReportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceReportBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClassesYouTeachBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewClassAttendance;
        private System.Windows.Forms.Label ViewAttendanceText;
        private System.Windows.Forms.BindingSource attendanceReportBindingSource;
        private attendanceReport attendanceReport;
        private attendanceReportTableAdapters.attendanceReportTableAdapter attendanceReportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn attendanceStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource attendanceReportBindingSource2;
        private System.Windows.Forms.BindingSource attendanceReportBindingSource1;
        private System.Windows.Forms.BindingSource viewClassesYouTeachBindingSource;
        private attendanceDatabaseDataSet5 attendanceDatabaseDataSet5;
        private attendanceDatabaseDataSet5TableAdapters.viewClassesYouTeachTableAdapter viewClassesYouTeachTableAdapter;
    }
}