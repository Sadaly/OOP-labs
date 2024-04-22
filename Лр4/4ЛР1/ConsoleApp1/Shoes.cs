using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shoes:Product
    {
        public string skin;
        public Shoes(int id, string name, int price, string skin) : base(id, name, price)
        {
            this.skin = skin;
        }
        public override string ShowInfo()
        {
            return ($"\nИдентификатор: {id}\nНазвание: {name}\nЦена: {price}\nМатериал изделия: {skin}");
        }
    }
}
