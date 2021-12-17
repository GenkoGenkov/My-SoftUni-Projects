using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory
{
    public abstract class Bag : IBag
    {
        private const int defaultCapacity = 100;
        private List<Item> items;
        private int load;
        private int capacity;


        public Bag(int capacity)           //vazmojna greshka ???
        {
            this.capacity = capacity;
            items = new List<Item>();
        }

        public int Capacity                   //??? warning!
        {
            get => this.capacity;

            set
            {
                this.capacity = value;
            }
        }

        public int Load
        {
            get
            {
                int sum = 0;

                sum += items.Sum(x => x.Weight); //?

                return sum;
            }
        }

        public IReadOnlyCollection<Item> Items   //???
        {
            get => items.AsReadOnly();
        }

        public void AddItem(Item item)
        {
            if (this.load + item.Weight > this.capacity)
            {

                throw new InvalidOperationException("Bag is full!");
            }

            items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (items.Count == 0)
            {

                throw new InvalidOperationException("Bag is empty");
            }

            if (!items.Any(x => x.GetType().Name == name))
            {
                throw new ArgumentException($"No item with name {name } in bag!");
            }

            Item item = items.FirstOrDefault(x => x.GetType().Name == name);
            // items.Remove(item);
            return item;
        }
    }
}
