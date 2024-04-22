using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Item
    {
        protected int weight;
        protected int price;
        public Item(int weight, int price)
        {
            this.weight = weight;
            this.price = price;
        }
        public int GetPrice()
        {
            return price;
        }

    }
}
