using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CustomQueue
    {
        private const int InitialCapacity = 4;
        private const int FirstElementIndex = 0;
        private int[] items;
        private int count;
        private int[] input;

        public CustomQueue()
        {
            count = 0;
            items = new int[InitialCapacity];
        }

        public CustomQueue(int[] input)
        {
            this.input = input;
        }

        public int Count => count;

        public void Enqueue(int item)
        {
            if (items.Length == count)
            {
                IncreaseSize();
            }

            items[count] = item;
            count++;
        }

        private void IncreaseSize()
        {
            int[] tempArray = new int[items.Length * 2];

            items.CopyTo(tempArray, 0);
            items = tempArray;
        }

        public int Dequeue()
        {
            IsEmpty();

            count--;

            var firstElement = items[FirstElementIndex];

            SwitchElements();

            return firstElement;
        }

        private void SwitchElements()
        {
            items[FirstElementIndex] = default;

            for (int i = 1; i < items.Length; i++)
            {
                items[i - 1] = items[i];
            }

            items[items.Length - 1] = default;
        }

        private void IsEmpty()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("The queue is empty!");
            }
        }

        public int Peek()
        {
            if (count > 0)
            {
                var firstElement = items[FirstElementIndex];

                return firstElement;
            }
            else
            {
                throw new InvalidOperationException("The queue is empty!");
            }
        }

        public int Clear()
        {
            if (count > 0)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    count--;

                }

                throw new InvalidOperationException("The queue is empty!");
            }
            else
            {
                throw new InvalidOperationException("The queue is empty!");
            }
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < count; i++)
            {
                action(items[i]);
            }
        }
    }
}
