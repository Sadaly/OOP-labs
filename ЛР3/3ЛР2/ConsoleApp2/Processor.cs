using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp2
{
    internal class Processor : ComputerComponents
    {
        int generation;
        int cores;
        int mHz;
        public Processor(string manufacturer, string name, string model, int price, bool WO, int generation, int cores, int mHz) : base(manufacturer, name, model, price, WO)
        {
            this.generation = generation;
            this.cores = cores;
            this.mHz = mHz;
        }
        public override string ShowInfo()
        {
            return base.ShowInfo() + ("\nПоколение: " + generation) + ("\nКоличество ядер: " + cores) + ("\nМГц: " + mHz);
        }
    }
}
