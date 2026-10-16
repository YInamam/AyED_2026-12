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
            int mayor = 0;
            int menor = 0;
            int sumar = 0;
            int pares = 0;
            int impares = 0;

            Console.Write("Determine la cantidad de numeros que quiere ingresar: ");
            int canti = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= canti; i++)
            {
                Console.Write("Ingrese los número: ");
                int numer = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    mayor = numer;
                    menor = numer;
                }
                else
                {

                    mayor = ObtenerMayor(mayor, numer);
                    menor = ObtenerMenor(menor, numer);
                }

                sumar = sumar + numer;
                pares = pares + ContarPar(numer);
                impares = impares + ContarImpar(numer);
            }

            double promedio = CalcularPromedio(sumar, canti);

            Console.WriteLine("Mayor: " + mayor);
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Cantidad de pares: " + pares);
            Console.WriteLine("Cantidad de impares: " + impares);
        }
        static int ObtenerMayor(int mayor, int numero)
        {
            if (numero > mayor)
            {
                mayor = numero;
            }

            return mayor;
        }

        static int ObtenerMenor(int menor, int numero)
        {
            if (numero < menor)
            {
                menor = numero;
            }

            return menor;
        }
        static int ContarPar(int numero)
        {
            if (numero % 2 == 0)
            {
                return 1;
            }

            return 0;
        }
        static int ContarImpar(int numero)
        {
            if (numero % 2 != 0)
            {
                return 1;
            }

            return 0;
        }
        static double CalcularPromedio(int suma, int cantidad)
        {
            return (double)suma / cantidad;
        }
    }
}

        