using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chiqui_Tapia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ponga la cantidad de minutos que se quedo el vehiculo ");
            int minut = Convert.ToInt16(Console.ReadLine());
            int convert_hora = minut / 60;
            int convert_minut = minut % 60;
            int cost_total1 = convert_hora * 6000;
            int cost_total2 = convert_minut * 150;
            int c_total = cost_total1 + cost_total2;
            int porsentaje = 21;
            int iva = c_total * porsentaje / 100;
            int total = iva + c_total;
            Console.WriteLine("El mondo final es " + total);
        }   
        }
    }

