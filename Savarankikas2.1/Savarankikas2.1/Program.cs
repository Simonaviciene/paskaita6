using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankikas2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekstas = "Ir vel isauso nauja diena !";
            

            Console.WriteLine(SuskaiciuotiTarpusTekste(tekstas));
            Console.ReadLine();

        }
        static int SuskaiciuotiTarpusTekste(string tekstas)
        {
            int tarpai = 0;

            foreach(var item in tekstas)
            {
                if(item == ' ')
                {
                    tarpai ++;
                }
            }
            return tarpai;
        }

            
    }
}
