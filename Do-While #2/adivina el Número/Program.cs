using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adivina_el_Número
{
    class Program
    {
        static void Main(string[] args)
        {
                int numerSecret = 42;
                int intentos = 0;
                int numero;

                do
                {
                    Console.Write("Adivine el número: ");
                    numero = int.Parse(Console.ReadLine());

                    intentos++;

                    if (numero < numerSecret)
                    {
                        Console.WriteLine("El número es mayor.");
                    }
                    else if (numero > numerSecret)
                    {
                        Console.WriteLine("El número es menor.");
                    }

                } while (numero != numerSecret && intentos < 5);

                if (numero == numerSecret)
                {
                    Console.WriteLine("Ganaste");
                }
                else
                {
                    Console.WriteLine("Perdiste el número era " + numerSecret);
                }

                Console.WriteLine("Intentos utilizados: " + intentos);
            }
        }

    }

