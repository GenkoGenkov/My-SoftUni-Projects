using Gym.Core.Contracts;
using Gym.Models.Athletes;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Core
{
    public class Controller : IController
    {
        private EquipmentRepository equipments;
        private List<IGym> gyms;

        public Controller()
        {
            equipments = new EquipmentRepository();
            gyms = new List<IGym>();
        }

        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            if (athleteType != "Boxer" && athleteType != "Weightlifter")
            {
                throw new InvalidOperationException("Invalid athlete type.");
            }

            IAthlete athlete = null;
            IGym desiredGym = gyms.FirstOrDefault(x => x.Name == gymName);

            if (athleteType == "Boxer")
            {
                athlete = new Boxer(athleteName, motivation, numberOfMedals);

                if (desiredGym.GetType().Name != "BoxingGym")
                {
                    return "The gym is not appropriate.";
                }
            }
            else if (athleteType == "Weightlifter")
            {
                athlete = new Weightlifter(athleteName, motivation, numberOfMedals);

                if (desiredGym.GetType().Name != "WeightliftingGym")
                {
                    return "The gym is not appropriate.";
                }
            }

            desiredGym.AddAthlete(athlete);

            return $"Successfully added {athleteType} to {gymName}.";
        }

        public string AddEquipment(string equipmentType)
        {
            if (equipmentType != "BoxingGloves" && equipmentType != "Kettlebell")
            {
                throw new InvalidOperationException("Invalid equipment type.");
            }

            IEquipment equipment = null;

            if (equipmentType == "BoxingGloves")
            {
                equipment = new BoxingGloves();
            }
            else if (equipmentType == "Kettlebell")
            {
                equipment = new Kettlebell();
            }

            equipments.Add(equipment);

            return $"Successfully added {equipmentType}.";
        }

        public string AddGym(string gymType, string gymName)
        {
            if (gymType != "BoxingGym" && gymType != "WeightliftingGym")
            {
                throw new InvalidOperationException("Invalid gym type.");
            }

            IGym gym = null;

            if (gymType == "BoxingGym")
            {
                gym = new BoxingGym(gymName);
            }
            else if (gymType == "WeightliftingGym")
            {
                gym = new WeightliftingGym(gymName);
            }

            gyms.Add(gym);

            return $"Successfully added {gymType}.";
        }

        public string EquipmentWeight(string gymName)
        {
            IGym gym = gyms.FirstOrDefault(x => x.Name == gymName);

            double sumOfWeight = gym.Equipment.Sum(x => x.Weight);

            return $"The total weight of the equipment in the gym {gymName} is {sumOfWeight:F2} grams.";


        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            IEquipment desiredEquipment = equipments.FindByType(equipmentType);

            if (desiredEquipment == null)
            {
                throw new InvalidOperationException("There isn’t equipment of type {equipmentType}.");
            }

            IGym desiredGym = gyms.FirstOrDefault(x => x.Name == gymName);
            desiredGym.AddEquipment(desiredEquipment);
            equipments.Remove(desiredEquipment);

            return $"Successfully added {equipmentType} to {gymName}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in gyms)
            {
                sb.Append(item.GymInfo() + Environment.NewLine);
            }

            return sb.ToString().TrimEnd();
        }

        public string TrainAthletes(string gymName)
        {
            IGym gym = gyms.FirstOrDefault(x => x.Name == gymName);

            gym.Exercise();

            return $"Exercise athletes: {gym.Athletes.Count}.";
        }
    }
}
