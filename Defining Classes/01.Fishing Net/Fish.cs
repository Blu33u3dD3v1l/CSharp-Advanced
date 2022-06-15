using System;
using System.Collections.Generic;
using System.Text;

namespace FishingNet
{
    public class Fish
    {
        public string FishType { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }

        public Fish(string fishType, double length, double weigth)
        {
           this.FishType = fishType;
            this.Length = length;
            this.Weight = weigth;
        }

        public override string ToString()
        {
            var a = $"There is a {FishType}, {Length} cm. long, and {Weight} gr. in weight.";
            return a;
        }
    }
}
