
namespace Attendance_App.LecturerForms
{
    partial class ViewClasses
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewAllClassesYouTeach = new System.Windows.Forms.DataGridView();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.viewClassesYouTeach = new Attendance_App.viewClassesYouTeach();
            this.viewClassesYouTeachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewClassesYouTeachTableAdapter = new Attendance_App.viewClassesYouTeachTableAdapters.viewClassesYouTeachTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllClassesYouTeach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClassesYouTeach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClassesYouTeachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Classes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.dataGridViewAllClassesYouTeach);
            this.panel1.Location = new System.Drawing.Point(96, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 365);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewAllClassesYouTeach
            // 
            this.dataGridViewAllClassesYouTeach.AllowUserToAddRows = false;
            this.dataGridViewAllClassesYouTeach.AllowUserToDeleteRows = false;
            this.dataGridViewAllClassesYouTeach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAllClassesYouTeach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllClassesYouTeach.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridViewAllClassesYouTeach.Location = new System.Drawing.Point(93, 64);
            this.dataGridViewAllClassesYouTeach.Name = "dataGridViewAllClassesYouTeach";
            this.dataGridViewAllClassesYouTeach.ReadOnly = true;
            this.dataGridViewAllClassesYouTeach.Size = new System.Drawing.Size(380, 222);
            this.dataGridViewAllClassesYouTeach.TabIndex = 0;
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
            this.btnCloseForm.TabIndex = 15;
            this.btnCloseForm.Text = "✖";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // viewClassesYouTeach
            // 
            this.viewClassesYouTeach.DataSetName = "viewClassesYouTeach";
            this.viewClassesYouTeach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewClassesYouTeachBindingSource
            // 
            this.viewClassesYouTeachBindingSource.DataMember = "viewClassesYouTeach";
            this.viewClassesYouTeachBindingSource.DataSource = this.viewClassesYouTeach;
            // 
            // viewClassesYouTeachTableAdapter
            // 
            this.viewClassesYouTeachTableAdapter.ClearBeforeFill = true;
            // 
            // ViewClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 611);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewClasses";
            this.Text = "ViewClasses";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllClassesYouTeach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClassesYouTeach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClassesYouTeachBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewAllClassesYouTeach;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.BindingSource viewClassesYouTeachBindingSource;
        private viewClassesYouTeach viewClassesYouTeach;
        private viewClassesYouTeachTableAdapters.viewClassesYouTeachTableAdapter viewClassesYouTeachTableAdapter;
    }
}