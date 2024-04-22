using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Creature
    {
        public int level;
        public int max_hp;
        public int weight;
        public int gold;
        public int hp_bar;
        ArrayList Items;
        public Creature(int level, int max_hp, int weight, int gold, ArrayList Items)
        {
            this.level = level;
            this.max_hp = max_hp;
            this.hp_bar = max_hp;
            this.weight = weight;
            this.gold = gold;
            this.Items = Items;
        }
        public void Hit(Creature creature, Weapon weapon)
        {
            int hit_dmg = weapon.GetDamage();
            creature.hp_bar -= hit_dmg;
            hp_bar += (int)Math.Ceiling((double)(hit_dmg / 100));
        }
    }
}
