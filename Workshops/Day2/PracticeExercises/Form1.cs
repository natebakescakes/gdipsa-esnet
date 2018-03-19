using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeExercises
{
    public partial class Form1 : Form
    {
        DafestyEntities context;

        public Form1()
        {
            InitializeComponent();
            QuestionCombo.SelectedIndex = 0;

            context = new DafestyEntities();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            switch (QuestionCombo.Text)
            {
                case "Question 1":
                    // Method-based lambda expression
                    dataGridView1.DataSource = context.Movies.ToList();

                    // LINQ expression
                    dataGridView1.DataSource = (from x in context.Movies
                                               select x).ToList();
                    break;
                case "Question 2":
                    // Method-based lambda expression
                    dataGridView1.DataSource = context.Movies
                        .OrderBy(x => x.MovieTitle)
                        .ToList();

                    // LINQ expression
                    dataGridView1.DataSource = (from x in context.Movies
                                                orderby x.MovieTitle
                                                select x).ToList();
                    break;
                case "Question 3":
                    // Method-based lambda expression
                    dataGridView1.DataSource = context.Movies
                        .OrderByDescending(x => x.RentalPrice)
                        .ToList();

                    // LINQ expression
                    dataGridView1.DataSource = (from x in context.Movies
                                                orderby x.RentalPrice descending
                                                select x).ToList();
                    break;
                case "Question 4":
                    // Method-based lambda expression
                    dataGridView1.DataSource = context.Movies
                        .Where(x => x.Rating == "R")
                        .ToList();

                    // LINQ expression
                    dataGridView1.DataSource = (from x in context.Movies
                                                where x.Rating == "R"
                                                select x).ToList();

                    break;
                case "Question 5":
                    // Method-based lambda expression
                    dataGridView1.DataSource = context.Movies
                        .Where(x => x.MovieType == "Sci-Fi" && x.ProducerID == "Warner")
                        .ToList();

                    // LINQ expression
                    dataGridView1.DataSource = (from x in context.Movies
                                                where x.MovieType == "Sci-Fi" && x.ProducerID == "Warner"
                                                select x).ToList();
                    break;
                case "Question 6":
                    MessageBox.Show(context.Movies
                        .Count(x => x.MovieType == "Action").ToString());
                    break;
                case "Question 7":
                    MessageBox.Show(context.Movies
                        .Where(x => x.MovieType == "Action")
                        .Sum(x => x.TotalStock)
                        .ToString());
                    break;
                case "Question 8":
                    MessageBox.Show(context.Movies
                        .Where(x => x.MovieType == "Comedy")
                        .Average(x => x.RentalPrice)
                        .ToString());
                    break;
                default:
                    break;
            }
        }
    }
}
