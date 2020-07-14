using System;

namespace Binario_a_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos:
            Console.WriteLine("Valor 0 binario es: ");
            string s1 = Console.ReadLine();

            Console.WriteLine("Valor 1 binario es: ");
            string s2 = Console.ReadLine();

            Console.WriteLine("Valor 2 binario es: ");
            string s3 = Console.ReadLine();

            Console.WriteLine("Valor 3 binario es: ");
            string s4 = Console.ReadLine();

            Console.WriteLine("Valor 4 binario es: ");
            string s5 = Console.ReadLine();


            //Conversión
            int b1 = Convert.ToInt32(s1, 2);
            int b2 = Convert.ToInt32(s2, 2);
            int b3 = Convert.ToInt32(s3, 2);
            int b4 = Convert.ToInt32(s4, 2);
            int b5 = Convert.ToInt32(s5, 2);


            //Resultados
            Console.WriteLine("EL Valor 0 En decimal en base 10 es: " + b1);
            Console.WriteLine("EL Valor 1 En decimal en base 10 es:  " + b2);
            Console.WriteLine("EL Valor 2 En decimal en base 10 es:  " + b3);
            Console.WriteLine("EL Valor 3 En decimal en base 10 es:  " + b4);
            Console.WriteLine("EL Valor 4 En decimal en base 10 es:  " + b5);
        }
    }
}
