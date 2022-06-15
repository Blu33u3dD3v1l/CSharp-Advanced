using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FishingNet
{
    public class Net
    {
        public List<Fish> Data { get; set; }
        public string Material { get; set; }
        public int Capacity { get; set; }

        public Net(string material, int capacity)
        {

            this.Material = material;
            this.Capacity = capacity;
            this.Data = new List<Fish>(capacity); ;
        }
     

        public string AddFish(Fish fish)
        {
            if(this.Data.Count < this.Capacity)
            {
                if (string.IsNullOrWhiteSpace(fish.FishType))
                {
                    return "Invalid fish.";
                }
                else if (fish.Length <= 0 || fish.Weight <= 0)
                {
                    return $"Invalid fish.";
                }
                else
                {
                    Data.Add(fish);
                    return $"Successfully added {fish.FishType} to the fishing net.";
                }             
            }
            else
            {
                return "Fishing net is full.";
            }
          
        }
        public bool ReleaseFish(double weight)
        {
            if (Data.Any(x => x.Weight == weight))
            {
                var b = Data.FirstOrDefault(x => x.Weight == weight);
                Data.Remove(b);
                return true;
            }
            else
            {
                return false;
            }
       
        }
        public Fish GetFish(string fishType)
        {           
                var a = Data.FirstOrDefault(x => x.FishType == fishType);
                return a;
            
        }
        public Fish GetBiggestFish()
        {          
                var a = Data.Max(x => x.Length);
                var b = Data.FirstOrDefault(x => x.Length == a);
                return b;
        }
        public string Report()
        {
           var sb = new StringBuilder();
            sb.AppendLine($"Into the {Material}:");
            foreach (var item in Data.OrderByDescending(x => x.Length))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
            
        }
        public int Count
        {
            get { return Data.Count; }
        }

    }
}
