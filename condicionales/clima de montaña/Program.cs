using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clima_de_montaña
{
    class Program
    {
        public static object ToInt32 { get; private set; }

        static void Main(string[] args)
        {
            Console.Write("ingrese temperatura actual ");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp < 0)
            {
                Console.WriteLine("Peligro de congelamiento");
            }
            else if (temp > 0 && temp < 15)
            {
                Console.WriteLine("Mucho frío");
            }
            else
            {
                Console.WriteLine("Clima agradable");
            }
            
        }
    }
}
