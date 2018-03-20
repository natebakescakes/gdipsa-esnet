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
    public partial class Form1 : Form
    {
        DafestyEntities context;

        public Form1()
        {
            InitializeComponent();
            context = new DafestyEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in context.Customers
                                        select new { x.CustomerID, x.CustomerName, x.MemberRating })
                                        .ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var car1 = new Car("Toyota", "Corolla");
            //var car2 = new Car("Honda", "City");
            //var car3 = new Car("Toyota", "Camry");

            //var list = new List<Car>() { car1, car2, car3 };

            var list = new List<Car>() {
                new Car("Toyota", "Corolla"),
                new Car("Honda", "City"),
                new Car("Toyota", "Camry")
            };

            label1.Text = list[1].Model;
        }
    }

    class Car
    {
        public Car(string make, string model)
        {
            this.Model = model;
            this.Make = make;
        }

        public string Make { get; set; }
        public string Model { get; set; }
    }
}
