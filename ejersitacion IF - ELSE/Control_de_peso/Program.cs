using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_peso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese peso actual ");
            int peso = Convert.ToInt32(Console.ReadLine());

            if (peso <= 5000)
            {
                Console.WriteLine("despegue autorizado. buen viaje");
            }
            else
            {
                float descaraga = peso - 5000;
                Console.WriteLine("Alerta: Exceso de peso. Debes descargar " + descaraga + " kg para despegar");
            }
     
        }
    }
}
