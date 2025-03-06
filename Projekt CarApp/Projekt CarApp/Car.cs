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
        private string _model; //done
        private string _brand; //Peter
        private char _gear; //Anders
        private int _year; //Peter
        private double _odometer; //Magnus
        private string _fuelType; //Magnus
        private bool _isEngineOn; //Anders
        private double _kmPerLiter; //Fælles 
        
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
