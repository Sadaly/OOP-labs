using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public class ComputerComponents
    {
        public string manufacturer;
        public string name;
        public string model;
        public int price;
        private bool was_opened;
        public bool WasOpened
        {
            get { return was_opened; }
            set { was_opened = value; }
        }
        public ComputerComponents(string manufacturer, string name, string model, int price, bool WO)
        {
            this.manufacturer = manufacturer;
            this.name = name;
            this.model = model;
            this.price = price;
            this.was_opened = WO;
        }
        public ComputerComponents()
        {
            manufacturer = "EmptySpace";
            name = "EmptySpace";
            model = "EmptySpace";
            price = -1;
            was_opened = false;
        }
        public string ShowInfo()
        {
            return "\nПроизводитель: " + this.manufacturer + "\nНазвание: " + this.name + "\nМодель: " + this.model + "\nЦена: " + this.price + "\nБ/У: " + this.was_opened;
        }
    }
}
