using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp2
{
    internal class VideoCard : ComputerComponents
    {
        int mHz;
        int memory;
        int voltage;
        public VideoCard(string manufacturer, string name, string model, int price, bool WO, int mHz, int memory, int voltage) : base(manufacturer, name, model, price, WO)
        {
            this.mHz = mHz;
            this.memory = memory;
            this.voltage = voltage;
        }
        public override string ShowInfo()
        {
            return ("Производитель: " + this.manufacturer + "\nНазвание: " + this.name + "\nМодель: " + this.model + "\nЦена: " + this.price + "\nБ/У: " + this.WasOpened) + ("\nМГц: " + mHz) + ("\nВидеопамять (ГБ): " + memory) + ("\nЭнергопотребление (Вт):" + voltage);
        }
    }
}
