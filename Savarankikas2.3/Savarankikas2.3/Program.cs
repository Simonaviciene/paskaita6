using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankikas2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double skaicius = 10;
            int laipsnis = 3;
            

            Console.WriteLine("Skaiciaus {0} pakeltas {1} laipsniu = {3}",skaicius, laipsnis, pakeltasLaipsniu);

            Console.ReadLine();
        }

        static double PakeltasLaipsniu(double skaicius, int laipsnis)
        {
            double pakeltasLaipsniu = Math.Pow(skaicius, laipsnis);
            return pakeltasLaipsniu;
        }
    }
    
}
