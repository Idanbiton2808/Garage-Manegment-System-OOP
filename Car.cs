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
    internal class Car : Vehicle
    {
        int _capacity;
        int _num_of_doors;
        public static List<Car> cars = new List<Car>();

        public Car(int capacity, int num_of_doors, uint _vehicle_id, string model, uint kilometer, uint wheels_amount, uint year) : base(_vehicle_id, model, kilometer, wheels_amount, year)
        {
            this.Capacity = capacity;
            this.NumOfDoors = num_of_doors;
            _wheels_amount = 4;
            
        }

        public int Capacity { get { return _capacity; } set { _capacity = value; } }
        public int NumOfDoors { get { return _num_of_doors; } set { _num_of_doors = value; } }

        internal void SerializeBinary(string fileName)
        {
            using (FileStream stream = new FileStream(@fileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
            }
        }
        internal static Car DeserializeBinary(string fileName)
        {
            using (FileStream stream = new FileStream(@fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (Car)formatter.Deserialize(stream);
            }
        }

    }
}
