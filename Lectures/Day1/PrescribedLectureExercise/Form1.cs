﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectures.Day1.PrescribedLectureExercise
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        private int currentRowIndex;

        public Form1()
        {
            InitializeComponent();
            currentRowIndex = 0;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string connectionString =
                "data source=(local);" +
                "integrated security=SSPI;" +
                "initial catalog=Dafesty";

            connection = new SqlConnection(connectionString);
            command = new SqlCommand();

            command.CommandText =
                "SELECT VideoCode, MovieTitle, Rating FROM Movies";
            command.Connection = connection;

            dataAdapter = new SqlDataAdapter(command);
            var commandbuilder = new SqlCommandBuilder(dataAdapter);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Movies");

            VideoCodeTextBox.Text = dataSet.Tables["Movies"].Rows[0][0].ToString();
            MovieTitleTextBox.Text = dataSet.Tables["Movies"].Rows[0][1].ToString();
            RatingTextBox.Text = dataSet.Tables["Movies"].Rows[0][2].ToString();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (currentRowIndex != dataSet.Tables["Movies"].Rows.Count - 1)
            {
                currentRowIndex++;
                RefreshFields();
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (currentRowIndex != 0)
            {
                currentRowIndex--;
                RefreshFields();
            }
        }


        private void LastButton_Click(object sender, EventArgs e)
        {
            currentRowIndex = dataSet.Tables["Movies"].Rows.Count - 1;
            RefreshFields();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            currentRowIndex = 0;
            RefreshFields();
        }

        private void RefreshFields()
        {
            VideoCodeTextBox.Text = dataSet.Tables["Movies"].Rows[currentRowIndex][0].ToString();
            MovieTitleTextBox.Text = dataSet.Tables["Movies"].Rows[currentRowIndex][1].ToString();
            RatingTextBox.Text = dataSet.Tables["Movies"].Rows[currentRowIndex][2].ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            dataSet.Tables["Movies"].Rows[currentRowIndex][0] = VideoCodeTextBox.Text;
            dataSet.Tables["Movies"].Rows[currentRowIndex][1] = MovieTitleTextBox.Text;
            dataSet.Tables["Movies"].Rows[currentRowIndex][2] = RatingTextBox.Text;

            dataAdapter.Update(dataSet, "Movies");

            MessageBox.Show("Row successfully updated.");
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            DataRow row = dataSet.Tables["Movies"].NewRow();
            row[0] = VideoCodeTextBox.Text;
            row[1] = MovieTitleTextBox.Text;
            row[2] = RatingTextBox.Text;

            dataSet.Tables["Movies"].Rows.Add(row);

            MessageBox.Show("Row successfully added.");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            dataSet.Tables["Movies"].Rows[currentRowIndex].Delete();
            LoadButton_Click(LoadButton, new EventArgs());
            ClearFields();

            MessageBox.Show("Row successfully deleted.");
        }

        private void ClearFields()
        {
            VideoCodeTextBox.Text = "";
            MovieTitleTextBox.Text = "";
            RatingTextBox.Text = "";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int rowIndex = 0;

            if (VideoCodeRadio.Checked)
            {
                foreach (DataRow row in dataSet.Tables["Movies"].Rows)
                {
                    if (row[0].ToString() == VideoSearchTextBox.Text)
                    {
                        currentRowIndex = rowIndex;
                        RefreshFields();

                        return;
                    }

                    rowIndex++;
                }
            }
            else if (MovieTitleRadio.Checked)
            {
                foreach (DataRow row in dataSet.Tables["Movies"].Rows)
                {
                    if (row[1].ToString() == VideoSearchTextBox.Text)
                    {
                        currentRowIndex = rowIndex;
                        RefreshFields();

                        return;
                    }

                    rowIndex++;
                }
            }

            MessageBox.Show("Movie cannot be found!");
        }
    }
}
