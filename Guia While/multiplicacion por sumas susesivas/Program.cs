using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicacion_por_sumas_susesivas
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Ingrese el número (A) ");
            int  A = int.Parse(Console.ReadLine());

          Console.Write("Ingrese el número (B) ");
            int  B = int.Parse(Console.ReadLine());
            int resultado = 0;
            int contador = 0;


            while (contador < B)
            {
                resultado = resultado + A;
                contador++;
            }

            Console.WriteLine("Resultado: " + resultado);
        }

    }
}
