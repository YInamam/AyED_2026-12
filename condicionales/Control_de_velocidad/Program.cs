using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_velocidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese la velosidad de un vehiculo: ");
            int Veloc = Convert.ToInt32(Console.ReadLine());
            if (Veloc >= 120) 
            {
                Console.WriteLine("Multa en camino: Exceso de velocidad");
            }
            else
            {
                Console.WriteLine("Conducción segura");
            }
        }
    }
}
