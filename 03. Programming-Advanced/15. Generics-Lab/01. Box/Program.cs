using System;
using System.Collections.Generic;

namespace BoxOfT
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());
        }
    }
    public class Box<T>
    {
        private Stack<T> box;

        public Box()
        {
            box = new Stack<T>();
        }

        public int Count
        {
            get => box.Count;
        }

        public void Add(T item)
        {
            box.Push(item);
        }

        public T Remove()
            => box.Pop();

    }
}