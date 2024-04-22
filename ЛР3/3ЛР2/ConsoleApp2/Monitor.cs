using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp2
{
    internal class Monitor: ComputerComponents
    {
        string resolution;
        int hz;
        public Monitor(string manufacturer, string name, string model, int price, bool WO, string resolution, int hz) : base(manufacturer, name, model, price, WO)
        {
            this.resolution = resolution;
            this.hz = hz;
        }
        public override string ShowInfo()
        {
            return base.ShowInfo() + ("\nРасширение: " + resolution) + ("\nГц: " + hz);
        }
    }
}
