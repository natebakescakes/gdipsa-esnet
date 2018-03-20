using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDemoContinued
{
    public partial class Form2 : Form
    {
        DafestyEntities context;

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            context = new DafestyEntities();

            // Get existing Customer
            Customer c = context.Customers.First(x => x.CustomerID == "1001");
            label1.Text = $"{c.CustomerName} {c.MemberRating}";

            // Change customer's member rating
            c.MemberRating = "B";
            label1.Text = $"{c.CustomerName} {c.MemberRating}";

            // Create new customer
            var newCustomer = new Customer();
            newCustomer.CustomerID = "1007";
            newCustomer.CustomerName = "Bond";
            newCustomer.MemberRating = "Z";

            // Add new customer to Customers collection
            context.Customers.Add(newCustomer);

            // Fetch customer
            var deleteCustomer = context.Customers.First(x => x.CustomerID == "1007");

            // Remove customer
            context.Customers.Remove(deleteCustomer);

            // Save Changes to sync DB
            context.SaveChanges();
        }
    }
}
