using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicio_9
{
    class Program
    {
            static int VecesQueAparece(int[] numeros, int numero)
            {
                int cantidad = 0;

                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] == numero)
                    {
                        cantidad++;
                    }
                }

                return cantidad;
            }
            static void MostrarMasRepetidos(int[] numeros)
            {

                int mayorCantidad = 0;

                for (int i = 0; i < numeros.Length; i++)
                {
                    int cantidad = VecesQueAparece(numeros, numeros[i]);
                    if (cantidad > mayorCantidad)
                    {
                        mayorCantidad = cantidad;
                    }
                }

                Console.WriteLine("Numero/s que mas se repitieron:");

                for (int i = 0; i < numeros.Length; i++)
                {
                    int cantidad = VecesQueAparece(numeros, numeros[i]);
                    bool yaMostrado = false;

                    for (int j = 0; j < i; j++)
                    {
                        if (numeros[j] == numeros[i])
                    {
                            yaMostrado = true;
                        }
                    }

                    if (cantidad == mayorCantidad && !yaMostrado)
                    {
                        Console.WriteLine(numeros[i] + " - " + mayorCantidad + " veces");
                    }
                }
            }
            static void Main(string[] args)
            {

                Console.Write("Ingrese la cantidad de numeros: ");
                int cant = Convert.ToInt32(Console.ReadLine());
                int[] numeros = new int[cant];

                for (int i = 0; i < cant; i++)
                {
                    Console.Write("Ingrese un numero: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                }

                MostrarMasRepetidos(numeros);

            }
        }
    }
    
