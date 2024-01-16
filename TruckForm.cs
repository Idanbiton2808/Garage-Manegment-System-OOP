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
    public partial class TruckForm : Form
    {
        public TruckForm()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
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
                    formatter.Serialize(stream, Truck.trucks);
                    stream.Close();
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Vehicle_id_txt.Text == "" || Model_txt.Text == "" || Kilometer_txt.Text == "" || whellsamount_txt.Text == ""|| Year_txt.Text == "" || capacity_txt.Text == "" || weight_txt.Text =="" )
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

                    dataGridViewTruck.Rows.Add(Vehicle_id_txt.Text, Model_txt.Text, Kilometer_txt.Text, whellsamount_txt.Text, Year_txt.Text,weight_txt.Text, capacity_txt.Text);
                    Truck t = new Truck((Convert.ToUInt16(weight_txt.Text)), Convert.ToUInt16(capacity_txt.Text), Convert.ToUInt16(2), (Convert.ToUInt16(Vehicle_id_txt.Text)), Model_txt.Text, (Convert.ToUInt16(Kilometer_txt.Text)), Convert.ToUInt16(whellsamount_txt.Text), (Convert.ToUInt16(Year_txt.Text)));
                    Truck.trucks.Add(t);
                    Vehicle_id_txt.Text = "";
                    weight_txt.Text = "12";
                    Model_txt.Text = "Nissan";
                    whellsamount_txt.Text = "4";
                    Kilometer_txt.Text = "";
                    Year_txt.Text = "";
                    capacity_txt.Text = "";

                }
            }
        }

        private void iDelete()
        {
            foreach (DataGridViewRow item in this.dataGridViewTruck.SelectedRows)
            {
                Truck.trucks.RemoveAt(item.Index);
                dataGridViewTruck.Rows.RemoveAt(item.Index);

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            iDelete();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Truck.trucks.Count == 0)
            {
                MessageBox.Show("please add a vehicle");
                return;
            }
            if (Convert.ToInt64(Kilometer_txt.Text) > 1000000 || Convert.ToInt64(Kilometer_txt.Text) < 0) { MessageBox.Show("Please enter a valid kilometr"); }
            else if (Convert.ToInt64(Vehicle_id_txt.Text) > 1000000 || Convert.ToInt64(Vehicle_id_txt.Text) < 10000) { MessageBox.Show("Please enter a valid id number"); }
            else if (Convert.ToInt64(Year_txt.Text) > 2022 || Convert.ToInt64(Year_txt.Text) < 1970) { MessageBox.Show("Please enter a valid year"); }

            else
            {
                int index = dataGridViewTruck.SelectedRows[0].Index;
                DataGridViewRow newdata = dataGridViewTruck.Rows[index];
                newdata.Cells[0].Value = Vehicle_id_txt.Text;
                newdata.Cells[1].Value = Model_txt.Text;
                newdata.Cells[2].Value = Kilometer_txt.Text;
                newdata.Cells[3].Value = whellsamount_txt.Text;
                newdata.Cells[4].Value = Year_txt.Text;
                newdata.Cells[5].Value = weight_txt.Text;
                newdata.Cells[6].Value = capacity_txt.Text;
                Truck.trucks[index].Vehicle_id = (Convert.ToUInt32(Vehicle_id_txt.Text));
                Truck.trucks[index].Model = Model_txt.Text;
                Truck.trucks[index].Kilometer = (Convert.ToUInt32(Kilometer_txt.Text));
                Truck.trucks[index].Wheels_amount = (Convert.ToUInt32(whellsamount_txt.Text));
                Truck.trucks[index].Year = (Convert.ToUInt16(Year_txt.Text));
                Truck.trucks[index].Weight = (Convert.ToUInt16(weight_txt.Text));
                Truck.trucks[index].Capacity = (Convert.ToUInt16(capacity_txt.Text));
            }
        }

        private void Import_Click(object sender, EventArgs e)
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

                List<Truck> tr = (List<Truck>)binaryFormatter.Deserialize(stream);
                int i;
                for (i = 0; i < tr.Count; i++)
                {
                    Truck.trucks.Add(tr[i]);
                    dataGridViewTruck.Rows.Add(tr[i].Vehicle_id.ToString(), tr[i].Model.ToString(), tr[i].Kilometer.ToString(), tr[i].Wheels_amount.ToString(), tr[i].Year.ToString(), tr[i].Weight.ToString(), tr[i].Capacity.ToString());
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
