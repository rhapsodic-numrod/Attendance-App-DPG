
namespace Attendance_App.StudentForms
{
    partial class ChooseModule
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
            this.ViewAttendanceText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChooseModule = new System.Windows.Forms.Button();
            this.txtBoxModuleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAvailableModules = new System.Windows.Forms.DataGridView();
            this.attendanceDatabaseDataSet = new Attendance_App.attendanceDatabaseDataSet();
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduleTableAdapter = new Attendance_App.attendanceDatabaseDataSetTableAdapters.ModuleTableAdapter();
            this.moduleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
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
            this.btnCloseForm.TabIndex = 26;
            this.btnCloseForm.Text = "✖";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // ViewAttendanceText
            // 
            this.ViewAttendanceText.AutoSize = true;
            this.ViewAttendanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAttendanceText.Location = new System.Drawing.Point(273, 59);
            this.ViewAttendanceText.Name = "ViewAttendanceText";
            this.ViewAttendanceText.Size = new System.Drawing.Size(199, 31);
            this.ViewAttendanceText.TabIndex = 27;
            this.ViewAttendanceText.Text = "Select Modules";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.btnChooseModule);
            this.panel1.Controls.Add(this.txtBoxModuleID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewAvailableModules);
            this.panel1.Location = new System.Drawing.Point(96, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 353);
            this.panel1.TabIndex = 28;
            // 
            // btnChooseModule
            // 
            this.btnChooseModule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.btnChooseModule.FlatAppearance.BorderSize = 0;
            this.btnChooseModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseModule.ForeColor = System.Drawing.Color.White;
            this.btnChooseModule.Location = new System.Drawing.Point(361, 98);
            this.btnChooseModule.Name = "btnChooseModule";
            this.btnChooseModule.Size = new System.Drawing.Size(102, 36);
            this.btnChooseModule.TabIndex = 3;
            this.btnChooseModule.Text = "Select";
            this.btnChooseModule.UseVisualStyleBackColor = false;
            this.btnChooseModule.Click += new System.EventHandler(this.btnChooseModule_Click);
            // 
            // txtBoxModuleID
            // 
            this.txtBoxModuleID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxModuleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxModuleID.Location = new System.Drawing.Point(213, 50);
            this.txtBoxModuleID.Name = "txtBoxModuleID";
            this.txtBoxModuleID.Size = new System.Drawing.Size(262, 24);
            this.txtBoxModuleID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Module ID:";
            // 
            // dataGridViewAvailableModules
            // 
            this.dataGridViewAvailableModules.AllowUserToAddRows = false;
            this.dataGridViewAvailableModules.AllowUserToDeleteRows = false;
            this.dataGridViewAvailableModules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAvailableModules.AutoGenerateColumns = false;
            this.dataGridViewAvailableModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableModules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moduleIDDataGridViewTextBoxColumn,
            this.moduleNameDataGridViewTextBoxColumn});
            this.dataGridViewAvailableModules.DataSource = this.moduleBindingSource;
            this.dataGridViewAvailableModules.Location = new System.Drawing.Point(122, 156);
            this.dataGridViewAvailableModules.Name = "dataGridViewAvailableModules";
            this.dataGridViewAvailableModules.ReadOnly = true;
            this.dataGridViewAvailableModules.Size = new System.Drawing.Size(341, 175);
            this.dataGridViewAvailableModules.TabIndex = 0;
            // 
            // attendanceDatabaseDataSet
            // 
            this.attendanceDatabaseDataSet.DataSetName = "attendanceDatabaseDataSet";
            this.attendanceDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moduleBindingSource
            // 
            this.moduleBindingSource.DataMember = "Module";
            this.moduleBindingSource.DataSource = this.attendanceDatabaseDataSet;
            // 
            // moduleTableAdapter
            // 
            this.moduleTableAdapter.ClearBeforeFill = true;
            // 
            // moduleIDDataGridViewTextBoxColumn
            // 
            this.moduleIDDataGridViewTextBoxColumn.DataPropertyName = "moduleID";
            this.moduleIDDataGridViewTextBoxColumn.HeaderText = "moduleID";
            this.moduleIDDataGridViewTextBoxColumn.Name = "moduleIDDataGridViewTextBoxColumn";
            this.moduleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moduleNameDataGridViewTextBoxColumn
            // 
            this.moduleNameDataGridViewTextBoxColumn.DataPropertyName = "moduleName";
            this.moduleNameDataGridViewTextBoxColumn.HeaderText = "moduleName";
            this.moduleNameDataGridViewTextBoxColumn.Name = "moduleNameDataGridViewTextBoxColumn";
            this.moduleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ChooseModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ViewAttendanceText);
            this.Controls.Add(this.btnCloseForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChooseModule";
            this.Text = "ChooseModule";
            this.Load += new System.EventHandler(this.ChooseModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label ViewAttendanceText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChooseModule;
        private System.Windows.Forms.TextBox txtBoxModuleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAvailableModules;
        private attendanceDatabaseDataSet attendanceDatabaseDataSet;
        private System.Windows.Forms.BindingSource moduleBindingSource;
        private attendanceDatabaseDataSetTableAdapters.ModuleTableAdapter moduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleNameDataGridViewTextBoxColumn;
    }
}