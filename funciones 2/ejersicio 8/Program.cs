using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicio_8
{
    class Program
    {
            static bool EsPrimo(int numero)
            {

                if (numero < 2)
                {
                return false;
                }

                for (int i = 2; i < numero; i++)
                {

                    if (numero % i == 0)
                    {
                        return false;
                    }

                }

                return true;
            }
            static void MostrarPrimos(int inicio, int fin)
            {

                int canti= 0;

                if (inicio > fin)

                {

                    int aux = inicio;
                    inicio = fin;
                    fin = aux;

                }


                for (int i = inicio; i <= fin; i++)

                {
                    if (EsPrimo(i))
                    {
                        Console.WriteLine(i);
                        canti++;
                    }
                }

                Console.WriteLine("Cantidad de numeros primos: " + canti);

            }
            static void Main(string[] args)
            {

                Console.Write("Ingrese el extremo 1 ");
                int inicio = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo extremo 2: ");
                int fin = Convert.ToInt32(Console.ReadLine());
                MostrarPrimos(inicio, fin);

            }

        }
    }







