using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace el_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el lado 1 ");
            int lado1 = Convert.ToInt32(Console.ReadLine());
            int lado2 = Convert.ToInt32(Console.ReadLine());
            int lado3 = Convert.ToInt32(Console.ReadLine());
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("equilatero");
            }
            else
            {
                if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3 )
                {
                    Console.WriteLine("isoceles ");
                }
                else
                {
                    Console.WriteLine("Escaleno"); 
                }
          
            }
                  
        }
    }
}
