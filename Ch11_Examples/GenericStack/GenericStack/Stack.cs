using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    public class Stack<T>
    {
        private T[] items;
        private int stackPointer = 0;

        public Stack(int size)
        {
            items = new T[size];
        }

        public T Pop()
        {
            return items[--stackPointer];
        }

        public void Push(T anItem)
        {
            items[stackPointer] = anItem;
            stackPointer++;
        }
    }
}