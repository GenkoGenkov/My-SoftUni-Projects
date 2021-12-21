using Gym.Models.Equipment.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Repositories.Contracts
{
    public class EquipmentRepository : IRepository<IEquipment>
    {
        private readonly List<IEquipment> equipments;

        public EquipmentRepository()
        {
            equipments = new List<IEquipment>();
        }

        public IReadOnlyCollection<IEquipment> Models => equipments.AsReadOnly();

        public void Add(IEquipment model) => equipments.Add(model);


        public IEquipment FindByType(string type) => equipments.FirstOrDefault(x => x.GetType().Name == type);

        public bool Remove(IEquipment model) => equipments.Remove(model);
    }
}
