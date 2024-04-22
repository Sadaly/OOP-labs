using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Clothes:Product
    {
        public string textile;
        public Clothes(int id, string name, int price, string textile) : base(id, name, price)
        {
            this.textile = textile;
        }
        public override string ShowInfo()
        {
            return "\n" + base.ShowInfo() + ($"\nМатериал изделия: {textile}");
        }
    }
}
