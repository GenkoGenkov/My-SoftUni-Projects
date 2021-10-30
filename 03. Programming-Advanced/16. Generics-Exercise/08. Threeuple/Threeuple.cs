using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Threeuple<itemOne, itemTwo, itemThree>
    {
        public Threeuple(itemOne first, itemTwo second, itemThree third)
        {
            FirstItem = first;
            SecondItem = second;
            ThirdItem = third;
        }

        public itemOne FirstItem { get; set; }
        public itemTwo SecondItem { get; set; }
        public itemThree ThirdItem { get; set; }

        public string GetItems()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}
