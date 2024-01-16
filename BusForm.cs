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
    public partial class BusForm : Form
    {
        public BusForm()
        {
            InitializeComponent();
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
                    formatter.Serialize(stream, Bus.buses);
                    stream.Close();
                }
            }
        }

        private void Number_floors_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Vehicle_id_txt.Text == "" || Model_txt.Text == "" || Kilometer_txt.Text == "" || Year_txt.Text == "" || Capacity_txt.Text == "" || Number_floors_txt.Text == "" || whellsamount_txt.Text == "")
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
                    dataGridViewBus.Rows.Add(Vehicle_id_txt.Text, Model_txt.Text, Kilometer_txt.Text,whellsamount_txt.Text, Year_txt.Text, Capacity_txt.Text, Number_floors_txt.Text);
                    Bus b = new Bus((Convert.ToUInt16(Capacity_txt.Text)),Convert.ToUInt16(Number_floors_txt.Text),Convert.ToUInt16(Numdoors_txt.Text), (Convert.ToUInt16(Vehicle_id_txt.Text)), Model_txt.Text, (Convert.ToUInt16(Kilometer_txt.Text)), Convert.ToUInt16(whellsamount_txt.Text), (Convert.ToUInt16(Year_txt.Text)));
                    Bus.buses.Add(b);
                    Vehicle_id_txt.Text = "";
                    Numdoors_txt.Text = "2";
                    Number_floors_txt.Text = "1";
                    Model_txt.Text = "Mercedes";
                    whellsamount_txt.Text = "4";
                    Kilometer_txt.Text = "";
                    Year_txt.Text = "";
                    Capacity_txt.Text = "";
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            iDelete();
        }
        private void iDelete()
        {
            foreach (DataGridViewRow item in this.dataGridViewBus.SelectedRows)
            {
                Bus.buses.RemoveAt(item.Index);
                dataGridViewBus.Rows.RemoveAt(item.Index);

            }
        }


        private void update_Click(object sender, EventArgs e)
        {
            if (Bus.buses.Count == 0)
            {
                MessageBox.Show("please add a vehicle");
                return;
            }
            if (Convert.ToInt64(Kilometer_txt.Text) > 1000000 || Convert.ToInt64(Kilometer_txt.Text) < 0) { MessageBox.Show("Please enter a valid kilometr"); }
            else if (Convert.ToInt64(Vehicle_id_txt.Text) > 1000000 || Convert.ToInt64(Vehicle_id_txt.Text) < 10000) { MessageBox.Show("Please enter a valid id number"); }
            else if (Convert.ToInt64(Year_txt.Text) > 2022 || Convert.ToInt64(Year_txt.Text) < 1970) { MessageBox.Show("Please enter a valid year"); }

            else
            {
                
                int index = dataGridViewBus.SelectedRows[0].Index;
                DataGridViewRow newdata = dataGridViewBus.Rows[index];
                newdata.Cells[0].Value = Vehicle_id_txt.Text;
                newdata.Cells[1].Value = Model_txt.Text;
                newdata.Cells[2].Value = Kilometer_txt.Text;
                newdata.Cells[3].Value = Year_txt.Text;
                newdata.Cells[4].Value = Capacity_txt.Text;
                newdata.Cells[5].Value = Numdoors_txt.Text;
                Bus.buses[index].Vehicle_id = (Convert.ToUInt32(Vehicle_id_txt.Text));
                Bus.buses[index].Model = Model_txt.Text;
                Bus.buses[index].Kilometer = (Convert.ToUInt32(Kilometer_txt.Text));
                Bus.buses[index].Wheels_amount = (Convert.ToUInt32(whellsamount_txt.Text));
                Bus.buses[index].Year = (Convert.ToUInt16(Year_txt.Text));
                Bus.buses[index].Capacity = (Convert.ToUInt16(Capacity_txt.Text));
                Bus.buses[index].NumOfFloors = (Convert.ToUInt16(Number_floors_txt.Text));
                Bus.buses[index].NumOfDoors = (Convert.ToUInt16(Numdoors_txt.Text));

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

                List<Bus> bs = (List<Bus>)binaryFormatter.Deserialize(stream);
                int i;
                for (i = 0; i < bs.Count; i++)
                {
                    Bus.buses.Add(bs[i]);
                    dataGridViewBus.Rows.Add(bs[i].Vehicle_id.ToString(), bs[i].Model.ToString(), bs[i].Kilometer.ToString(), bs[i].Wheels_amount.ToString(), bs[i].Year.ToString(), bs[i].Capacity.ToString(), bs[i].NumOfFloors.ToString(), bs[i].NumOfDoors.ToString());
                }
            }
        }

        private void BusForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            this.Hide();
            F.Show();
        }
    }
}
