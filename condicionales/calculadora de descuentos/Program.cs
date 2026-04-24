using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_descuentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el monto de la compra ");
            int monto = Convert.ToInt32(Console.ReadLine());
            if (monto > 5000)
            {
                int porcent = 15;
                int descuent = monto * porcent / 100;
                Console.WriteLine("tiene que pagar " + descuent );
            }
        }
    }
}
