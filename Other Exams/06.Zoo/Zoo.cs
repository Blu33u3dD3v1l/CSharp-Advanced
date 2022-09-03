using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        public List<Animal> Animals { get; set; }

        public string Name { get; set; }
        public int Capacity { get; set; }


        public Zoo(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Animals = new List<Animal>(capacity);
        }


        public string AddAnimal(Animal animal)
        {

            if (string.IsNullOrEmpty(animal.Species))
            {
                return "Invalid animal species.";
            }
            if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }
            if (this.Animals.Count >= this.Capacity)
            {
                return "The zoo is full.";
            }
            else
            {
                Animals.Add(animal);
                return $"Successfully added {animal.Species} to the zoo.";
            }

        }
        public int RemoveAnimals(string species)
        {
            var c = 0;
            var a = Animals.FirstOrDefault(x => x.Species == species);
            if (a == null)
            {
                return 0;

            }
            else
            {
                while (Animals.Any(x => x.Species == species))
                {

                    var b = Animals.FirstOrDefault(x => x.Species == species);
                    Animals.Remove(b);
                    c++;
                }               
                return c;
            }


        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            var list = new List<Animal>();
            foreach (var item in this.Animals.Where(x => x.Diet == diet))
            {
                list.Add(item);
            }
            return list;

        }

        public Animal GetAnimalByWeight(double weight)
        {
            return this.Animals.FirstOrDefault(x => x.Weight == weight);
          

        }
        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            var c = 0;
            foreach (var item in this.Animals.Where(x => x.Length >= minimumLength && x.Length <= maximumLength))
            {
                c++;
            }
            return $"There are {c} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
