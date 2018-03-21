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
    public partial class VideoLookUpForm : Form
    {
        DafestyEntities context;
        VideoRentalForm parent;

        public VideoLookUpForm(VideoRentalForm parent)
        {
            InitializeComponent();
            context = new DafestyEntities();
            LoadDataGrid();
            this.parent = parent;
        }

        public void LoadDataGrid()
        {
            dataGridView1.DataSource = context.Movies
                .OrderBy(x => x.VideoCode)
                .Select(x => new { x.VideoCode, x.MovieTitle, x.MovieType, x.RentalPrice, x.TotalStock, x.NumberRented })
                .ToList();
        }

        private void CancelLookUpButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            parent.VideoCodeTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
            this.Close();
        }
    }
}
