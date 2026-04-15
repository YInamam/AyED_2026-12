using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Club_de_la_Pelea
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.Write("ingrese su nombre ");
            nombre = Console.ReadLine();
            Console.Write("ingrese su edad ");
            int edad = Convert.ToInt32(Console.ReadLine());
         
            if ( edad >= 18 )
            {
                Console.WriteLine("Bienvenido al club, " + nombre);

            }
            else
            {
                Console.WriteLine("Lo siento, eres muy polluelo para esto");
            }
        }
    }
}

