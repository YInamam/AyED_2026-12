using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesador_de_estadísticas
{
    class Program
    {
        static void Main(string[] args)
        {

            int total = 0;
            int ventaMayor = 0;
            int cantidadVentas = 0;
            char continuar;

            do
            {
                Console.Write("Ingrese monto de la venta: ");
                int venta = int.Parse(Console.ReadLine());

                total += venta;
                cantidadVentas++;

                if (venta > ventaMayor)
                {
                    ventaMayor = venta;
                }

                Console.Write("Desea ingresar otra venta? (S/N): ");
                continuar = char.Parse(Console.ReadLine());

            } while (continuar == 'S');

            Console.WriteLine("total recaudado: " + total);
            Console.WriteLine("Cantidad de ventas: " + cantidadVentas);
            Console.WriteLine("Venta más alta: " + ventaMayor);
        }
    }


}
    