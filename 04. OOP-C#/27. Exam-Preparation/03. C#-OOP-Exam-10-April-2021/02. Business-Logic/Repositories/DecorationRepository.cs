using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private readonly List<IDecoration> decoratiions;

        public DecorationRepository()
        {
            decoratiions = new List<IDecoration>();
        }

        public IReadOnlyCollection<IDecoration> Models => decoratiions.AsReadOnly();

        public void Add(IDecoration model) => decoratiions.Add(model);

        public IDecoration FindByType(string type) => decoratiions.FirstOrDefault(x => x.GetType().Name == type);

        public bool Remove(IDecoration model) => decoratiions.Remove(model);
    }
}
