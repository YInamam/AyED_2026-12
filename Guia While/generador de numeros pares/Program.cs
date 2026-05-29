using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generador_de_numeros_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int limite;
            int numero = 1;


            Console.Write("Ingrese un número entero y positivo para ser el limite: ");
            limite = int.Parse(Console.ReadLine());
            Console.WriteLine("numeros pares entre 1 y "+limite);

            while (numero <= limite)
            {
                if (numero % 2 == 0)
                {
                   
                    Console.WriteLine(numero);
                }

                numero++;
            }
        }

    }
}

