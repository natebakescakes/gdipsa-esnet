using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectures.Day1.Exercise1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputMovieRating = textBox1.Text;

            string connectionString =
                "data source=(local);" +
                "integrated security=SSPI;" +
                "initial catalog=Dafesty";

            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand();

            command.Connection = connection;
            if (inputMovieRating != "")
            {
                command.CommandText =
                    $"SELECT MovieTitle FROM Movies " +
                    $"WHERE Rating = '{inputMovieRating}' " +
                    $"ORDER BY MovieTitle ASC";
            }
            else
            {
                command.CommandText =
                    "SELECT MovieTitle FROM Movies " +
                    "ORDER BY MovieTitle ASC";
            }

            connection.Open();

            var reader = command.ExecuteReader();

            listBox1.Items.Clear();

            while (reader.Read())
            {
                listBox1.Items.Add(reader["MovieTitle"].ToString());
            }

            connection.Close();
            
        }
    }
}
