using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkiRental
{
    public class SkiRental
    {
        List<Ski> data = new List<Ski>();

        public string name;
        public int capacity;


        public SkiRental(string name, int capacity)
        {

            Name = name;
            Capacity = capacity;

        }

        public int Count
        {
            get { return data.Count; }

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Capacity
        {

            get { return capacity; }
            set { capacity = value; }
        }
        public void Add(Ski Ski)
        {
            if (data.Count < capacity)
            {
                data.Add(Ski);
            } 
       }    
        public bool Remove(string manufacturer, string model)
        {
            if(data.Count > 0)
            {
                var some = data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
                if (some != null)
                {
                    data.Remove(some);
                    return true;
                }
               
            }
            return false;
          
         
        }
        public Ski GetNewestSki()
        {
            if(data.Count > 0)
            {
                var some = data.Max(x => x.year);
                var thisThing = data.First(x => x.year == some);
                return thisThing;
            }
            else
            {
                return null;
            }
        }
        public Ski GetSki(string manufacturer, string model)
        {
            if(data.Count > 0)
            {
                var thisThing = data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
                if(thisThing != null)
                {
                    return thisThing;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
        public string GetStatistics()
        {

            var sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            foreach(var item in data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
           
        }

    }
}