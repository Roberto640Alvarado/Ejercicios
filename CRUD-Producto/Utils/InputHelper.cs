using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Producto.Utils
{
    public class InputHelper
    {
        public static int LeerEntero(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while(!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Numero invalido, intente de nuevo: ");
            }
            return valor;
        }

        public static decimal LeerDecimal(string mensaje)
        {
            decimal valor;
            Console.Write(mensaje);
            while (!decimal.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Número inválido. Intente de nuevo: ");
            }
            return valor;
        }

        public static string LeerTexto(string mensaje)
        {
            Console.Write(mensaje);

            return Console.ReadLine();
        }
    }
}
