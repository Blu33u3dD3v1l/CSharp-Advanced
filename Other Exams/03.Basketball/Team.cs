using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        private string name;
        private int openPositions;
        private char group;
        private ICollection<Player> players;

        public Team(string name, int openPositions, char group)
        {
            this.Name = name;
            this.OpenPositions = openPositions;
            this.Group = group;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int OpenPositions
        {
            get { return openPositions; }
            set { openPositions = value; }
        }
        public char Group
        {
            get { return group; }
            set { group = value; }
        }
        public ICollection<Player> Players => this.players;

        public int Count => this.players.Count;

        public string AddPlayer(Player player)
        {

            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }
            if (this.OpenPositions == 0)
            {
                return "There are no more open positions.";
            }
            if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }
            this.players.Add(player);
            this.OpenPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {this.OpenPositions}.";


        }
        public int RemovePlayerByPosition(string position)
        {
            var c = 0;
            var a = players.FirstOrDefault(x => x.Position == position);
            if(a == null)
            {
                return 0;
               
            }
            else
            {
                while (players.Any(x => x.Position == position))
                {

                    var b = players.FirstOrDefault(x => x.Position == position);
                    players.Remove(b);                 
                    c++;
                }
                this.OpenPositions += c;
                return c;
            }
          
           
        }
        public Player RetirePlayer(string name)
        {
            var a = this.players.FirstOrDefault(x => x.Name == name);
            if(a != null)
            {
                a.Retired = true;               
                return a;
            }
            return null;
        }
        public List<Player> AwardPlayers(int games)
        {
            var list = new List<Player>();
            foreach (var item in players.Where(x => x.Games >= games))
            {
                list.Add(item);
            }
            return list;
           
        }
        public string Report()
        {
            var s = new StringBuilder();
            s.AppendLine($"Active players competing for Team {this.Name} from Group {this.Group}:");
            foreach (var item in players.Where(x => x.Retired == false))
            {
                s.AppendLine(item.ToString());
            }
            return s.ToString().TrimEnd();
        }
        public bool RemovePlayer(string name)
        {
           
            var a = this.players.FirstOrDefault(x => x.Name == name);
            if(a != null)
            {
                this.players.Remove(a);
                this.OpenPositions++;
                return true;
            }
            return false;
            
        }


    }
}
