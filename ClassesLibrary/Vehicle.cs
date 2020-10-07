using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Vehicle
    {
        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Vehicle(string Make, string Model, int Year, float Weight)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Weight = _weight;
        }
        public Vehicle() { }

        public override string ToString()
        {
            return string.Format("The make of the car is {0}, the model is {1}, the year is {2}, and the weight is {3} in pounds.", Make, Model, Year, Weight);
        }
    }
}
