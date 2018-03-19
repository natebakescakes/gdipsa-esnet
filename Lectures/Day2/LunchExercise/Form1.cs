using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectures.Day2.LunchExercise
{
    public partial class Form1 : Form
    {
        DafestyEntities context;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            context = new DafestyEntities();

            dataGridView1.DataSource = context.Movies.ToList();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (QueryText.Text != "")
            {
                MovieTitleLabel.Text = context.Movies.Where(x => x.VideoCode.ToString() == QueryText.Text).First().MovieTitle;
            }
            else
            {
                MessageBox.Show("Query Text is blank.");
            }
        }
    }
}
