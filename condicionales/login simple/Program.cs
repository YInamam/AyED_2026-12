using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un nombre de usuario ");
            string usuario = Console.ReadLine();
            Console.Write("ingrese contraseña ");
            string contraseña = Console.ReadLine();
            if (usuario == "admin")
            {
                if (contraseña == "1234")
                {
                    Console.WriteLine("acceso consedido");
                }
            }
            else
            {
                Console.WriteLine("Error de credenciales");
            }
            
        }
    }
}
