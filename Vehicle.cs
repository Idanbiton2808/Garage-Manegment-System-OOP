namespace Garage_managment_system_project
{
    using System;
    using System.Collections;
    [Serializable]
    public abstract class Vehicle
    {
        //private bt defualt
        protected uint _vehicle_id;
        protected string _model;
        protected uint _kilometer;
        protected uint _wheels_amount;
        protected uint _year;
        //public static List<Vehicle> v = new List<Vehicle>();
        public uint Vehicle_id { get { return _vehicle_id; } set { _vehicle_id = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public uint Kilometer { get { return _kilometer; } set { _kilometer = value; } }
        public uint Wheels_amount { get { return _wheels_amount; } set { _wheels_amount = value; } }
        public uint Year { get { return _year; } set { _year = value; } }
        public virtual bool CheckID(int Vehicel_id);
        //public abstract bool Check(int Vehicel_id);
        //public abstract bool CheckID(int Vehicel_id);

        public Vehicle(uint vehicle_id, string model, uint kilometer, uint wheels_amount, uint year)
        {
            _vehicle_id = vehicle_id;
            _model = model;
            _kilometer = kilometer;
            _wheels_amount = wheels_amount;
            _year = year;
        }

    }
}
