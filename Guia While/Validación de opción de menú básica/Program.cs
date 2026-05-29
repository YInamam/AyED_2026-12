using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validación_de_opción_de_menú_básica
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            do
            {
                Console.WriteLine("1 - Saludar");
                Console.WriteLine("2 - Despedirse");
                Console.WriteLine("3 - Salir");

                Console.Write("Elija una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Hola!");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Adiós!");
                }

            } while (opcion != 3);

            Console.WriteLine("Programa finalizado");

 
        }

    }
}
   
