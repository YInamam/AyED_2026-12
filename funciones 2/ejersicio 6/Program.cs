using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicio_6
{
    class Program
    {
        static int SegundoMayor(int[] numeros, out bool existe)
        {

            int mayor = numeros[0];
            int segun = 0;
            existe = false;

            for (int i = 1; i < numeros.Length; i++)
            {

                if (numeros[i] > mayor)
                {
                    segun = mayor;
                    mayor = numeros[i];
                    existe = true;
                }
                else if (numeros[i] < mayor)
                {

                    if (!existe || numeros[i] > segun)
                    {
                        segun = numeros[i];
                        existe = true;
                    }

                }
            }
            return segun;
        }
        static void Main(string[] args)
        {

            Console.Write("Ingrese la cantidad de numeros: ");
            int cant = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[cant];
            for (int w = 0; w < cant; w++)

            {
                Console.Write("Ingrese un numero: ");
                numeros[w] = Convert.ToInt32(Console.ReadLine());
            }
            bool existe;
            int segun = SegundoMayor(numeros, out existe);
            if (existe)

            {
                Console.WriteLine("El segundo numero mas grande es: " + segun);
            }
            else
            {
                Console.WriteLine("No existe un segundo valor diferente al mayor.");
            }
        }
    }
}