using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diferencia_de_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("edad del primer hermano ");
            int hermano1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("edad del segundo hermano ");
            int hermano2 = Convert.ToInt32(Console.ReadLine());
            if (hermano1 > hermano2)
            {
                int calculo = hermano1 - hermano2;
                Console.WriteLine("el mayor es el primer hermano y le gana por " + calculo+" años");
            }
            else
            {
                if(hermano2 > hermano1)
                {
                    int calculo2 = hermano2 - hermano1;
                    Console.WriteLine("el mayor es el segundo hermano y le gana al primer hermano por " + calculo2 +" años");
                }
            }
        }
    }
}
