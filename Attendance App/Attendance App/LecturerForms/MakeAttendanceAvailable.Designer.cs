
namespace Attendance_App.LecturerForms
{
    partial class MakeAttendanceAvailable
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewAllClassesYouTeach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxClassID = new System.Windows.Forms.TextBox();
            this.btnMakeAvailable = new System.Windows.Forms.Button();
            this.btnMakeUnavailable = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllClassesYouTeach)).BeginInit();
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
            this.btnCloseForm.TabIndex = 18;
            this.btnCloseForm.Text = "✖";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.btnMakeUnavailable);
            this.panel1.Controls.Add(this.btnMakeAvailable);
            this.panel1.Controls.Add(this.txtBoxClassID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridViewAllClassesYouTeach);
            this.panel1.Location = new System.Drawing.Point(96, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 365);
            this.panel1.TabIndex = 20;
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
            this.dataGridViewAllClassesYouTeach.Location = new System.Drawing.Point(99, 181);
            this.dataGridViewAllClassesYouTeach.Name = "dataGridViewAllClassesYouTeach";
            this.dataGridViewAllClassesYouTeach.ReadOnly = true;
            this.dataGridViewAllClassesYouTeach.Size = new System.Drawing.Size(380, 144);
            this.dataGridViewAllClassesYouTeach.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Make Attendance Available";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter class ID:";
            // 
            // txtBoxClassID
            // 
            this.txtBoxClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxClassID.Location = new System.Drawing.Point(238, 52);
            this.txtBoxClassID.Name = "txtBoxClassID";
            this.txtBoxClassID.Size = new System.Drawing.Size(208, 24);
            this.txtBoxClassID.TabIndex = 2;
            // 
            // btnMakeAvailable
            // 
            this.btnMakeAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.btnMakeAvailable.FlatAppearance.BorderSize = 0;
            this.btnMakeAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeAvailable.ForeColor = System.Drawing.Color.White;
            this.btnMakeAvailable.Location = new System.Drawing.Point(112, 113);
            this.btnMakeAvailable.Name = "btnMakeAvailable";
            this.btnMakeAvailable.Size = new System.Drawing.Size(165, 38);
            this.btnMakeAvailable.TabIndex = 3;
            this.btnMakeAvailable.Text = "Make Available";
            this.btnMakeAvailable.UseVisualStyleBackColor = false;
            this.btnMakeAvailable.Click += new System.EventHandler(this.btnMakeAvailable_Click);
            // 
            // btnMakeUnavailable
            // 
            this.btnMakeUnavailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.btnMakeUnavailable.FlatAppearance.BorderSize = 0;
            this.btnMakeUnavailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeUnavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeUnavailable.ForeColor = System.Drawing.Color.White;
            this.btnMakeUnavailable.Location = new System.Drawing.Point(319, 113);
            this.btnMakeUnavailable.Name = "btnMakeUnavailable";
            this.btnMakeUnavailable.Size = new System.Drawing.Size(160, 38);
            this.btnMakeUnavailable.TabIndex = 3;
            this.btnMakeUnavailable.Text = "Make Unavailable";
            this.btnMakeUnavailable.UseVisualStyleBackColor = false;
            this.btnMakeUnavailable.Click += new System.EventHandler(this.btnMakeUnavailable_Click);
            // 
            // MakeAttendanceAvailable
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
            this.Name = "MakeAttendanceAvailable";
            this.Text = "MakeAttendanceAvailable";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllClassesYouTeach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMakeUnavailable;
        private System.Windows.Forms.Button btnMakeAvailable;
        private System.Windows.Forms.TextBox txtBoxClassID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAllClassesYouTeach;
        private System.Windows.Forms.Label label1;
    }
}