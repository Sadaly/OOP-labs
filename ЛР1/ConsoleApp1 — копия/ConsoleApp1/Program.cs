using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputerComponents Components1 = new ComputerComponents("AMD", "Saphyre", "av15", 200, true);
            ComputerComponents.ShowInfo(Components1);
        }
    }
}
