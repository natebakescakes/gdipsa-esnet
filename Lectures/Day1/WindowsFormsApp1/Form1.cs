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

namespace Lectures.Day1.WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Setup connectionString default values
            string connectionString = 
                "data source=(local); " +
                "integrated security=SSPI; " +
                "initial catalog=Dafesty; ";

            // Instantiate SqlConnection and SqlCommand objects
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand();

            // Set SQL Query to .CommandText
            command.CommandText = 
                "UPDATE Customers SET MemberCategory = 'D' " +
                "WHERE CustomerId = '1000'";

            // Link command to the connection
            command.Connection = connection;

            // Execute Non-query for DDL statements
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
