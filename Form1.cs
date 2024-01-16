using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Garage_managment_system_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            
        }

        private void bus_pic_Click(object sender, EventArgs e)
        {
            BusForm BF = new BusForm();
            this.Hide();
            BF.Show();
        }

        private void Motorcycle_pic_Click(object sender, EventArgs e)
        {
            MotorcycleForm MF = new MotorcycleForm();
            this.Hide();
            MF.Show();
        }

        private void car_pic_Click(object sender, EventArgs e)
        {
            CarForm CF = new CarForm();
            this.Hide();
            CF.Show();
        }

        private void Truck_pic_Click(object sender, EventArgs e)
        {
            TruckForm TF = new TruckForm();
            this.Hide();
            TF.Show();
        }
    }
}
