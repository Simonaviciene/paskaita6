using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2
{
    class Program
    {
        static void Main(string[] args)
        {

            int kiekKartotiVarda = 5;
            //string vardas = "Vilija";

            IsvedaManoVarda("Vilija", kiekKartotiVarda);
            Console.ReadLine();
        }

        private static void IsvedaManoVarda(string vardas, int kartojamasVardas)
        {
            for (int i = 0; i < kartojamasVardas; i++)
            {
                Console.WriteLine(vardas);
            }


        }
    }
}

