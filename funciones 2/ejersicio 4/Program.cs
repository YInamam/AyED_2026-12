using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicio_4
{
    class Program
    {
            static int Positivos(int[] numeros)
    {
               int cant = 0;
               for (int i = 0; i < numeros.Length; i++)
               {

                    if (numeros[i] > 0)
                    {
                        cant++;
                    }

               }
               return cant;
        
            }
            static int Negativos(int[] numeros)
            {

                int cantidad = 0;
                for (int i = 0; i < numeros.Length; i++)
                {

                    if (numeros[i] < 0)
                    {
                        cantidad++;
                    }

                }

                return cantidad;

            }
            static int Ceros(int[] numeros)
            {

                int cantidad = 0;
                for (int i = 0; i < numeros.Length; i++)

                {

                    if (numeros[i] == 0)

                    {
                        cantidad++;
                    }

                }


                return cantidad;

            }
            static double PromedioPositivos(int[] numeros)
            {
                int suma = 0;
                int cantidad = 0;


                for (int i = 0; i < numeros.Length; i++)
                {

                    if (numeros[i] > 0)

                    {
                        suma += numeros[i];
                        cantidad++;
                    }

                }

                if (cantidad == 0)
                return 0;
                return (double)suma / cantidad;

            }
            static double PromedioNegativos(int[] numeros)
    {

                int suma = 0;
                int cantidad = 0;

                for (int i = 0; i < numeros.Length; i++)
                {

                    if (numeros[i] < 0)
                    {
                        suma += numeros[i];
                        cantidad++;
                    }

                }

                if (cantidad == 0)
                    return 0;
                return (double)suma / cantidad;

            }
            static void Main(string[] args)
            {

                Console.Write("determine cuantos numeros quiere ingresar: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                int[] numeros = new int[cantidad];


                for (int i = 0; i < cantidad; i++)
                {

                    Console.Write("Ingrese un numero: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());

                }


                Console.WriteLine("Positivos: " + Positivos(numeros));
                Console.WriteLine("Negativos: " + Negativos(numeros));
                Console.WriteLine("Ceros: " + Ceros(numeros));
                Console.WriteLine("Promedio positivos: " + PromedioPositivos(numeros));
                Console.WriteLine("Promedio negativos: " + PromedioNegativos(numeros));

            }
        }
    }

