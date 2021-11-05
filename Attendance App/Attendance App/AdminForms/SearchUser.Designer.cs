
namespace Attendance_App.AdminForms
{
    partial class SearchUser
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
            this.SearchText = new System.Windows.Forms.Label();
            this.panelSearchBox = new System.Windows.Forms.Panel();
            this.txtBoxSearchParam = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.panelSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchText
            // 
            this.SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchText.AutoSize = true;
            this.SearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.Location = new System.Drawing.Point(282, 58);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(165, 31);
            this.SearchText.TabIndex = 0;
            this.SearchText.Text = "Search User";
            // 
            // panelSearchBox
            // 
            this.panelSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.panelSearchBox.Controls.Add(this.dataGridView1);
            this.panelSearchBox.Controls.Add(this.btnSearch);
            this.panelSearchBox.Controls.Add(this.txtBoxSearchParam);
            this.panelSearchBox.Location = new System.Drawing.Point(84, 117);
            this.panelSearchBox.Name = "panelSearchBox";
            this.panelSearchBox.Size = new System.Drawing.Size(587, 419);
            this.panelSearchBox.TabIndex = 1;
            // 
            // txtBoxSearchParam
            // 
            this.txtBoxSearchParam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearchParam.Location = new System.Drawing.Point(79, 44);
            this.txtBoxSearchParam.Name = "txtBoxSearchParam";
            this.txtBoxSearchParam.Size = new System.Drawing.Size(324, 23);
            this.txtBoxSearchParam.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(436, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(122, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 258);
            this.dataGridView1.TabIndex = 2;
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
            this.btnCloseForm.TabIndex = 10;
            this.btnCloseForm.Text = "✖";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            // 
            // SearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 611);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.panelSearchBox);
            this.Controls.Add(this.SearchText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchUser";
            this.Text = "SearchUser";
            this.panelSearchBox.ResumeLayout(false);
            this.panelSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchText;
        private System.Windows.Forms.Panel panelSearchBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxSearchParam;
        private System.Windows.Forms.Button btnCloseForm;
    }
}