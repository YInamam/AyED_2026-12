using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Cajero_Automático
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int saldo = 10000;
                int opcion;

                do
                {
                    Console.WriteLine("Cajero Automatico");
                    Console.WriteLine("1. Depositar dinero");
                    Console.WriteLine("2. Retirar dinero");
                    Console.WriteLine("3. Ver saldo");
                    Console.WriteLine("4. Salir");
                    Console.Write("Seleccione una opción: ");

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese monto a depositar: ");
                            double deposito = double.Parse(Console.ReadLine());
                            saldo += deposito;
                            Console.WriteLine("Depósito realizado.");
                            break;

                        case 2:
                            Console.Write("Ingrese monto a retirar: ");
                            double retiro = double.Parse(Console.ReadLine());

                            if (retiro <= saldo)
                            {
                                saldo -= retiro;
                                Console.WriteLine("Retiro realizado.");
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente.");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Saldo actual: $" + saldo);
                            break;
                        case 4:
                            Console.WriteLine("Gracias por utilizar el cajero.");
                            break;

                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }

                } while (opcion != 4);
            }
        }


    }
}

