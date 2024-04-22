using System;
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
            Application.Run(new Lab3Task1());
        }
        //static void Main(string[] args)
        //{

        //    Shoes pair = new Shoes(13, "сапоги", 3000, "крокодил");
        //    pair.ShowInfo();
        //    Console.WriteLine();
        //    Clothes jacket = new Clothes(25, "куртка кож.", 15000, "козья кожа");
        //    jacket.ShowInfo();
        //    Console.WriteLine();
        //    Electronics phone = new Electronics(130, "Huawai", 25000, "Китай", "12X");
        //    phone.ShowInfo();
        //}
    }
}
