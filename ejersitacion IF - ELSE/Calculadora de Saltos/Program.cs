using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Saltos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese la distancia al destino ");
            int distancia = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese el combustible actual ");
            int conbustible = Convert.ToInt32(Console.ReadLine());
            int luz = distancia * 12;
            int falta = luz - conbustible;
            if (luz <= conbustible)
            {
                Console.WriteLine("Cálculos precisos. Saltando al hiperespacio");
            }
            else
            {
                Console.WriteLine("Peligro: Combustible insuficiente. Faltan "+ falta +" litros");
            }
        }
    }
}
