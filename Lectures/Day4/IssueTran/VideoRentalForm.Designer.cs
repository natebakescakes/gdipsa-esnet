namespace Lectures.Day4.IssueTran
{
    partial class VideoRentalForm
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
            this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.VideoCodeTextBox = new System.Windows.Forms.TextBox();
            this.IssueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RemarksTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CustomerLookUpButton = new System.Windows.Forms.Button();
            this.VideoLookUpButton = new System.Windows.Forms.Button();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.VideoNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerIdTextBox
            // 
            this.CustomerIdTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerIdTextBox.Location = new System.Drawing.Point(185, 104);
            this.CustomerIdTextBox.Name = "CustomerIdTextBox";
            this.CustomerIdTextBox.Size = new System.Drawing.Size(598, 38);
            this.CustomerIdTextBox.TabIndex = 1;
            this.CustomerIdTextBox.TextChanged += new System.EventHandler(this.CustomerIdTextBox_TextChanged);
            // 
            // VideoCodeTextBox
            // 
            this.VideoCodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VideoCodeTextBox.Location = new System.Drawing.Point(185, 192);
            this.VideoCodeTextBox.Name = "VideoCodeTextBox";
            this.VideoCodeTextBox.Size = new System.Drawing.Size(598, 38);
            this.VideoCodeTextBox.TabIndex = 3;
            this.VideoCodeTextBox.TextChanged += new System.EventHandler(this.VideoCodeTextBox_TextChanged);
            // 
            // IssueDateTimePicker
            // 
            this.IssueDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IssueDateTimePicker.Location = new System.Drawing.Point(185, 280);
            this.IssueDateTimePicker.Name = "IssueDateTimePicker";
            this.IssueDateTimePicker.Size = new System.Drawing.Size(662, 38);
            this.IssueDateTimePicker.TabIndex = 8;
            // 
            // DueDateTimePicker
            // 
            this.DueDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DueDateTimePicker.Location = new System.Drawing.Point(185, 324);
            this.DueDateTimePicker.MinDate = new System.DateTime(2018, 3, 21, 0, 0, 0, 0);
            this.DueDateTimePicker.Name = "DueDateTimePicker";
            this.DueDateTimePicker.Size = new System.Drawing.Size(662, 38);
            this.DueDateTimePicker.TabIndex = 9;
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemarksTextBox.Location = new System.Drawing.Point(185, 368);
            this.RemarksTextBox.Multiline = true;
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.Size = new System.Drawing.Size(662, 114);
            this.RemarksTextBox.TabIndex = 11;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitButton.Location = new System.Drawing.Point(317, 526);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(188, 55);
            this.SubmitButton.TabIndex = 13;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CustomerLookUpButton
            // 
            this.CustomerLookUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerLookUpButton.Location = new System.Drawing.Point(789, 103);
            this.CustomerLookUpButton.Name = "CustomerLookUpButton";
            this.CustomerLookUpButton.Size = new System.Drawing.Size(58, 38);
            this.CustomerLookUpButton.TabIndex = 15;
            this.CustomerLookUpButton.Text = "...";
            this.CustomerLookUpButton.UseVisualStyleBackColor = true;
            this.CustomerLookUpButton.Click += new System.EventHandler(this.CustomerLookUpButton_Click);
            // 
            // VideoLookUpButton
            // 
            this.VideoLookUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VideoLookUpButton.Location = new System.Drawing.Point(789, 191);
            this.VideoLookUpButton.Name = "VideoLookUpButton";
            this.VideoLookUpButton.Size = new System.Drawing.Size(58, 38);
            this.VideoLookUpButton.TabIndex = 16;
            this.VideoLookUpButton.Text = "...";
            this.VideoLookUpButton.UseVisualStyleBackColor = true;
            this.VideoLookUpButton.Click += new System.EventHandler(this.VideoLookUpButton_Click);
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerNameTextBox.Location = new System.Drawing.Point(185, 148);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.ReadOnly = true;
            this.CustomerNameTextBox.Size = new System.Drawing.Size(598, 38);
            this.CustomerNameTextBox.TabIndex = 17;
            // 
            // VideoNameTextBox
            // 
            this.VideoNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VideoNameTextBox.Location = new System.Drawing.Point(185, 236);
            this.VideoNameTextBox.Name = "VideoNameTextBox";
            this.VideoNameTextBox.ReadOnly = true;
            this.VideoNameTextBox.Size = new System.Drawing.Size(598, 38);
            this.VideoNameTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "Issue Date";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "Due Date";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = "Remarks";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Video Code";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(833, 61);
            this.label6.TabIndex = 24;
            this.label6.Text = "Video Rental Form";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VideoRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(859, 665);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VideoNameTextBox);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.VideoLookUpButton);
            this.Controls.Add(this.CustomerLookUpButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.RemarksTextBox);
            this.Controls.Add(this.DueDateTimePicker);
            this.Controls.Add(this.IssueDateTimePicker);
            this.Controls.Add(this.VideoCodeTextBox);
            this.Controls.Add(this.CustomerIdTextBox);
            this.Name = "VideoRentalForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker IssueDateTimePicker;
        private System.Windows.Forms.DateTimePicker DueDateTimePicker;
        private System.Windows.Forms.TextBox RemarksTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CustomerLookUpButton;
        private System.Windows.Forms.Button VideoLookUpButton;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.TextBox VideoNameTextBox;
        public System.Windows.Forms.TextBox CustomerIdTextBox;
        public System.Windows.Forms.TextBox VideoCodeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}

