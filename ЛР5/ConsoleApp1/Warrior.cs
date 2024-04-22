using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Warrior: Creature, InterfaceFighter, InterfaceTrader, InterfaceThief, InterfaceHealer
    {
        public int life_steal;
        public Warrior(int level, int max_hp, int weight, int gold, ArrayList Items, int life_steal) :base(level, max_hp, weight, gold, Items)
        {
            this.life_steal = life_steal;
        }
        new void Hit(Creature creature, Weapon weapon)
        {
            int hit_dmg = weapon.GetDamage();
            creature.hp_bar -= hit_dmg;
            hp_bar += (int)Math.Ceiling((double)(hit_dmg * life_steal / 100));
            if (hp_bar > max_hp)
                hp_bar = max_hp;
        }
        public void Take(Item item, Creature creature)
        {
            if (gold > item.GetPrice())
            {
                creature.gold += item.GetPrice();
                gold -= item.GetPrice();
            }
        }
        public void Give(Item item, Creature creature)
        {
            creature.gold -= item.GetPrice();
            gold += item.GetPrice();
        }
        public void Take(Creature creature)
        {
            Random r = new Random();
            if (creature.gold > 0)
            {
                int gold_r = r.Next(1, creature.gold);
                creature.gold -= gold_r;
                this.gold += gold_r;
            }
        }
        public void Heal(Creature creature, HealPotion potion)
        {
            Random r = new Random();
            creature.hp_bar += potion.GetStatus();
        }

    }
}
