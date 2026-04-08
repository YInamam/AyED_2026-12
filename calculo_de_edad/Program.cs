using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_de_edad
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("¿en que año nasiste? ");
            int año = Convert.ToInt32(Console.ReadLine());
            int edad = 2026 - año;
            Console.WriteLine("Si naciste en el año " + año + " tu edad al comenzar el año es de " + edad + " años."); 
        }
    }
}
