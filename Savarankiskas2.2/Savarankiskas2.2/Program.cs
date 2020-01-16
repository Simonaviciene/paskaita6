using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = { 10, 5, 6, 8, 4, 2 };

            IsvestiElementuMasyva(skaiciai);
            Console.ReadLine();
        }
        static void IsvestiElementuMasyva(int[] skaiciai)
        {
            int skaiciuSuma = 0;

            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciuSuma += skaiciai[i];
            }
            Console.WriteLine($"Suma: {skaiciuSuma}, viso: {skaiciai.Length} elementai");

        }
    }
}
