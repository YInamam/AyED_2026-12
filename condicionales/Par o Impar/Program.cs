using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_o_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un numero entero ");
            int numer = Convert.ToInt32(Console.ReadLine());
            int num = numer % 2;
            if (num == 0)
            {
                Console.WriteLine("es un numero par");
            }
            else
            {
                Console.WriteLine("es un numero impar");
            }
        }
    }
}
