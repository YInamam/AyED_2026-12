using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un numero positivo: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = SumarHasta(num);
            Console.WriteLine("La suma es: " + result);
        }

        static int SumarHasta(int num)
        {
            int mult = 1;
            for (int i = 1; i <= num; i++)
            {
                mult = mult * i;

            }
            return mult;

        }


    }

}
