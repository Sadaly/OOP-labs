using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 20; i++)
                list.Add(i);
            int pos_changed = 10;
            int pos_start = 5;
            int p = list[pos_start];
            list.Remove(pos_start);
            list.Insert(pos_changed, p);
            for (int i = 0; i < 20; i++)
                Console.Write(list[i] + "\t");
        }

    }
}
