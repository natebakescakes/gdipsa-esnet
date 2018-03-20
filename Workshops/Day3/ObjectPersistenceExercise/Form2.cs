using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshops.Day3.ObjectPersistenceExercise
{
    public partial class Form2 : Form
    {
        DafestyEntities context;
        private int currentRowIndex;

        public Form2()
        {
            InitializeComponent();
            context = new DafestyEntities();
            currentRowIndex = 0;
            LoadButton_Click(LoadButton, new EventArgs());
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            ShowFields(currentRowIndex);
        }

        private void ShowFields(int currentRowIndex)
        {
            Movie m = context.Movies.OrderBy(x => x.VideoCode).Skip(currentRowIndex).FirstOrDefault();

            VideoCodeTextBox.Text = m.VideoCode.ToString();
            MovieTitleTextBox.Text = m.MovieTitle.ToString();
            GenreTextBox.Text = m.Genre.ToString();
            RentalCostTextBox.Text = m.RentalCost.ToString();

            DisplayRowStatusLabel.Text = $"Displaying Video Code {currentRowIndex + 1} of {context.Movies.Count()}";
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (currentRowIndex > 0)
                currentRowIndex--;
                ShowFields(currentRowIndex);
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            currentRowIndex = 0;
            ShowFields(0);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (currentRowIndex < context.Movies.Count() - 1)
                currentRowIndex++;
                ShowFields(currentRowIndex);
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            currentRowIndex = context.Movies.Count();
            ShowFields(context.Movies.Count() - 1);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            short videoCode;
            float rentalCost;

            // Get movie object using LINQ
            Movie m = context.Movies.OrderBy(x => x.VideoCode).Skip(currentRowIndex).FirstOrDefault();

            // TryParse VideoCode
            if (short.TryParse(VideoCodeTextBox.Text, out videoCode))
                m.VideoCode = videoCode;
            else
            {
                MessageBox.Show("Unable to parse Video Code, please enter a valid number.");
                return;
            }
            
            // TryParse RentalCost
            if (float.TryParse(RentalCostTextBox.Text, out rentalCost))
                m.RentalCost = rentalCost;
            else
            {
                MessageBox.Show("Unable to parse Rental Cost, please enter a valid cost.");
                return;
            }

            m.MovieTitle = MovieTitleTextBox.Text;
            m.Genre = GenreTextBox.Text;

            context.SaveChanges();
            ShowFields(currentRowIndex);
            MessageBox.Show("Successfully updated row.");
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            short videoCode;
            float rentalCost;
            Movie m = new Movie();

            if (short.TryParse(VideoCodeTextBox.Text, out videoCode))
                m.VideoCode = videoCode;
            else
            {
                MessageBox.Show("Unable to parse Video Code, please enter a valid number.");
                return;
            }

            // TryParse RentalCost
            if (float.TryParse(RentalCostTextBox.Text, out rentalCost))
                m.RentalCost = rentalCost;
            else
            {
                MessageBox.Show("Unable to parse Rental Cost, please enter a valid cost.");
                return;
            }

            m.MovieTitle = MovieTitleTextBox.Text;
            m.Genre = GenreTextBox.Text;

            context.Movies.Add(m);
            context.SaveChanges();

            ShowFields(context.Movies.Count() - 1);
            MessageBox.Show("Row successfully Inserted.");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            short videoCode;

            if (short.TryParse(VideoCodeTextBox.Text, out videoCode))
            {
                context.Movies.Remove(context.Movies.Where(x => x.VideoCode == videoCode).First());
                context.SaveChanges();

                currentRowIndex--;
                ShowFields(currentRowIndex);
                MessageBox.Show("Row successfully Deleted");
            }
            else
            {
                MessageBox.Show("Unable to parse Video Code, please enter a valid number.");
                return;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            short videoCode;
            Movie m;

            if (short.TryParse(SearchQueryTextBox.Text, out videoCode))
            {
                m = context.Movies.Where(x => x.VideoCode == videoCode).FirstOrDefault();

                if (m is null)
                    MessageBox.Show("Cannot find Movie");
                else
                {
                    VideoCodeTextBox.Text = videoCode.ToString();
                    MovieTitleTextBox.Text = m.MovieTitle;
                    GenreTextBox.Text = m.Genre;
                    RentalCostTextBox.Text = m.RentalCost.ToString();
                }
            }
            else
            {
                MessageBox.Show("Unable to parse Video Code, please enter a valid number.");
            }
        }
    }
}
