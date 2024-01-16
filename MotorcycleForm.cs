using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace Garage_managment_system_project
{
    public partial class MotorcycleForm : Form
    {

        public MotorcycleForm()
        {
            InitializeComponent();
        }

        
        private void Motorcycle_btn_Click(object sender, EventArgs e)
        {
            if (Engin_txt.Text == "" || Model_txt.Text == "" || Kilometer_txt.Text == "" || wheelsamount_txt.Text == "" || vehicle_id_txt.Text == "" || Year_txt.Text == "" || Type_txt.Text == "")
            {
                MessageBox.Show("Enter details please...");
                vehicle_id_txt.Focus();
            }
            else
            {
                if (Convert.ToInt64(Kilometer_txt.Text) > 1000000 || Convert.ToInt64(Kilometer_txt.Text) < 0) { MessageBox.Show("Please enter a valid kilometr"); }
                //else if (Convert.ToInt64(vehicle_id_txt.Text) > 1000000 || Convert.ToInt64(vehicle_id_txt.Text) < 10000) { MessageBox.Show("Please enter a valid id number"); }
                else if (Convert.ToInt64(Year_txt.Text) > 2022 || Convert.ToInt64(Year_txt.Text) < 1970) { MessageBox.Show("Please enter a valid year"); }

                else
                {

                    dataGridView1.Rows.Add(Engin_txt.Text, Model_txt.Text, Kilometer_txt.Text, wheelsamount_txt.Text, vehicle_id_txt.Text, Year_txt.Text, Type_txt.Text);
                    Motorcycle m = new Motorcycle(( Convert.ToUInt16(Engin_txt.Text)), Type_txt.Text,(Convert.ToUInt16(vehicle_id_txt.Text)), Model_txt.Text, (Convert.ToUInt16(Kilometer_txt.Text)), (Convert.ToUInt16(wheelsamount_txt.Text)), (Convert.ToUInt16(Year_txt.Text)));
                    //if (m.CheckID((Convert.ToUInt16(vehicle_id_txt.Text))) == false)
                    //{
                    //    MessageBox.Show("Please enter a valid kilometr");
                    //    vehicle_id_txt.Focus();
                    //    iDelete();
                    //}
                    Motorcycle.motorcycles.Add(m);
                    Engin_txt.Text = "125";
                    Model_txt.Text = "Toyota";
                    Kilometer_txt.Text = ""; 
                    wheelsamount_txt.Text= "2";
                    vehicle_id_txt.Text = "";
                    Year_txt.Text = "";
                    Type_txt.Text = "dirt";
                    
                }
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
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
                    formatter.Serialize(stream, Motorcycle.motorcycles);
                    stream.Close();
                }
            }
           
        }

        private void import_btn_Click(object sender, EventArgs e)
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
                //!!!!
                List<Motorcycle> mc = (List<Motorcycle>)binaryFormatter.Deserialize(stream);
                int i;
                for (i = 0; i < mc.Count; i++)

                {
                    Motorcycle.motorcycles.Add(mc[i]);
                    dataGridView1.Rows.Add(mc[i].Engine.ToString(), mc[i].Model.ToString(), mc[i].Kilometer.ToString(), mc[i].Wheels_amount.ToString(), mc[i].Vehicle_id.ToString(), mc[i].Year.ToString(), mc[i].Motorcycle_type.ToString());
                }
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Delete_Click(object sender, EventArgs e)
        {
            iDelete();
        }
        private void iDelete()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                Motorcycle.motorcycles.RemoveAt(item.Index);
                dataGridView1.Rows.RemoveAt(item.Index);
                
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if(Motorcycle.motorcycles.Count==0)
            { 
                MessageBox.Show("please add a vehicle");
                return;
            }
            if (Convert.ToInt64(Kilometer_txt.Text) > 1000000 || Convert.ToInt64(Kilometer_txt.Text) < 0) { MessageBox.Show("Please enter a valid kilometr"); }
            else if (Convert.ToInt64(vehicle_id_txt.Text) > 1000000 || Convert.ToInt64(vehicle_id_txt.Text) < 10000) { MessageBox.Show("Please enter a valid id number"); }
            else if (Convert.ToInt64(Year_txt.Text) > 2022 || Convert.ToInt64(Year_txt.Text) < 1970) { MessageBox.Show("Please enter a valid year"); }

            else
            { 
            int index = dataGridView1.SelectedRows[0].Index;
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = Engin_txt.Text; 
            newdata.Cells[1].Value = Model_txt.Text;
            newdata.Cells[2].Value = Kilometer_txt.Text;
            newdata.Cells[3].Value = wheelsamount_txt.Text;
            newdata.Cells[4].Value = vehicle_id_txt.Text;
            newdata.Cells[5].Value = Year_txt.Text;
            newdata.Cells[6].Value = Type_txt.Text;
            Motorcycle.motorcycles[index].Engine = (Convert.ToUInt16(Engin_txt.Text));
            Motorcycle.motorcycles[index].Motorcycle_type = Type_txt.Text;
            Motorcycle.motorcycles[index].Vehicle_id = (Convert.ToUInt16(vehicle_id_txt.Text));
            Motorcycle.motorcycles[index].Model = Model_txt.Text;
            Motorcycle.motorcycles[index].Kilometer = (Convert.ToUInt16(Kilometer_txt.Text));
            Motorcycle.motorcycles[index].Wheels_amount = (Convert.ToUInt16(wheelsamount_txt.Text));
            Motorcycle.motorcycles[index].Year= (Convert.ToUInt16 ( Year_txt.Text));

            }
        }

        private void MotorcycleForm_Load(object sender, EventArgs e)
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
