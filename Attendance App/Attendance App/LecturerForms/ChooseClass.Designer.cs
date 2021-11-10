
namespace Attendance_App.LecturerForms
{
    partial class ChooseClass
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
            this.ViewAttendanceText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChooseClass = new System.Windows.Forms.Button();
            this.txtBoxClassID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAvailableClasses = new System.Windows.Forms.DataGridView();
            this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classesAvailableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classesAvailableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesAvailable = new Attendance_App.classesAvailable();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.classesAvailableTableAdapter = new Attendance_App.classesAvailableTableAdapters.classesAvailableTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesAvailableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesAvailableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewAttendanceText
            // 
            this.ViewAttendanceText.AutoSize = true;
            this.ViewAttendanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAttendanceText.Location = new System.Drawing.Point(279, 75);
            this.ViewAttendanceText.Name = "ViewAttendanceText";
            this.ViewAttendanceText.Size = new System.Drawing.Size(166, 31);
            this.ViewAttendanceText.TabIndex = 23;
            this.ViewAttendanceText.Text = "Select Class";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.btnChooseClass);
            this.panel1.Controls.Add(this.txtBoxClassID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewAvailableClasses);
            this.panel1.Location = new System.Drawing.Point(93, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 353);
            this.panel1.TabIndex = 24;
            // 
            // btnChooseClass
            // 
            this.btnChooseClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.btnChooseClass.FlatAppearance.BorderSize = 0;
            this.btnChooseClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseClass.ForeColor = System.Drawing.Color.White;
            this.btnChooseClass.Location = new System.Drawing.Point(361, 98);
            this.btnChooseClass.Name = "btnChooseClass";
            this.btnChooseClass.Size = new System.Drawing.Size(102, 36);
            this.btnChooseClass.TabIndex = 3;
            this.btnChooseClass.Text = "Select";
            this.btnChooseClass.UseVisualStyleBackColor = false;
            this.btnChooseClass.Click += new System.EventHandler(this.btnChooseClass_Click);
            // 
            // txtBoxClassID
            // 
            this.txtBoxClassID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxClassID.Location = new System.Drawing.Point(201, 50);
            this.txtBoxClassID.Name = "txtBoxClassID";
            this.txtBoxClassID.Size = new System.Drawing.Size(262, 24);
            this.txtBoxClassID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Class ID:";
            // 
            // dataGridViewAvailableClasses
            // 
            this.dataGridViewAvailableClasses.AllowUserToAddRows = false;
            this.dataGridViewAvailableClasses.AllowUserToDeleteRows = false;
            this.dataGridViewAvailableClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAvailableClasses.AutoGenerateColumns = false;
            this.dataGridViewAvailableClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classIDDataGridViewTextBoxColumn,
            this.classNameDataGridViewTextBoxColumn});
            this.dataGridViewAvailableClasses.DataSource = this.classesAvailableBindingSource1;
            this.dataGridViewAvailableClasses.Location = new System.Drawing.Point(122, 156);
            this.dataGridViewAvailableClasses.Name = "dataGridViewAvailableClasses";
            this.dataGridViewAvailableClasses.ReadOnly = true;
            this.dataGridViewAvailableClasses.Size = new System.Drawing.Size(341, 175);
            this.dataGridViewAvailableClasses.TabIndex = 0;
            this.dataGridViewAvailableClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAvailableClasses_CellContentClick);
            // 
            // classIDDataGridViewTextBoxColumn
            // 
            this.classIDDataGridViewTextBoxColumn.DataPropertyName = "classID";
            this.classIDDataGridViewTextBoxColumn.HeaderText = "classID";
            this.classIDDataGridViewTextBoxColumn.Name = "classIDDataGridViewTextBoxColumn";
            this.classIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classNameDataGridViewTextBoxColumn
            // 
            this.classNameDataGridViewTextBoxColumn.DataPropertyName = "ClassName";
            this.classNameDataGridViewTextBoxColumn.HeaderText = "ClassName";
            this.classNameDataGridViewTextBoxColumn.Name = "classNameDataGridViewTextBoxColumn";
            this.classNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classesAvailableBindingSource1
            // 
            this.classesAvailableBindingSource1.DataMember = "classesAvailable";
            this.classesAvailableBindingSource1.DataSource = this.classesAvailableBindingSource;
            // 
            // classesAvailableBindingSource
            // 
            this.classesAvailableBindingSource.DataSource = this.classesAvailable;
            this.classesAvailableBindingSource.Position = 0;
            // 
            // classesAvailable
            // 
            this.classesAvailable.DataSetName = "classesAvailable";
            this.classesAvailable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnCloseForm.TabIndex = 25;
            this.btnCloseForm.TabStop = false;
            this.btnCloseForm.Text = "✖";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // classesAvailableTableAdapter
            // 
            this.classesAvailableTableAdapter.ClearBeforeFill = true;
            // 
            // ChooseClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 611);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ViewAttendanceText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChooseClass";
            this.Text = "ChooseClass";
            this.Load += new System.EventHandler(this.ChooseClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesAvailableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesAvailableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesAvailable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ViewAttendanceText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChooseClass;
        private System.Windows.Forms.TextBox txtBoxClassID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAvailableClasses;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.BindingSource classesAvailableBindingSource;
        private classesAvailable classesAvailable;
        private System.Windows.Forms.BindingSource classesAvailableBindingSource1;
        private classesAvailableTableAdapters.classesAvailableTableAdapter classesAvailableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNameDataGridViewTextBoxColumn;
    }
}