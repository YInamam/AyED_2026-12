using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selector_de_idiomas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija un idioma  ");
            Console.WriteLine("1:Inglés ");
            Console.WriteLine("2:Francés ");
            Console.WriteLine("3:Alemán ");
            Console.WriteLine("ingrese un el idioma elegido ");

            int idiom = int .Parse(Console.ReadLine());

            switch (idiom)
            {
                case 1 :
                    Console.WriteLine("Hello ");
                    break;
                case 2 :
                    Console.WriteLine("Salud ");
                    break;
                case 3 :
                    Console.WriteLine("Hallo ");
                    break;
                
            }
        }
    }
}
