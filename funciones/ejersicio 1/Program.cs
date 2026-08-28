using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero positivo: ");
            int num = Convert.ToInt32(Console.ReadLine());

            ContarRegresivo(num);
        }

        static void ContarRegresivo(int numero)
        {
            while (numero >= 1)
            {
                numero--;

                Console.WriteLine(numero);
            }
        }


    }
}
