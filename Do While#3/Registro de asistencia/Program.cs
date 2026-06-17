using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_asistencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar;
            int presentes = 0;
            int ausentes = 0;
            int total;

            do
            {
                Console.Write("Nombre del alumno: ");
                string  nombre = Console.ReadLine();
        
                Console.Write("Estado (P = Presente, A = Ausente): ");
               string estado = Console.ReadLine().ToUpper();

                if (estado == "P")
                    presentes++;
                else if (estado == "A")
                    ausentes++;

                Console.Write("¿Desea cargar otro alumno? (S/N): ");
                continuar = Console.ReadLine();

            } while (continuar == "S");

            total = presentes + ausentes;

            int porcentaje = (int)presentes * 100 / total;

            Console.WriteLine("Presentes: " + presentes);
            Console.WriteLine("Ausentes: " + ausentes);
            Console.WriteLine("Porcentaje de presentismo: " + porcentaje + "%");
        }
    }
}
    