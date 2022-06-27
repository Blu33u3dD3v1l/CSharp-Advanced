using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Renovators
{
    public class Catalog
    {
       public List<Renovator> Renovators { get; set; }
       public string Name { get; set; }
       public int NeededRenovators { get; set; }
       public string Project { get; set; }

        public Catalog(string name, int neededRenovators, string project)
        {
            this.Renovators = new List<Renovator>(neededRenovators);
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
        }
        public int Count
        {
            get { return this.Renovators.Count; }
        }
        public string AddRenovator(Renovator renovator)
        {
            if(string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return $"Invalid renovator's information.";
            }
            else if(this.Renovators.Count >= this.NeededRenovators)
            {
                return $"Renovators are no more needed.";
            }
            else if(renovator.Rate > 350)
            {
                return $"Invalid renovator's rate.";
            }
            else
            {
                this.Renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            }
        }
        public bool RemoveRenovator(string name)
        {
            if(this.Renovators.Any(x => x.Name == name))
            {
                var a = this.Renovators.FirstOrDefault(x => x.Name == name);
                this.Renovators.Remove(a);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            var list = new List<Renovator>();
            if(this.Renovators.Any(x => x.Type == type))
            {
                foreach (var item in this.Renovators.Where(x => x.Type == type))
                {
                    list.Add(item);
                }
            }
            this.Renovators.RemoveAll(x => x.Type == type);
            if (list.Count > 0)
            {
                return list.Count;
            }
            else
            {
                return 0;
            }
           
        }
        public Renovator HireRenovator(string name)
        {
            if(this.Renovators.Any(x => x.Name == name))
            {
                var a = this.Renovators.FirstOrDefault(x => x.Name == name);
                a.Hired = true;
                return a;
            }
            else
            {
                return null;
            }
        }
        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> list = new List<Renovator>();
            foreach (var item in this.Renovators.Where(x => x.Days >= days))
            {
                list.Add(item);
            }
            return list;
            
        }
        public string Report()
        {
            var b = new StringBuilder();
            b.AppendLine($"Renovators available for Project {Project}:");
            foreach (var item in this.Renovators.Where(x => x.Hired == false))
            {
                b.AppendLine(item.ToString());
            }
            return b.ToString().Trim();
        }

    }
}
