using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StreetRacing
{
    public class Race
    {

        public List<Car> Participants { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }
      

        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {         
            this.Name = name;
            this.Type = type;
            this.Laps = laps;            
            this.Capacity = capacity;
            this.MaxHorsePower = maxHorsePower;
            Participants = new List<Car>(capacity);


        }
        public int Count
        {
            get { return Participants.Count; }
        }
        public void Add(Car car)
        {
            if((!Participants.Any(x => x.LicensePlate == car.LicensePlate)) && Participants.Count < Capacity && car.HorsePower <= MaxHorsePower)
            {               
               Participants.Add(car);

            }
        }
        public bool Remove(string licensePlate)
        {
            if (Participants.Any(x => x.LicensePlate == licensePlate))
            {
                var a = Participants.First(x => x.LicensePlate == licensePlate);
                Participants.Remove(a);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Car FindParticipant(string licensePlate)
        {
            if (Participants.Any(x => x.LicensePlate == licensePlate))
            {
                var a = Participants.First(x => x.LicensePlate == licensePlate);

                return a;
            }
            else
            {
                return null;
            }
        }
        public Car GetMostPowerfulCar()
        {
            if (Participants.Any())
            {

                var a = Participants.Max(x => x.HorsePower);                
                var b = Participants.First(x => x.HorsePower == a);
                return b;
            }
            else
            {
                return null;
            }
        }
        public string Report()
        {
            var s = new StringBuilder();
            s.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (var item in Participants)
            {
                s.AppendLine(item.ToString());
            }
            return s.ToString().TrimEnd();
        }
      
    }
}
