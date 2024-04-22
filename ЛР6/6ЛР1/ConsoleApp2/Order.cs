using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Order
    {
        public int product_price;
        public int delivery_price;
        public string product_name;
        public int product_weight;
        public Order(int product_price, int delivery_price, string product_name, int product_weight)
        {
            this.product_price = product_price;
            this.delivery_price = delivery_price;
            this.product_name = product_name;
            this.product_weight = product_weight;
        }
        public static implicit operator double(Order x)
        {
            return x.product_price + x.delivery_price;
        }

        public static bool operator >(Order x, Order y)
        {
            return x.product_weight > y.product_weight;
        }
        public static bool operator <(Order x, Order y)
        {
            return x.product_weight < y.product_weight;
        }
        public static Order operator +(Order x, Order y)
        {
            if (x.delivery_price > y.delivery_price)
                return new Order(x.product_price + y.product_price, x.delivery_price, x.product_name + " " + y.product_name, x.product_weight + y.product_weight);
            return new Order(x.product_price + y.product_price, y.delivery_price, x.product_name + " " + y.product_name, x.product_weight + y.product_weight);
        }
        public string ShowInfo()
        {
            return "\nЦена товар: " + product_price + "\nЦена доставки: " + delivery_price + "\nНаименование товара: " + product_name + "\nВес товара: " + product_weight;
        }
    }
}
