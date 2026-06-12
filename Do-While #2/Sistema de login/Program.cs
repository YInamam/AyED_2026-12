using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_login
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuarioC = "pepe";
            string contraseñaC = "6767";

            int intentos = 0;

            while (intentos < 3)
            {
                Console.Write("Usuario: ");
                string usuario = Console.ReadLine();

                Console.Write("Contraseña: ");
                string contraseña = Console.ReadLine();

                if (usuario == usuarioC && contraseña == contraseñaC)
                {
                    Console.WriteLine("Bienvenido al sistema.");
                    break;
                }

                intentos++;
            }

            if (intentos == 3)
            {
                Console.WriteLine("Cuenta bloqueada por seguridad.");
            }
        }
    }

}
