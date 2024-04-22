using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Electronics:Product
    {
        public string manufacturer;
        public string model;
        public Electronics(int id, string name, int price, string manufacturer, string model) : base(id, name, price)
        {
            this.manufacturer = manufacturer;
            this.model = model;
        }
        public override string ShowInfo()
        {
            return "\n" + base.ShowInfo() + ($"\nПроизводитель: {manufacturer}\nМодель: {model}");
        }
    }
}
