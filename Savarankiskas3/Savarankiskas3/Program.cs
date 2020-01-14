using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas3
{
    class Program
    {
        static void Main(string[] args)
        {
            string eilute = IsvestiSimboliuEilute("abc", "#");
            Console.WriteLine(eilute);
            Console.ReadLine();
           
        }
        private static string IsvestiSimboliuEilute(string tekstas, string simbolis)
        {
            string rezultatas = "";
            for (int i = 0; i < tekstas.Length; i++)
            {
                rezultatas += simbolis;

            }
            return rezultatas;
        }




    }
}
