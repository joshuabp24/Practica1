using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Evaluativa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola ??");
            Operacion op = new Operacion();
            Console.WriteLine("Ingrese el id de una de las personas");
            int temp = Convert.ToInt32(Console.ReadLine());
            op.BuscarPersona(temp);
            Console.ReadKey();
        }
    }
}
