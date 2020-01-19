using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilietavimoSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            int bilietai10 = 100;
            int bilietai20 = 100;
            int bilietai30 = 100;
            int operacijosPasirinkimas = 0;
            int bilietoTipoPasirinkimas = 0;
            int bilietuKiekis = 0;

            Console.WriteLine("Meniu: Pirkti bilietus [1], Kurti Bilietus [2]");
            operacijosPasirinkimas=Convert.ToInt32(Console.ReadLine());

            if (operacijosPasirinkimas == 1)
            {
                Console.WriteLine("Pasirinkite bilieto tipa: [1] Po 10 Eu, [2] Po 20 Eu, [3] Po 30Eu");
                bilietoTipoPasirinkimas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Iveskite kieki");
                bilietuKiekis = Convert.ToInt32(Console.ReadLine());


                if (bilietoTipoPasirinkimas == 1)
                {
                    ParduotiBilietus(ref bilietai10, bilietuKiekis);
                }
                else if(bilietoTipoPasirinkimas == 2)
                {
                    ParduotiBilietus(ref bilietai20, bilietuKiekis);
                }
                else if(bilietoTipoPasirinkimas == 3)
                {
                    ParduotiBilietus(ref bilietai30, bilietuKiekis);
                }
                else
                {
                    Console.WriteLine("Kitu pasirinkimu nera");
                }

            }
            else if (operacijosPasirinkimas == 2)
            {
                Console.WriteLine("Operacija negalima");
            }
            else
            {
                Console.WriteLine("Tokios operacijos nera");
            }
            Console.ReadLine();
        } 

        private static void ParduotiBilietus(ref int bilietai, int kiekis)
        {
            if (bilietai >= kiekis)
            {
                bilietai -= kiekis;
            }
            else
            {
                Console.WriteLine("Nepakanka bilietu. Siuo metu yra {0}, Norite pirkti {1}", bilietai, kiekis);
            }
            
            
        }
    }
}
