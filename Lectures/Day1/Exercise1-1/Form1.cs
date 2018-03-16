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

namespace Lectures.Day1.Exercise1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inputVideoCode;
            double inputRentalPrice;

            if (Double.TryParse(textBox2.Text, out inputRentalPrice) && Int32.TryParse(textBox1.Text, out inputVideoCode))
            {
                string stringConnection =
                "data source=(local);" +
                "integrated security=SSPI;" +
                "initial catalog=Dafesty";

                var connection = new SqlConnection(stringConnection);
                var command = new SqlCommand();

                command.Connection = connection;
                command.CommandText =
                    $"UPDATE Movies SET RentalPrice = {inputRentalPrice} " +
                    $"WHERE VideoCode = {inputVideoCode}";

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show($"The RentalPrice of VideoCode {inputVideoCode} is now {inputRentalPrice}.");
            }
            else
            {
                MessageBox.Show("VideoCode or Rental Price is not a valid amount!");
            }
        }
    }
}
