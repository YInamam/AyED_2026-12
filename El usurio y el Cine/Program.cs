using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_usurio_y_el_Cine
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string pelicula;

            Console.WriteLine("¿Hola usuario?");
            Console.Write("¿Como te llamas?: ");
            nombre = Console.ReadLine();
            Console.Write("¿Cual es tu pelicula favorita?: ");
            pelicula = Console.ReadLine();

            Console.WriteLine("hola " + nombre + " Tu pelicula preferida " + pelicula + " es una porqueria " );
        }
    }
}
