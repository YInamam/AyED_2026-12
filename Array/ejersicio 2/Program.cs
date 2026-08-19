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
            int[] alumnos = new int[10];
            //// se establese la declarasion de array
            int suma = 0;
            ////

            for (int i = 0; i < 10; i++)
            {
                Console.Write("ingrese nota del alumno " + (i + 1) + " (1 al 10):");
                alumnos[i] = Convert.ToInt32(Console.ReadLine());

                suma += alumnos[i];
            }


            int mayor = alumnos[0];
            int menor = alumnos[0];


            for (int e = 1; e < 10; e++)
            {
                if (alumnos[e] > mayor)
                {
                    mayor = alumnos[e];
                }

                if (alumnos[e] < menor)
                {
                    menor = alumnos[e];
                }
            }

            int promedio = (int)suma / 10;

            Console.WriteLine("Mayor nota: " + mayor);
            Console.WriteLine("Menor nota: " + menor);
            Console.WriteLine("Promedio del curso: " + promedio);
        }
    }
}
