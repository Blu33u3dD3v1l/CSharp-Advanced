using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Guild
{
    public class Guild
    {
        public List<Player> Roster { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Roster = new List<Player>(capacity);
        }
        public void AddPlayer(Player player)
        {
            if (this.Roster.Count < this.Capacity)
            {
                Roster.Add(player);

            }
        }
        public bool RemovePlayer(string name)
        {
            if (this.Roster.Any(x => x.Name == name))
            {
                var a = Roster.FirstOrDefault(x => x.Name == name);
                Roster.Remove(a);
                return true;
            }
            else
            {
                return false;
            }


        }
        public void PromotePlayer(string name)
        {
            if (this.Roster.Any(x => x.Name == name))
            {
                var a = this.Roster.First(x => x.Name == name);

                if (a.Rank != "Member")
                {
                    a.Rank = "Member";
                }

            }
        }
        public void DemotePlayer(string name)
        {
            if (this.Roster.Any(x => x.Name == name))
            {
                var a = this.Roster.First(x => x.Name == name);

                if (a.Rank != "Trial")
                {
                    a.Rank = "Trial";
                }

            }
        }
        public Player[] KickPlayersByClass(string @class)
        {
            var kicked = new List<Player>();
            foreach (var item in Roster.Where(x => x.Class == @class))
            {
                kicked.Add(item);

            }
            Roster.RemoveAll(x => x.Class == @class);
            return kicked.ToArray();

        }
        public int Count
        {
            get { return this.Roster.Count; }
        }
        public string Report()
        {

            var a = new StringBuilder();
            a.AppendLine($"Players in the guild: {Name}");
            foreach (var item in Roster)
            {
                a.AppendLine(item.ToString());
            }
            return a.ToString().TrimEnd();
        }

    }
}
