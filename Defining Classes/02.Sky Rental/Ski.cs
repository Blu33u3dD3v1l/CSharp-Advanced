using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    public class Ski
    {
        public string manufacturer;
        public string model;
        public int year;

        public Ski(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;

        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }

        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public override string ToString()
        {


            var some = $"{manufacturer} - {model} - {year}";
            return some;
        }
    }
}


