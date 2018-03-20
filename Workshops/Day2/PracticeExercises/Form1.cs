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
                        .Select(g => new { g.VideoCode, g.MovieTitle, g.RentalPrice})
                        .ToList();

                    // LINQ expression
                    dataGridView1.DataSource = (from x in context.Movies
                                                where x.Rating == "R"
                                                select new { x.VideoCode, x.MovieTitle, x.RentalPrice })
                                                .ToList();

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
                    // Method-based lambda expression
                    dataGridView1.DataSource = context.Movies
                        .GroupBy(x => 1)
                        .Select(g => new { CountMovies = g.Count() })
                        .ToList();

                    // LINQ expression
                    dataGridView1.DataSource = (from x in context.Movies
                                                group x by 1 into g
                                                select new { CountMovies = g.Count() })
                                                .ToList();
                    break;
                case "Question 7":
                    // Method-based lambda expression
                    dataGridView1.DataSource = context.Movies
                        .GroupBy(x => x.MovieType)
                        .Select(g => new { MovieType = g.Key, SumTotalStock = g.Sum(y => y.TotalStock) })
                        .ToList();

                    // LINQ Expression
                    dataGridView1.DataSource = (from x in context.Movies
                                                group x by x.MovieType into g
                                                select new { MovieType = g.Key, SumTotalStock = g.Sum(y => y.TotalStock) })
                                                .ToList();
                    break;
                case "Question 8":
                    // Method-based lambda expression
                    dataGridView1.DataSource = context.Movies
                        .Where(x => x.MovieType == "Comedy")
                        .GroupBy(y => 1)
                        .Select(g => new { AverageRentalPrice = g.Average(z => z.RentalPrice) })
                        .ToList();

                    // LINQ expression
                    dataGridView1.DataSource = (from x in context.Movies
                                                where x.MovieType == "Comedy"
                                                group x by 1 into g
                                                select new { AverageRentalPrice = g.Average(y => y.RentalPrice) })
                                                .ToList();
                    break;
                case "Question 11":
                    // Method-based lambda expression
                    dataGridView1.DataSource = context.Movies
                        .Where(x => x.VideoCode == 5)
                        .Select(g => new { g.VideoCode, g.Rating, g.Producer.ProducerName })
                        .ToList();

                    // LINQ Expression
                    dataGridView1.DataSource = (from x in context.Movies
                                                where x.VideoCode == 5
                                                select new { x.VideoCode, x.Rating, x.Producer.ProducerName })
                                                .ToList();
                    break;
                case "Question 12":
                    // Method-based lambda expression
                    dataGridView1.DataSource = context.Movies
                        .Where(x => x.Producer.ProducerName == "Walt Disney Studio")
                        .Select(g => new { g.Producer.ProducerName, g.MovieTitle, g.MovieType })
                        .ToList();

                    // LINQ Expression
                    dataGridView1.DataSource = (from x in context.Movies
                                                where x.Producer.ProducerName == "Walt Disney Studio"
                                                select new { x.Producer.ProducerName, x.MovieTitle, x.MovieType })
                                                .ToList();
                    break;
                case "Question 13":
                    // Method-based lambda expression
                    dataGridView1.DataSource = context.Movies
                        .Select(x => new { x.MovieTitle, x.Rating, x.MovieType, x.Producer.ProducerName })
                        .ToList();

                    // LINQ Expression
                    dataGridView1.DataSource = (from x in context.Movies
                                                select new { x.MovieTitle, x.Rating, x.MovieType, x.Producer.ProducerName })
                                                .ToList();
                    break;
                default:
                    break;
            }
        }
    }
}
