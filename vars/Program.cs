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
            float f = 0.0f;
            double d = 0.0D;
            string cadena = "Hola Mundo";
            bool flag = false;
            DateTime date = DateTime.MinValue;

            Console.WriteLine("El valor de 'i' es : {0}", i);
            Console.WriteLine("El valor de 'x' es : {0:C}", x);
            Console.WriteLine("El valor de 'f' es : {0:F2}", f);
            Console.WriteLine("El valor de 'd' es : {0:F2}", d);
            Console.WriteLine("El valor de 'cadena' es : " +cadena);
            Console.WriteLine("El valor de 'flag' es : " + flag.ToString());
            Console.WriteLine("El valor de 'date' es : "+ date.ToShortDateString());
            Console.ReadKey();

        }
    }
}
