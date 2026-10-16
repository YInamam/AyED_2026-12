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
            Console.Write("Ingrese un numero entero positivo: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (Calculo_NumPerf(num))
            {
                Console.WriteLine("El numero es perfecto");
            }
            else
            {
                Console.WriteLine("El numero no es perfecto");
            }
        }

        static bool Calculo_NumPerf(int num)
        {
            int suma = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    suma += i;
                }
            }

            return suma == num;
        }
    }

    }
    


