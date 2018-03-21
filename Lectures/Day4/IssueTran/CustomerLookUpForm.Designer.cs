namespace Lectures.Day4.IssueTran
{
    partial class CustomerLookUpForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelLookUpButton = new System.Windows.Forms.Button();
            this.CustomerIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberCategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerIdColumn,
            this.CustomerNameColumn,
            this.MemberCategoryColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(955, 806);
            this.dataGridView1.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(326, 812);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(148, 45);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelLookUpButton
            // 
            this.CancelLookUpButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelLookUpButton.Location = new System.Drawing.Point(480, 812);
            this.CancelLookUpButton.Name = "CancelLookUpButton";
            this.CancelLookUpButton.Size = new System.Drawing.Size(148, 45);
            this.CancelLookUpButton.TabIndex = 2;
            this.CancelLookUpButton.Text = "Cancel";
            this.CancelLookUpButton.UseVisualStyleBackColor = true;
            this.CancelLookUpButton.Click += new System.EventHandler(this.CancelLookUpButton_Click);
            // 
            // CustomerIdColumn
            // 
            this.CustomerIdColumn.DataPropertyName = "CustomerId";
            this.CustomerIdColumn.HeaderText = "Customer ID";
            this.CustomerIdColumn.Name = "CustomerIdColumn";
            this.CustomerIdColumn.Width = 225;
            // 
            // CustomerNameColumn
            // 
            this.CustomerNameColumn.DataPropertyName = "CustomerName";
            this.CustomerNameColumn.HeaderText = "Customer Name";
            this.CustomerNameColumn.Name = "CustomerNameColumn";
            this.CustomerNameColumn.Width = 251;
            // 
            // MemberCategoryColumn
            // 
            this.MemberCategoryColumn.DataPropertyName = "MemberCategory";
            this.MemberCategoryColumn.HeaderText = "Category";
            this.MemberCategoryColumn.Name = "MemberCategoryColumn";
            this.MemberCategoryColumn.Width = 184;
            // 
            // CustomerLookUpForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelLookUpButton;
            this.ClientSize = new System.Drawing.Size(955, 869);
            this.Controls.Add(this.CancelLookUpButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerLookUpForm";
            this.Text = "CustomerLookUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelLookUpButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberCategoryColumn;
    }
}