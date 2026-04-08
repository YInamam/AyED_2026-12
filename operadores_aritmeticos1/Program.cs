using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores_aritmeticos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("escribe un valor ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("escribe valor ");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            int suma = valor1 + valor2;
            int resta = valor1 - valor2;
            int multiplicacion = valor1 * valor2;
            int divicion = valor1 / valor2;
            Console.WriteLine("La suma de los dos valores es " + suma + " la resta es " + resta + " la multiplicacion es " + multiplicacion + " y la divicion es " + divicion);
        }
    }
}
