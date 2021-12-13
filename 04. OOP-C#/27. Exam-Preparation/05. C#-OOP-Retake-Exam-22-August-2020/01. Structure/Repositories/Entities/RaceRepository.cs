using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class RaceRepository : IRepository<IRace>
    {
        private readonly IDictionary<string, IRace> raceByname;

        public RaceRepository()
        {
            raceByname = new Dictionary<string, IRace>();
        }

        public void Add(IRace model)
        {
            if (raceByname.ContainsKey(model.Name))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceExists, model.Name));
            }

            raceByname.Add(model.Name, model);
        }

        public IReadOnlyCollection<IRace> GetAll()
        {
            return raceByname.Values.ToList();
        }

        public IRace GetByName(string name)
        {
            IRace race = null;

            if (raceByname.ContainsKey(name))
            {
                race = raceByname[name];
            }

            return race;
        }

        public bool Remove(IRace model)
        {
            return raceByname.Remove(model.Name);
        }
    }
}
