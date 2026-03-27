using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string juego;
            string consol;

            Console.WriteLine("¿Hola usuario?");
            Console.Write("¿Como te llamas?: ");
            nombre = Console.ReadLine();
            Console.Write("¿Cual es tu juego favorito?: ");
            juego = Console.ReadLine();
            Console.Write("¿En que consola jugas?: ");
            consol = Console.ReadLine();

            Console.WriteLine("hola " + nombre + " Tu juego favorito es " + juego + " y se juega en " + consol);
        }
    }
}

