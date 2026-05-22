using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_validador_obstinado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la nota del examen(un numero entero) ");
            int nota = int.Parse(Console.ReadLine());
            if (nota < 1 || nota > 10)
            {
                do
                {
                    Console.WriteLine("error ");
                    Console.WriteLine("ingrese la nota del examen(un numero entero) ");
                    nota = int.Parse(Console.ReadLine());

                } while (nota < 1 || nota > 10);
                Console.WriteLine("nota correcta " + nota);
            }

        }
    }
}
