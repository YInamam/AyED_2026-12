using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicio_5
{
    class Program
    {
            static bool EsCapicua(int numero)
        {
                int orig = numero;
                int invertido = 0;

                if (numero < 0)
                {
                    numero = numero * -1;
                    orig = numero;
                }

                while (numero > 0)
                {
                    int digito = numero % 10;
                    invertido = invertido * 10 + digito;
                    numero = numero / 10;
                }

                return orig == invertido;
            }
            static int CantidadDigitos(int numero)
        {

                if (numero < 0)
                {
                    numero = numero * -1;
                }


                if (numero == 0)
                {
                    return 1;
                }

                int cantidad = 0;
                while (numero > 0)

                {
                    cantidad++;
                    numero = numero / 10;
                }

                return cantidad;

            }
            static void Main(string[] args)
        {
                Console.Write("Ingrese un numero entero: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (EsCapicua(numero))
                {
                    Console.WriteLine("el numero es capicua ");
                }
                else
                {
                    Console.WriteLine("el numero no es capicua ");
                }
                Console.WriteLine("Cantidad de digitos: " + CantidadDigitos(numero));

            }
        }
    }

