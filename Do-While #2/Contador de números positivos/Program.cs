using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_números_positivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            string entrada;

            while (true)
            {
                Console.Write("Ingrese un número (X o x para salir): ");
                entrada = Console.ReadLine();

                if (entrada == "X" || entrada == "x")
                {
                    break;
                }

                int numero = int.Parse(entrada);

                if (numero > 0)
                {
                    positivos++;
                }
                else if (numero < 0)
                {
                    negativos++;
                }
                else
                {
                    ceros++;
                }
            }

            Console.WriteLine("Positivos: " + positivos);
            Console.WriteLine("Negativos: " + negativos);
            Console.WriteLine("Ceros: " + ceros);
        }
    }
}