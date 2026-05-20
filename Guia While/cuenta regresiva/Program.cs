using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuenta_regresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un numero entero positivo ");
            int numer = int.Parse(Console.ReadLine());
            Console.WriteLine("cuenta regresiva ");
            while (numer >= 0)
            {
                Console.WriteLine(numer );
                numer--;
            }
        }
    }
}
