using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;

namespace Garage_managment_system_project
{
    using System;
    using System.Collections;
    [Serializable]
    internal class Truck : Car
    {
        int weight;
        public static List<Truck> trucks = new List<Truck>();

        public Truck(int weight, int capacity, int num_of_doors, uint _vehicle_id, string model, uint kilometer, uint wheels_amount, uint year) : base(capacity, num_of_doors, _vehicle_id, model, kilometer, wheels_amount, year)
        {
            this.weight = weight;
            num_of_doors = 2;

            //trucks.Add(this);
        }
        public int Weight { get { return weight; } set { weight = value; } }
        //internal void SerializeBinary(string fileName)
        //{
        //    using (FileStream stream = new FileStream(@fileName, FileMode.Create))
        //    {
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        formatter.Serialize(stream, this);
        //    }
        //}
        //internal static Truck DeserializeBinary(string fileName)
        //{
        //    using (FileStream stream = new FileStream(@fileName, FileMode.Open))
        //    {
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        return (Truck)formatter.Deserialize(stream);
        //    }
        //}
    }
}
