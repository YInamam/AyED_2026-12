using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_de_costo_de_droides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese la contidad de droides");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            int costo_total = cantidad + 2000;
            if (cantidad >= 3)
            {
                int porsentaje = 20;
                int descuento = costo_total + porsentaje / 100;
                int precio_final = costo_total - descuento;
                Console.WriteLine("el costo total es" + costo_total + " el costo total del ahorro es " + descuento + "y el total a pagar es " + precio_final);
                }
                  else 
                {
                Console.WriteLine("El costo total es "+costo_total);
                 }
            }
        }
    }

