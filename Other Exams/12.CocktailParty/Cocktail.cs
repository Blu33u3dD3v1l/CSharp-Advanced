using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CocktailParty
{
    public class Cocktail
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }

        private List<Ingredient> ingredients;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.MaxAlcoholLevel = maxAlcoholLevel;
            this.ingredients = new List<Ingredient>();
        }
        public List<Ingredient> Ingredients => this.ingredients;
     
        public void Add(Ingredient ingredient)
        {
            var a = this.Ingredients.FirstOrDefault(x => x.Name == ingredient.Name);
            if(a == null)
            {
                if(this.Ingredients.Count < this.Capacity)
                {
                    if(ingredient.Alcohol + this.CurrentAlcoholLevel <= this.MaxAlcoholLevel)
                    {
                        this.Ingredients.Add(ingredient);
                    }
                   
                }
            }
        }
        public bool Remove(string name)
        {
                                
                var a = this.Ingredients.FirstOrDefault(x => x.Name == name);
                return this.Ingredients.Remove(a);
           
        }
        public string FindIngredient(string name)
        {
            var a = this.Ingredients.FirstOrDefault(x => x.Name == name);
            if(a != null)
            {
                return a.ToString();
            }
            return null;
        }
        public string GetMostAlcoholicIngredient()
        {
            var a = this.Ingredients.Max(x => x.Alcohol);
            var b = this.Ingredients.First(x => x.Alcohol == a);           
            return b.ToString();
        }
        public int CurrentAlcoholLevel => this.Ingredients.Sum(x => x.Alcohol);

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {this.Name} - Current Alcohol Level: {this.CurrentAlcoholLevel}");
            foreach (var item in Ingredients)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
