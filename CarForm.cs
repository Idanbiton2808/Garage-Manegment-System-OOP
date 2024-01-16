using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections.Specialized;

namespace Garage_managment_system_project
{
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }

        private void Motorcycle_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    //!!!!
                    formatter.Serialize(stream, Car.cars);
                    stream.Close();
                }
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Car.cars.Count == 0)
            {
                MessageBox.Show("please add a vehicle");
                return;
            }
            if (Convert.ToInt64(Kilometer_txt.Text) > 1000000 || Convert.ToInt64(Kilometer_txt.Text) < 0) { MessageBox.Show("Please enter a valid kilometr"); }
            else if (Convert.ToInt64(Vehicle_id_txt.Text) > 1000000 || Convert.ToInt64(Vehicle_id_txt.Text) < 10000) { MessageBox.Show("Please enter a valid id number"); }
            else if (Convert.ToInt64(Year_txt.Text) > 2022 || Convert.ToInt64(Year_txt.Text) < 1970) { MessageBox.Show("Please enter a valid year"); }

            else
            {
                //if(dataGridViewCar.SelectedColumns[0])
                int index = dataGridViewCar.SelectedRows[0].Index;
                DataGridViewRow newdata = dataGridViewCar.Rows[index];
                newdata.Cells[0].Value = Vehicle_id_txt.Text;
                newdata.Cells[1].Value = Model_txt.Text;
                newdata.Cells[2].Value = Kilometer_txt.Text;
                newdata.Cells[3].Value = Year_txt.Text;
                newdata.Cells[4].Value = Cargo_txt.Text;
                newdata.Cells[5].Value = Numdoors_txt.Text;
                Car.cars[index].Vehicle_id = (Convert.ToUInt32(Vehicle_id_txt.Text));
                Car.cars[index].Model = Model_txt.Text;
                Car.cars[index].Kilometer = (Convert.ToUInt32(Kilometer_txt.Text));
                Car.cars[index].Year = (Convert.ToUInt16(Year_txt.Text));
                Car.cars[index].Capacity = (Convert.ToUInt16(Cargo_txt.Text));
                Car.cars[index].NumOfDoors = (Convert.ToUInt16(Numdoors_txt.Text));

            }
        }
    


        private void Add_Click(object sender, EventArgs e)
        {
            if (Vehicle_id_txt.Text == "" || Model_txt.Text == "" || Kilometer_txt.Text == "" || Year_txt.Text == "" || Cargo_txt.Text == "" || Numdoors_txt.Text == "")
            {
                MessageBox.Show("Enter details please...");
                Vehicle_id_txt.Focus();
            }
            else
            {
                if (Convert.ToInt64(Kilometer_txt.Text) > 1000000 || Convert.ToInt64(Kilometer_txt.Text) < 0) { MessageBox.Show("Please enter a valid kilometr"); }
                else if (Convert.ToInt64(Vehicle_id_txt.Text) > 1000000 || Convert.ToInt64(Vehicle_id_txt.Text) < 10000) { MessageBox.Show("Please enter a valid id number"); }
                else if (Convert.ToInt64(Year_txt.Text) > 2022 || Convert.ToInt64(Year_txt.Text) < 1970) { MessageBox.Show("Please enter a valid year"); }

                else
                {

                    dataGridViewCar.Rows.Add(Vehicle_id_txt.Text, Model_txt.Text, Kilometer_txt.Text, Year_txt.Text, Cargo_txt.Text, Numdoors_txt.Text);
                    Car c = new Car((Convert.ToUInt16(Cargo_txt.Text)), Convert.ToUInt16(Numdoors_txt.Text), (Convert.ToUInt16(Vehicle_id_txt.Text)), Model_txt.Text, (Convert.ToUInt16(Kilometer_txt.Text)), 4, (Convert.ToUInt16(Year_txt.Text)));
                    Car.cars.Add(c);
                    Vehicle_id_txt.Text = "";
                    Numdoors_txt.Text = "3";
                    Model_txt.Text = "Toyota";
                    Kilometer_txt.Text = "";
                    Year_txt.Text = "";
                    Cargo_txt.Text = "";
                }
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
           
        }
        private void iDelete()
        {
            foreach (DataGridViewRow item in this.dataGridViewCar.SelectedRows)
            {
                Car.cars.RemoveAt(item.Index);
                dataGridViewCar.Rows.RemoveAt(item.Index);

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //iDelete();
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            iDelete();
        }

private void Import_Click_1(object sender, EventArgs e)
{
    OpenFileDialog openFileDialog1 = new OpenFileDialog();
    openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
    openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
    openFileDialog1.FilterIndex = 1;
    openFileDialog1.RestoreDirectory = true;
    if (openFileDialog1.ShowDialog() == DialogResult.OK)
    {
        Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
        var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

        List<Car> cr = (List<Car>)binaryFormatter.Deserialize(stream);
        int i;
        for (i = 0; i < cr.Count; i++)

        {
            Car.cars.Add(cr[i]);
            dataGridViewCar.Rows.Add(cr[i].Vehicle_id.ToString(), cr[i].Model.ToString(), cr[i].Kilometer.ToString(), cr[i].Year.ToString(), cr[i].Capacity.ToString(), cr[i].NumOfDoors.ToString());
        }

    }
}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            this.Hide();
            F.Show();
        }
    }
}
