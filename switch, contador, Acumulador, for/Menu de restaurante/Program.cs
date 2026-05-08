using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_de_restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
   
            Console.WriteLine("(S)ándwich");
            Console.WriteLine("(P)izza");
            Console.WriteLine("(H)amburguesa.");
            Console.WriteLine("ingrese lo seleccionado ");
            
            string selec = Console.ReadLine();

            switch (selec)
            {
                case "S":
                    Console.WriteLine("(S)andwich esta 3000 ");
                    break;
                case "P":
                    Console.WriteLine("(P)izz esta 2500 ");
                    break;
                case "H":
                    Console.WriteLine("(H)amburguesa esta 1000 ");
                    break;
                default:
                    Console.WriteLine("Producto no encontrado");
                    break;

            }
        }
    }
}