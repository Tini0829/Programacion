using System;

namespace Reto_T11_R01_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de x");
            double x = double.Parse(Console.ReadLine());
            double e = 0;

            for (int i = 0; i < 100; i++)
            {
                double numerador = Math.Pow(x, i);
                double denominador = Factorial(i);
                e += (numerador / denominador);

            }
            Console.WriteLine("La respuesta es: "+e);

        }
        public static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }
    }
}