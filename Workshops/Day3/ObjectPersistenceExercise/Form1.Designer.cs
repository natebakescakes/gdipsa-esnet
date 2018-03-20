namespace Workshops.Day3.ObjectPersistenceExercise
{
    partial class Form1
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
            this.QuestionSelector = new System.Windows.Forms.ComboBox();
            this.RetrieveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1684, 717);
            this.dataGridView1.TabIndex = 0;
            // 
            // QuestionSelector
            // 
            this.QuestionSelector.FormattingEnabled = true;
            this.QuestionSelector.Items.AddRange(new object[] {
            "Question 4a",
            "Question 4b",
            "Question 4c",
            "Question 4d",
            "Question 4e",
            "Question 4f"});
            this.QuestionSelector.Location = new System.Drawing.Point(13, 728);
            this.QuestionSelector.Name = "QuestionSelector";
            this.QuestionSelector.Size = new System.Drawing.Size(1443, 39);
            this.QuestionSelector.TabIndex = 1;
            // 
            // RetrieveButton
            // 
            this.RetrieveButton.Location = new System.Drawing.Point(1463, 728);
            this.RetrieveButton.Name = "RetrieveButton";
            this.RetrieveButton.Size = new System.Drawing.Size(209, 40);
            this.RetrieveButton.TabIndex = 2;
            this.RetrieveButton.Text = "Execute";
            this.RetrieveButton.UseVisualStyleBackColor = true;
            this.RetrieveButton.Click += new System.EventHandler(this.RetrieveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 780);
            this.Controls.Add(this.RetrieveButton);
            this.Controls.Add(this.QuestionSelector);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox QuestionSelector;
        private System.Windows.Forms.Button RetrieveButton;
    }
}

