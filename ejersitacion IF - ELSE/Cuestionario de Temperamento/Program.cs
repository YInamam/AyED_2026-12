using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuestionario_de_Temperamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("encontras un cristal Kyberperdido ");
            Console.WriteLine("¿que haces?");
            Console.WriteLine("Opción 1: El camino del Jedi sigue ");
            Console.WriteLine("Opción 2: Un cazarrecompensas eres ");
            Console.WriteLine("Opción 3: El Lado Oscuro se apodera de ti ");
            Console.WriteLine("ingrese un numero");
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("El camino del Jedi");
            }
            else
            {
                if (opcion == 2)
                {
                    Console.WriteLine("Un caza recompensas eres ");
                }
                else
                {
                    if (opcion == 3)
                    {
                        Console.WriteLine("el lado oscuro se apodera de ti ");
                    }
                    else
                    {
                        Console.WriteLine("Error en la Fuerza: opción inválida");
                    }

                }
            }
        }
    }
}

