using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lectures.Day2.EFDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new DafestyEntities();

            dataGridView1.DataSource = context.Customers.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var context = new DafestyEntities();

            //var query = context.Customers.Where(x => x.CustomerID == "1001").First();
            //var query = context.Customers.Where(x => x.MemberRating == "A");
            //var query = context.Customers.OrderBy(x => x.CustomerName);
            var query = context.Customers.Where(x => x.MemberRating == "A").OrderBy(x => x.CustomerName);


            //var query = from x in context.Customers
            //            where x.CustomerID == "1001"
            //            select x;

            dataGridView1.DataSource = query.ToList();
        }
    }
}
