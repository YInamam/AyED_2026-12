using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumador_hasta_el_Cero
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int numero = 0;

            do
            {
                Console.Write("Ingrese numero entero para sumarlo: ");
                numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
            } while (numero > 0 || numero < 0);

            Console.WriteLine("total acumulado es " + suma);
        }
    }
}
