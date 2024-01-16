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
    internal class Bus : Car
    {
      
        int _num_of_floors;
        public static List<Bus> buses = new List<Bus>();

        public Bus(int capacity, int num_of_floors, int num_of_doors, uint _vehicle_id, string model, uint kilometer, uint wheels_amount, uint year) : base(capacity, num_of_doors, _vehicle_id, model, kilometer, wheels_amount, year)
        {
            //this.Capacity = capacity;
            this.NumOfFloors = num_of_floors;
            
            //buses.Add(this);
        }
        

        public int NumOfFloors { get { return _num_of_floors; } set { _num_of_floors = value; } }

        //internal void SerializeBinary(string fileName)
        //{
        //    using (FileStream stream = new FileStream(@fileName, FileMode.Create))
        //    {
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        formatter.Serialize(stream, this);
        //    }
        //}
        //internal static Bus DeserializeBinary(string fileName)
        //{
        //    using (FileStream stream = new FileStream(@fileName, FileMode.Open))
        //    {
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        return (Bus)formatter.Deserialize(stream);
        //    }
        //}

    }
}
