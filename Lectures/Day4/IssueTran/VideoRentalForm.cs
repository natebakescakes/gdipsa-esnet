using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectures.Day4.IssueTran
{
    public partial class VideoRentalForm : Form
    {
        DafestyEntities context;
        private CustomerLookUpForm customerLookUpForm;
        private VideoLookUpForm videoLookUpForm;

        public VideoRentalForm()
        {
            InitializeComponent();
            context = new DafestyEntities();

            customerLookUpForm = new CustomerLookUpForm(this);
            videoLookUpForm = new VideoLookUpForm(this);

            // IssueDate can back date to 1 year before today
            IssueDateTimePicker.MinDate = DateTime.Now.Date - new TimeSpan(365, 0, 0, 0);
            IssueDateTimePicker.MaxDate = DateTime.Now.Date;

            // DueDate can range from today to 1 year from today
            DueDateTimePicker.MinDate = DateTime.Now.Date;
            DueDateTimePicker.MaxDate = DateTime.Now.Date + new TimeSpan(365, 0, 0, 0);
        }

        private void CustomerLookUpButton_Click(object sender, EventArgs e)
        {
            customerLookUpForm.ShowDialog();
        }

        private void VideoLookUpButton_Click(object sender, EventArgs e)
        {
            videoLookUpForm.ShowDialog();
        }

        private void CustomerIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (context.Customers.Where(x => x.CustomerID == CustomerIdTextBox.Text).FirstOrDefault() is null)
            {
                CustomerNameTextBox.Text = "";
            }
            else
            { 
                CustomerNameTextBox.Text = context.Customers
                    .Where(x => x.CustomerID == CustomerIdTextBox.Text)
                    .FirstOrDefault()
                    .CustomerName
                    .ToString();
            }
        }

        private void VideoCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            short videoCode;

            if (short.TryParse(VideoCodeTextBox.Text, out videoCode))
            {
                if (context.Movies.Where(x => x.VideoCode == videoCode).FirstOrDefault() is null)
                {
                    VideoNameTextBox.Text = "";
                }
                else
                {
                    VideoNameTextBox.Text = context.Movies
                        .Where(x => x.VideoCode == videoCode)
                        .FirstOrDefault()
                        .MovieTitle
                        .ToString();
                }
            }
            else if (VideoCodeTextBox.Text == "")
            {
                VideoNameTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Video Code input is not valid.");
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (CustomerNameTextBox.Text == "" || VideoNameTextBox.Text == "")
            {
                MessageBox.Show("Invalid Customer or Movie.");
                return;
            }

            // Transaction ID = latest transactionID + 1
            short trxId = (short)(context.IssueTrans.Max(x => x.TransactionID) + 1);

            var trx = new IssueTran()
            {
                TransactionID = trxId,
                CustomerID = CustomerIdTextBox.Text,
                VideoCode = short.Parse(VideoCodeTextBox.Text),
                DateIssue = DateTime.Parse(IssueDateTimePicker.Text),
                DateDue = DateTime.Parse(DueDateTimePicker.Text),
                RentalStatus = "in",
                Remarks = RemarksTextBox.Text
            };

            context.IssueTrans.Add(trx);
            context.SaveChanges();

            ResetFields();
            MessageBox.Show("Transaction successfully added.");
        }

        private void ResetFields()
        {
            CustomerIdTextBox.Text = "";
            VideoCodeTextBox.Text = "";
            IssueDateTimePicker.Value = DateTime.Now.Date;
            DueDateTimePicker.Value = DateTime.Now.Date;
            RemarksTextBox.Text = "";
        }
    }
}
