using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Stocks
    {
        public string company_name;
        public int price_dollars;
        private static double ruble_ex_rate;
        public double RubleExchangeRate
        {
            get{ return ruble_ex_rate; }
            set { ruble_ex_rate = value; }
        }
        public Stocks(string company_name, int price_dollars)
        {
            this.company_name = company_name;
            this.price_dollars = price_dollars;
        }
        public static bool operator >(Stocks a, Stocks b)
        {
            return a.price_dollars > b.price_dollars;
        }
        public static bool operator <(Stocks a, Stocks b)
        {
            return a.price_dollars < b.price_dollars;
        }
        public static implicit operator double(Stocks a)
        {
            return ruble_ex_rate * a.price_dollars;
        }
    }
}
