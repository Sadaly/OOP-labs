using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        protected int id;
        protected string name;
        protected int price;
        public Product(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public virtual string ShowInfo()
        {
            return ($"Идентификатор: {id}\nНазвание: {name}\nЦена: {price}");
        }
    }
}
