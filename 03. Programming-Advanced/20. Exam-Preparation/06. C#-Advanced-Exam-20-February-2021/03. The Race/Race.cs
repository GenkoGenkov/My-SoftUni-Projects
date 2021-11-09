using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Racer>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => data.Count;

        public void Add(Racer racer)
        {
            if (Capacity > Count)
            {
                data.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            Racer currentRacer = data.FirstOrDefault(x => x.Name == name);

            if (currentRacer == null)
            {
                return false;
            }
            else
            {
                data.Remove(currentRacer);
                return true;
            }
        }

        public Racer GetOldestRacer()
        {
            return data.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public Racer GetRacer(string name)
        {
            return data.FirstOrDefault(x => x.Name == name);
        }

        public Racer GetFastestRacer()
        {
            return data.OrderByDescending(x => x.Car.Speed).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Racers participating at {Name}:");

            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
