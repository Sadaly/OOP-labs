using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface InterfaceTrader
    {
        void Take(Item item, Creature trader);
        void Give(Item item, Creature trader);
    }
}
