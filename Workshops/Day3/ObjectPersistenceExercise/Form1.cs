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
    public partial class Form1 : Form
    {
        DafestyEntities context;

        public Form1()
        {
            InitializeComponent();
            QuestionSelector.SelectedIndex = 0;
            context = new DafestyEntities();
        }

        private void RetrieveButton_Click(object sender, EventArgs e)
        {
            switch (QuestionSelector.Text)
            {
                case "Question 4a":
                    Question4a();
                    break;
                case "Question 4b":
                    Question4b();
                    break;
                case "Question 4c":
                    Question4c();
                    break;
                case "Question 4d":
                    Question4d();
                    break;
                case "Question 4e":
                    Question4e();
                    break;
                case "Question 4f":
                    Question4f();
                    break;
                default:
                    break;
            }
        }

        private void Question4a()
        {
            dataGridView1.DataSource = context.Movies
                .Where(x => x.VideoCode == 5)
                .ToList();
        }

        private void Question4b()
        {
            context.Movies.Where(x => x.VideoCode == 5).First().RentalCost = (float?)1.8;
            context.SaveChanges();
        }

        private void Question4c()
        {
            Movie m = new Movie()
            {
                VideoCode = 500,
                MovieTitle = "Sully",
                Genre = "Drama",
                ProducerID = "Warner",
                RentalCost = (float?)2.5,
                Rating = "U",
                TotalStock = 4
            };

            context.Movies.Add(m);
            context.SaveChanges();
        }

        private void Question4d()
        {
            context.Movies.Where(x => x.VideoCode == 4).First().ProducerID = "Pixar";
            context.SaveChanges();
        }

        private void Question4e()
        {
            context.Producers.Where(x => x.ProducerID == "Pixar").First()
                .Movies.Where(x => x.VideoCode == 11).First().ProducerID = "Warner";
            context.SaveChanges();
        }

        private void Question4f()
        {
            context.Movies.Remove(context.Movies.Where(x => x.VideoCode == 500).First());
            context.SaveChanges();
        }
    }
}
