using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class MyTuple<itemOne, itemTwo>
    {
        public MyTuple(itemOne leftItem, itemTwo rightItem)
        {
            LeftItem = leftItem;
            RightItem = rightItem;
        }

        public itemOne LeftItem { get; set; }
        public itemTwo RightItem { get; set; }

        public string GetItems()
        {
            return $"{LeftItem} -> {RightItem}";
        }
    }
}
