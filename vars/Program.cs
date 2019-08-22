using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables 
            int i = 0;
            decimal x = 0.0m;
            float y = 0.0f;
            double z = 0.0D;
            string cadena = "Hola Mundo";
            bool flag = false;
            DateTime date = DateTime.MinValue;

            Console.WriteLine("El valor de 'i' es : {0}", i);
            Console.WriteLine("El valor de 'x' es : {0:C}", x);
            Console.WriteLine("El valor de 'y' es : {0}", i);
            Console.WriteLine("El valor de 'z' es : {0}", i);
            Console.WriteLine("El valor de 'cadena' es : {0}", i);
            Console.WriteLine("El valor de 'flag' es : {0}", i);
            Console.WriteLine("El valor de 'date' es : {0}", i);
            Console.ReadKey();

        }
    }
}
