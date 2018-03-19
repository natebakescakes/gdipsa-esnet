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
    public partial class Form2 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        SqlCommandBuilder commandBuilder;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString =
                "data source=(local);" +
                "integrated security=SSPI;" +
                "initial catalog=Dafesty";

            connection = new SqlConnection(connectionString);
            command = new SqlCommand();

            command.CommandText =
                "SELECT CustomerId, CustomerName, MemberCategory FROM Customers";

            command.Connection = connection;

            dataAdapter = new SqlDataAdapter(command);

            // Build INSERT, DELETE, UPDATE commands from SELECT command in dataAdapter
            // dataAdapter will now house the new commands
            commandBuilder = new SqlCommandBuilder(dataAdapter);

            // Create and fill dataSet
            // dataAdapter will open and close connection automatically
            // when fill is called
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Customers");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Modify dataset
            dataSet.Tables[0].Rows[0][2] = "A";
            label1.Text = dataSet.Tables[0].Rows[0][2].ToString();

            // Update DB based on dataset changes using update method
            // Update method will call commands built by CommandBuilder
            dataAdapter.Update(dataSet, "Customers");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow row = dataSet.Tables["Customers"].NewRow();
            row["CustomerId"] = "1007";
            row["CustomerName"] = "Venkat";
            row["MemberCategory"] = "C";

            dataSet.Tables["Customers"].Rows.Add(row);

            dataAdapter.Update(dataSet, "Customers");
        }
    }
}
