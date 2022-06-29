using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Guild
{
    public class Guild
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Players = new List<Player>(capacity);         
        }
        public void AddPlayer(Player player)
        {
            if(this.Players.Count < this.Capacity)
            {
               Players.Add(player);
            }
          
        }
        public int Count
        {
            get { return this.Players.Count; }
        }
        public bool RemovePlayer(string name)
        {
            if(this.Players.Any(x => x.Name == name))
            {
                var a = Players.FirstOrDefault(x => x.Name == name);
                Players.Remove(a);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PromotePlayer(string name)
        {
            if (this.Players.Any(x => x.Name == name))
            {
                var a = this.Players.First(x => x.Name == name);
                if (a.Rank != "Member")
                {
                    a.Rank = "Member";

                }
            }
            
        }
        public void DemotePlayer(string name)
        {
            if (this.Players.Any(x => x.Name == name))
            {
                var a = this.Players.First(x => x.Name == name);
                if (a.Rank != "Trial")
                {
                    a.Rank = "Trial";

                }
            }

        }
        public Player[] KickPlayersByClass(string @class)
        {            
                var list = new List<Player>();
                foreach (var p in Players.Where(x => x.Class == @class))
                {
                  list.Add(p);
                }
                Players.RemoveAll(x => x.Class == @class);
                return list.ToArray();
        }     
        public string Report()
        {
            var bild = new StringBuilder();
            bild.AppendLine($"Players in the guild: {Name}");
            foreach (var p in Players)
            {
                bild.AppendLine(p.ToString());
            }
            return bild.ToString().TrimEnd();
        }
    }
}
