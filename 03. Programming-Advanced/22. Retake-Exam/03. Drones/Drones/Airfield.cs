using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        

        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;

            Drones = new List<Drone>();
        }

        public List<Drone> Drones { get; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public double LandingStrip { get; set; }

        public int Count => Drones.Count;

        public string AddDrone(Drone drone)
        {
            if (drone.Name == string.Empty || drone.Name == null || drone.Brand == string.Empty || drone.Brand == null)
            {
                return "Invalid drone.";
            }

            if (drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }

            if (Capacity < Count)
            {
                return "Airfield is full.";
            }

            Drones.Add(drone);

            return $"Successfully added {drone.Name} to the airfield.";
        }

        public bool RemoveDrone(string name)
        {
            bool isDroneExist = Drones.Exists(x => x.Name == name);

            if (isDroneExist)
            {
                Drones.Remove(Drones.FirstOrDefault(x => x.Name == name));

                return true;
            }

            return false;
        }

        public int RemoveDroneByBrand(string brand)
        {
            var removed = Drones.Where(x => x.Brand == brand).ToList();

            if (removed == null)
            {
                return 0;
            }

            Drones.RemoveAll(x => x.Brand == brand);

            return removed.Count;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Drones available at {Name}:");


            foreach (var item in Drones.Where(d => d.Available))
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public Drone FlyDrone(string name)
        {
            Drone drone = new Drone(name);

            if (Drones.Exists(x => x.Name == name))
            {
                drone.Available = false;
                return drone;
            }

            return null;
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            Drone drone = new Drone(range.ToString());

            List<Drone> returned = Drones.Where(x => x.Range >= range).ToList();

            return returned;
        }
    }
}
