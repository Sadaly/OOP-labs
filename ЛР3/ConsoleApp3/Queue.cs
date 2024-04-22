using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Queue
    {
        public int[] array;
        public void SetLenght(int length)
        {
            Array.Resize(ref array, length);
        }
        public void Add(int element)
        {
            Array.Resize(ref array, array.Length+1);
            array[array.Length-1] = element;
        }
        public int Take(bool end)
        {
            if (end)
            {
                Array.Reverse(array);
                int t = array[array.Length-1];
                Array.Resize(ref array, array.Length - 1);
                Array.Reverse(array);
                return t;
            }
            else
            {
                int t = array[array.Length - 1];
                Array.Resize(ref array, array.Length - 1);
                return t;
            }
        }
        public int Pop()
        {
            return array[0];
        }
        public void Clear()
        {
            Array.Clear(array, 0, array.Length);
        }
        public bool Empty()
        {
            if (array.Length != 0)
                return false;
            else
                return true;
        }
    }
}
