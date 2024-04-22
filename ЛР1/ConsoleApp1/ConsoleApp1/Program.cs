using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InternetClient client1 = new InternetClient("1", "Misha", 18, true, "mm1", "1234");
            InternetClient.ShowInfo(client1);
        }
    }
}
