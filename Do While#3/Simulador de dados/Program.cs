using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            int creditos = 100;
            int apuesta;
            int dado1;
            int dado2;
            int suma;

            do
            {
                Console.WriteLine("Su crediti es de: " + creditos);

                Console.Write("Ingrese su apuesta (0 para retirarse): ");
                apuesta = Convert.ToInt32(Console.ReadLine());

                if (apuesta == 0)
                    break;
                 
                if (apuesta > creditos || apuesta < 0)
                {
                    Console.WriteLine("Apuesta inválida.");
                  
                }

                Console.Write("Ingrese el valor del dado 1 (1-6): ");
                dado1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el valor del dado 2 (1-6): ");
                dado2 = Convert.ToInt32(Console.ReadLine());

                suma = dado1 + dado2;

                if (suma == 7 || suma == 11)
                {
                    creditos += apuesta * 2;
                    Console.WriteLine("Ganaste");
                }
                else
                {
                    creditos -= apuesta;
                    Console.WriteLine("Perdiste");
                }

            } while (creditos > 0);

            Console.WriteLine("Saldo final: " + creditos);

        
        }
    }

}
    