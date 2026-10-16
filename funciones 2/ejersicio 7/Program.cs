using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicio_7
{
    class Program
    {
         static void FactoresPrimos(int numero)

        {
                int divisor = 2;
                int cantidad = 0;

                while (numero > 1)
                {
                    while (numero % divisor == 0)
                {

                        Console.Write(divisor + " ");
                        numero = numero / divisor;
                        cantidad++;
                    }
                    
                    divisor++;
                }

                Console.WriteLine();
                Console.WriteLine("Cantidad total de factores primos: " + cantidad);

            }
            static void Main(string[] args)
        {

                Console.Write("Ingrese un numero entero positivo: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.Write("Factores primos: ");

                FactoresPrimos(numero);

            }
        }
    }
    