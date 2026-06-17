using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_registradora
{
    class Program
    {
        static void Main(string[] args)
        {

            double precio;
            double subtotal = 0;
            double descuento = 0;
            double total;

            Console.WriteLine("Ingrese el precio del producto ");
            Console.WriteLine("Ingrese 0 para finalizar: ");
            precio = Convert.ToInt32(Console.ReadLine());

            while (precio != 0)
            {
                subtotal += precio;

                Console.Write("Ingrese el precio del producto (0 para finalizar): ");
                precio = Convert.ToInt32(Console.ReadLine());
            }


            if (subtotal > 15000)
            {
                descuento = subtotal * 0.10;
            }

            total = subtotal - descuento;

            Console.WriteLine("Subtotal: " + subtotal);
            Console.WriteLine("Descuento: " + descuento);
            Console.WriteLine("Total a pagar: " + total);
        }
    }

}
    

