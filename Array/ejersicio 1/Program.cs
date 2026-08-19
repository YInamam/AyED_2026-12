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
            int[] temperatura = new int[7];
            //// se establese la declarasion de array
            int suma = 0;
            ////

            for (int i = 0; i < 7; i++)
            {
                Console.Write("ingrese la temperatura de la semana: ");
                temperatura[i] = int.Parse(Console.ReadLine());

                suma += temperatura[i];
            }


            int mayor = temperatura[0];
            int menor = temperatura[0];


            for (int e = 1; e < 7; e++)
            {
                if (temperatura[e] > mayor)
                    mayor = temperatura[e];

                if (temperatura[e] < menor)
                    menor = temperatura[e];
            }

            double promedio = (double)suma / 7;

            Console.WriteLine("Mayor temperatura: " + mayor);
            Console.WriteLine("Menor temperatura: " + menor);
            Console.WriteLine("Promedio semanal: " + promedio);

        }
    }
}
