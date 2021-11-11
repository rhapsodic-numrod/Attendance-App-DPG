
namespace Attendance_App.StudentForms
{
    partial class TakeAttendance
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxModule = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxClassID = new System.Windows.Forms.TextBox();
            this.btnPresent = new System.Windows.Forms.Button();
            this.dataGridViewClassesToBeAttended = new System.Windows.Forms.DataGridView();
            this.attendanceDatabaseDataSet1 = new Attendance_App.attendanceDatabaseDataSet1();
            this.studentModulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentModulesTableAdapter = new Attendance_App.attendanceDatabaseDataSet1TableAdapters.studentModulesTableAdapter();
            this.attendanceDatabaseDataSet2 = new Attendance_App.attendanceDatabaseDataSet2();
            this.studentModuleFilterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentModuleFilterTableAdapter = new Attendance_App.attendanceDatabaseDataSet2TableAdapters.studentModuleFilterTableAdapter();
            this.btnAbsent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassesToBeAttended)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentModulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentModuleFilterBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.btnCloseForm.TabIndex = 17;
            this.btnCloseForm.Text = "✖";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Take Attendance";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.btnAbsent);
            this.panel1.Controls.Add(this.dataGridViewClassesToBeAttended);
            this.panel1.Controls.Add(this.btnPresent);
            this.panel1.Controls.Add(this.txtBoxClassID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxModule);
            this.panel1.Location = new System.Drawing.Point(70, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 345);
            this.panel1.TabIndex = 19;
            // 
            // comboBoxModule
            // 
            this.comboBoxModule.DataSource = this.studentModuleFilterBindingSource;
            this.comboBoxModule.DisplayMember = "moduleName";
            this.comboBoxModule.FormattingEnabled = true;
            this.comboBoxModule.Location = new System.Drawing.Point(43, 30);
            this.comboBoxModule.Name = "comboBoxModule";
            this.comboBoxModule.Size = new System.Drawing.Size(121, 24);
            this.comboBoxModule.TabIndex = 0;
            this.comboBoxModule.ValueMember = "moduleID";
            this.comboBoxModule.SelectedIndexChanged += new System.EventHandler(this.comboBoxModule_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter class ID from classes below:";
            // 
            // txtBoxClassID
            // 
            this.txtBoxClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxClassID.Location = new System.Drawing.Point(357, 86);
            this.txtBoxClassID.Name = "txtBoxClassID";
            this.txtBoxClassID.Size = new System.Drawing.Size(159, 24);
            this.txtBoxClassID.TabIndex = 2;
            // 
            // btnPresent
            // 
            this.btnPresent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.btnPresent.FlatAppearance.BorderSize = 0;
            this.btnPresent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresent.ForeColor = System.Drawing.Color.White;
            this.btnPresent.Location = new System.Drawing.Point(229, 285);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(181, 35);
            this.btnPresent.TabIndex = 3;
            this.btnPresent.Text = "Attendance Present";
            this.btnPresent.UseVisualStyleBackColor = false;
            this.btnPresent.Visible = false;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // dataGridViewClassesToBeAttended
            // 
            this.dataGridViewClassesToBeAttended.AllowUserToAddRows = false;
            this.dataGridViewClassesToBeAttended.AllowUserToDeleteRows = false;
            this.dataGridViewClassesToBeAttended.AllowUserToResizeColumns = false;
            this.dataGridViewClassesToBeAttended.AllowUserToResizeRows = false;
            this.dataGridViewClassesToBeAttended.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassesToBeAttended.Location = new System.Drawing.Point(153, 128);
            this.dataGridViewClassesToBeAttended.Name = "dataGridViewClassesToBeAttended";
            this.dataGridViewClassesToBeAttended.Size = new System.Drawing.Size(322, 134);
            this.dataGridViewClassesToBeAttended.TabIndex = 5;
            // 
            // attendanceDatabaseDataSet1
            // 
            this.attendanceDatabaseDataSet1.DataSetName = "attendanceDatabaseDataSet1";
            this.attendanceDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentModulesBindingSource
            // 
            this.studentModulesBindingSource.DataMember = "studentModules";
            this.studentModulesBindingSource.DataSource = this.attendanceDatabaseDataSet1;
            // 
            // studentModulesTableAdapter
            // 
            this.studentModulesTableAdapter.ClearBeforeFill = true;
            // 
            // attendanceDatabaseDataSet2
            // 
            this.attendanceDatabaseDataSet2.DataSetName = "attendanceDatabaseDataSet2";
            this.attendanceDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentModuleFilterBindingSource
            // 
            this.studentModuleFilterBindingSource.DataMember = "studentModuleFilter";
            this.studentModuleFilterBindingSource.DataSource = this.attendanceDatabaseDataSet2;
            // 
            // studentModuleFilterTableAdapter
            // 
            this.studentModuleFilterTableAdapter.ClearBeforeFill = true;
            // 
            // btnAbsent
            // 
            this.btnAbsent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.btnAbsent.FlatAppearance.BorderSize = 0;
            this.btnAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsent.ForeColor = System.Drawing.Color.White;
            this.btnAbsent.Location = new System.Drawing.Point(458, 285);
            this.btnAbsent.Name = "btnAbsent";
            this.btnAbsent.Size = new System.Drawing.Size(99, 35);
            this.btnAbsent.TabIndex = 6;
            this.btnAbsent.Text = "Absent";
            this.btnAbsent.UseVisualStyleBackColor = false;
            this.btnAbsent.Click += new System.EventHandler(this.btnAbsent_Click);
            // 
            // TakeAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TakeAttendance";
            this.Text = "TakeAttendance";
            this.Load += new System.EventHandler(this.TakeAttendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassesToBeAttended)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentModulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentModuleFilterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.TextBox txtBoxClassID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxModule;
        private System.Windows.Forms.DataGridView dataGridViewClassesToBeAttended;
        private attendanceDatabaseDataSet1 attendanceDatabaseDataSet1;
        private System.Windows.Forms.BindingSource studentModulesBindingSource;
        private attendanceDatabaseDataSet1TableAdapters.studentModulesTableAdapter studentModulesTableAdapter;
        private System.Windows.Forms.BindingSource studentModuleFilterBindingSource;
        private attendanceDatabaseDataSet2 attendanceDatabaseDataSet2;
        private attendanceDatabaseDataSet2TableAdapters.studentModuleFilterTableAdapter studentModuleFilterTableAdapter;
        private System.Windows.Forms.Button btnAbsent;
    }
}