using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF2Demo
{
    public partial class Form1 : Form
    {
        DafestyEntities context;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context = new DafestyEntities();

            //Customer c = context.Customers.First(x => x.CustomerID == "1001");
            //label1.Text = c.CustomerName;
            //label2.Text = c.Country.CountryName;

            Country country = context.Countries.First(x => x.CountryCode == "SWZ");
            label1.Text = country.CountryName;

            foreach (Customer c in country.Customers)
                label2.Text += c.CustomerName + Environment.NewLine;
        }
    }
}
