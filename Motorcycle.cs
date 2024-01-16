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

    public class Motorcycle : Vehicle
    {

        //private bt defualt
        uint _engine;
        string _motorcycle_type;
        public static List<Motorcycle> motorcycles = new List<Motorcycle>();

        public uint Engine { get; set; }
        public string Motorcycle_type { get; set; }

        public override bool CheckID(int Vehicle_id)
        {
            if(this.Vehicle_id > 100000000 || this.Vehicle_id < 10000)
            {
                return false;
            }
            return true;
        }

        public Motorcycle(uint engine, string motorcycle_type, uint _vehicle_id, string model, uint kilometer, uint wheels_amount, uint year) : base(_vehicle_id, model, kilometer, wheels_amount, year)
        {
            Engine = engine;
            Motorcycle_type= motorcycle_type;
            
        }
   

        //public void Serialize(string fileName)
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(Motorcycle));
        //    using (TextWriter writer = new StreamWriter(@fileName)) 
        //    {
        //        serializer.Serialize(writer, this);
        //    }
        //}

        //internal void SerializeBinary(string fileName)
        //{
        //    using (FileStream stream = new FileStream(@fileName, FileMode.Create))
        //    {
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        formatter.Serialize(stream, this);
        //    }
        //}
        //internal static Motorcycle DeserializeBinary(string fileName)
        //{
        //    using (FileStream stream = new FileStream(@fileName, FileMode.Open))
        //    {
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        return (Motorcycle)formatter.Deserialize(stream);
        //    }
        //}


    }
}
