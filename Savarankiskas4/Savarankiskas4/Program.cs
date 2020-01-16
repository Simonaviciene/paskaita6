using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas4
{
    class Program
    {
        static void Main(string[] args)
        {
            double ugis = 1.70;
            double mase = 51;

            Console.WriteLine(SuskaiciuojaKMI(ugis, mase));
            Console.ReadLine();
            
        }
        static double SuskaiciuojaKMI(double ugis, double mase)
        {
            double kmi = mase / Math.Pow(ugis, 2);
            return kmi;
            
        }

    }
}
