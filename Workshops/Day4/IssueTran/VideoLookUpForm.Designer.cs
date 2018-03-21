namespace Workshops.Day4.IssueTran
{
    partial class VideoLookUpForm
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
            this.CancelLookUpButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.VideoCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalStockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberRentedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VideoCodeColumn,
            this.MovieTitleColumn,
            this.MovieTypeColumn,
            this.RentalCostColumn,
            this.TotalStockColumn,
            this.NumberRentedColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1570, 806);
            this.dataGridView1.TabIndex = 0;
            // 
            // CancelLookUpButton
            // 
            this.CancelLookUpButton.Location = new System.Drawing.Point(796, 812);
            this.CancelLookUpButton.Name = "CancelLookUpButton";
            this.CancelLookUpButton.Size = new System.Drawing.Size(148, 45);
            this.CancelLookUpButton.TabIndex = 4;
            this.CancelLookUpButton.Text = "Cancel";
            this.CancelLookUpButton.UseVisualStyleBackColor = true;
            this.CancelLookUpButton.Click += new System.EventHandler(this.CancelLookUpButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(642, 812);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(148, 45);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // VideoCodeColumn
            // 
            this.VideoCodeColumn.DataPropertyName = "VideoCode";
            this.VideoCodeColumn.HeaderText = "Video ID";
            this.VideoCodeColumn.Name = "VideoCodeColumn";
            this.VideoCodeColumn.Width = 177;
            // 
            // MovieTitleColumn
            // 
            this.MovieTitleColumn.DataPropertyName = "MovieTitle";
            this.MovieTitleColumn.HeaderText = "Movie Title";
            this.MovieTitleColumn.Name = "MovieTitleColumn";
            this.MovieTitleColumn.Width = 207;
            // 
            // MovieTypeColumn
            // 
            this.MovieTypeColumn.DataPropertyName = "MovieType";
            this.MovieTypeColumn.HeaderText = "Genre";
            this.MovieTypeColumn.Name = "MovieTypeColumn";
            this.MovieTypeColumn.Width = 148;
            // 
            // RentalCostColumn
            // 
            this.RentalCostColumn.DataPropertyName = "RentalPrice";
            this.RentalCostColumn.HeaderText = "Rental Cost";
            this.RentalCostColumn.Name = "RentalCostColumn";
            this.RentalCostColumn.Width = 217;
            // 
            // TotalStockColumn
            // 
            this.TotalStockColumn.DataPropertyName = "TotalStock";
            this.TotalStockColumn.HeaderText = "Total Stock";
            this.TotalStockColumn.Name = "TotalStockColumn";
            this.TotalStockColumn.Width = 211;
            // 
            // NumberRentedColumn
            // 
            this.NumberRentedColumn.DataPropertyName = "NumberRented";
            this.NumberRentedColumn.HeaderText = "Stock Rented";
            this.NumberRentedColumn.Name = "NumberRentedColumn";
            this.NumberRentedColumn.Width = 239;
            // 
            // VideoLookUpForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelLookUpButton;
            this.ClientSize = new System.Drawing.Size(1570, 869);
            this.Controls.Add(this.CancelLookUpButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VideoLookUpForm";
            this.Text = "VideoLookUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CancelLookUpButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalStockColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberRentedColumn;
    }
}