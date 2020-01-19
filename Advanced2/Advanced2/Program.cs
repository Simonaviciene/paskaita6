using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced2
{
    class Program
    {
        public static int Fibonacio(int n)
        {
            int x = 0;
            int a = 1;
           
            for (int i = 0; i < n; i++)
            {
                int temp = x;
                x = a;
                a = temp + a;
            }
            return x;
        }

        static void Main()
        {
            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine(Fibonacio(i));
              
            }
            Console.ReadLine();
        }  
    }
}
