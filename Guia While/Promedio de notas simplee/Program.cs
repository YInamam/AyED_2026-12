using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_de_notas_simplee
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadr = 2;
            int suma = 0;

            while (contadr <= 5)
            {
                Console.Write("Ingrese la nota " + contadr + ": ");
                int  nota = int.Parse(Console.ReadLine());
                suma = suma + nota;
                contadr++;
            }

            int promedio = suma / 5;

            Console.WriteLine("El promedio es: " + promedio);


        }
    }
}
