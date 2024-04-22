using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Weapon: Item, InterfaceWeapon
    {
        public int damage;
        public Weapon(int weight, int price, int damage):base(weight, price)
        {
            this.damage = damage;
        }
        public int GetDamage()
        {
            Random random = new Random();
            return random.Next(damage*3>>2, damage*5>>2);
        }
    }
}
