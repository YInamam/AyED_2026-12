using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicio_2
{
    class Program
    {
        static void Main(string[] args)
        
            {
                Console.Write("ingrese un numero positivo: ");
                int num = Convert.ToInt32(Console.ReadLine());

                ContarHasta(num);
            }

            static void ContarHasta(int num)
        {
                int contador = 1;

                while (contador <= num)
                {
                    Console.WriteLine(contador);
                    contador++;
                }
            }

        }

    }
    