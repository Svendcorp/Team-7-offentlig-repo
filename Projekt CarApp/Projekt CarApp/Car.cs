using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Projekt_CarApp
{
    public class Car
    {
        private string _model;
        private string _brand;
        private char _gear;
        private int _year;
        private double _odometer;
        private string _fuelType;
        private bool _isEngineOn;
        private double _kmPerLiter;
        
       public string Model
        {
            get { return _model; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _model = value;
                else
                    Console.WriteLine("❌ Model cannot be empty!");
            }
        }

        //Constuctor
        public Car(string model)
        {
            Model = model;
        }

        //method
        public void CarData()
        {
            Console.WriteLine(Model);
        }

    }
}
