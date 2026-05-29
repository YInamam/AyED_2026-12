using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_de_temperatura_ambiente
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Ingrese la temperatura inicial en grados: ");
            int temper = int.Parse(Console.ReadLine());

            while (temper > 24)
            {
                temper = temper - 2;

                Console.WriteLine("Enfriando la temperatura actual: " + temper + "°C");
            }

            Console.WriteLine("se alcanso la temperatura ideal");
        }


    }
}

