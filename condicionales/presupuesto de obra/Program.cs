using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presupuesto_de_obra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el presupuesto disponible ");
            int presupuesto = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese el costo de lo materiale ");
            int costo = Convert.ToInt32(Console.ReadLine());
            if (costo > presupuesto)
            {
                int calculo = costo - presupuesto;
                Console.WriteLine("hay que pedir prestado " + calculo);
            }
        }
    }
}
