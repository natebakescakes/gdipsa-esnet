using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshops.Day4.IssueTran
{
    public partial class CustomerLookUpForm : Form
    {
        DafestyEntities context;
        VideoRentalForm parent;

        public CustomerLookUpForm(VideoRentalForm parent)
        {
            InitializeComponent();
            context = new DafestyEntities();
            LoadDataGrid();
            this.parent = parent;
        }

        public void LoadDataGrid()
        {
            dataGridView1.DataSource = context.Customers
                .OrderBy(x => x.CustomerID)
                .Select(x => new { x.CustomerID, x.CustomerName, x.MemberCategory })
                .ToList();
        }

        private void CancelLookUpButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            parent.CustomerIdTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
            this.Close();
        }
    }
}
