using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HealPotion: Item, InterfaceSupport
    {
        int health;
        public HealPotion(int health, int weight, int price):base(weight, price)
        {
            this.health = health;
        }
        public int GetStatus()
        {
            return this.health;
        }
    }
}
