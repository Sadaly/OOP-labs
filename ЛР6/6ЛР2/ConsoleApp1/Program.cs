using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleApp1
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConsoleApp1.Form1());
            Stocks stock = new Stocks("ss", 123);
            stock.RubleExchangeRate = 59.13;
            Console.WriteLine(stock.RubleExchangeRate);
            Console.WriteLine(stock);
        }
    }
}