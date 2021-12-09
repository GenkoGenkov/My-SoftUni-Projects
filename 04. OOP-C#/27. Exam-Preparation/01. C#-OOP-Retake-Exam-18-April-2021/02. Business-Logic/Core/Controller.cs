using Easter.Core.Contracts;
using Easter.Models.Bunnies;
using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes;
using Easter.Models.Dyes.Contracts;
using Easter.Models.Eggs;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops;
using Easter.Models.Workshops.Contracts;
using Easter.Repositories;
using Easter.Repositories.Contracts;
using Easter.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Easter.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IBunny> bunnyRepository;
        private readonly IRepository<IEgg> eggRepository;
        private readonly IWorkshop workshop;

        public Controller()
        {
            bunnyRepository = new BunnyRepository();
            eggRepository = new EggRepository();
            workshop = new Workshop();
        }

        public SerializationInfo ExceptionsMessages { get; private set; }

        public string AddBunny(string bunnyType, string bunnyName)
        {
            IBunny bunny;

            if (bunnyType == "HappyBunny")
            {
                bunny = new HappyBunny(bunnyName);
            }
            else if (bunnyType == "SleepyBunny")
            {
                bunny = new SleepyBunny(bunnyName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidBunnyType);
            }

            string result = string.Format(OutputMessages.BunnyAdded, bunnyType, bunnyName);

            bunnyRepository.Add(bunny);

            return result;
        }

        public string AddDyeToBunny(string bunnyName, int power)
        {
            IBunny bunny = this.bunnyRepository.FindByName(bunnyName);

            if (bunny == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InexistentBunny);
            }

            IDye dye = new Dye(power);

            bunny.AddDye(dye);

            string result = string.Format(OutputMessages.DyeAdded, power, bunnyName);

            return result;
        }

        public string AddEgg(string eggName, int energyRequired)
        {
            IEgg egg = new Egg(eggName, energyRequired);

            eggRepository.Add(egg);

            string result = string.Format(OutputMessages.EggAdded, eggName);

            return result;
        }

        public string ColorEgg(string eggName)
        {
            IEgg egg = eggRepository.FindByName(eggName);

            List<IBunny> bunnies = bunnyRepository.Models.Where(x => x.Energy >= 50).OrderByDescending(x => x.Energy).ToList();

            if (bunnies.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.BunniesNotReady);
            }

            foreach (var bunny in bunnies)
            {
                workshop.Color(egg, bunny);

                if (bunny.Energy == 0)
                {
                    bunnyRepository.Remove(bunny);
                }
            }

            if (egg.IsDone())
            {
                return string.Format(OutputMessages.EggIsDone, eggName);
            }
            else
            {
                return string.Format(OutputMessages.EggIsNotDone, eggName);
            }
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            int countColoredEggs = this.eggRepository.Models.Count(x => x.IsDone());

            sb.AppendLine($"{countColoredEggs} eggs are done!");
            sb.AppendLine("Bunnies info:");

            foreach (var bunny in this.bunnyRepository.Models)
            {
                sb.AppendLine($"Name: {bunny.Name}");
                sb.AppendLine($"Energy: {bunny.Energy}");
                sb.AppendLine($"Dyes: {bunny.Dyes.Count} not finished");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
