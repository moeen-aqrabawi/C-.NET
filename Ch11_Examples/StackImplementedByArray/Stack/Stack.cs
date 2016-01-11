/* This application implements a
 * stack structure as an array of objects
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        object[] items;
        int stackPointer = 0;

        public Stack(int size)
        {
            items = new object[size];
        }

        public object Pop()
        {
            return items[--stackPointer];
        }

        public void Push(object anItem)
        {
            items[stackPointer] = anItem;
            stackPointer++;
        }
    }
}
