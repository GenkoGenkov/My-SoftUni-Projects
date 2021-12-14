using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Tables
{
    public abstract class Table : ITable
    {
        private List<IBakedFood> bakedFood;
        private List<IDrink> drinks;

        private int capacity;
        private int numberOfPeople;

        public Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            TableNumber = tableNumber;
            Capacity = capacity;
            PricePerPerson = pricePerPerson;

            bakedFood = new List<IBakedFood>();
            drinks = new List<IDrink>();
        }

        public int TableNumber { get; private set; }

        public int Capacity
        {
            get => capacity;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidTableCapacity);
                }

                capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get => numberOfPeople;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidNumberOfPeople);
                }

                numberOfPeople = value;
            }
        }

        public decimal PricePerPerson { get; private set; }

        public bool IsReserved { get; private set; }

        public decimal Price => PricePerPerson * NumberOfPeople;

        public void Clear()
        {
            bakedFood.Clear();
            drinks.Clear();
            IsReserved = false;
            NumberOfPeople = 0;
        }

        public decimal GetBill()
        {
            decimal bill = 0;

            foreach (var item in bakedFood)
            {
                bill += item.Price;
            }

            foreach (var item in drinks)
            {
                bill += item.Price;
            }

            return bill;
        }

        public string GetFreeTableInfo()
        {
            return $"Table: {TableNumber}\r\n" +
                $"Type: {GetType().Name}\r\n" +
                $"Capacity: {Capacity}\r\n" +
                $"Price per Person: {PricePerPerson}";
        }

        public void OrderDrink(IDrink drink)
        {
            drinks.Add(drink);
        }

        public void OrderFood(IBakedFood food)
        {
            bakedFood.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            IsReserved = true;
            NumberOfPeople = numberOfPeople;
        }
    }
}
