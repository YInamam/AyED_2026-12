using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplos_de_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("escribe un numero ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int result = numero % 5;
            if (result == 0)
            {
                Console.Write("el numero ingresado es multiplo de 5 ");
            }
            else
            {
                Console.WriteLine("el numero ingresado no es multiplo de 5");
            }
        }
    }
}
