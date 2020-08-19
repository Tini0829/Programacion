using System;

namespace Reto_T11_R01.Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el valor de x");
            double x = double.Parse(Console.ReadLine());
            double e = 0;

            for (int i = 0; i < 100; i++)
            {
                double numerador = Math.Pow(x, i);
                double denominador = Factorial(i);
                e += (numerador / denominador);
                

            }
            //*double e1 = Math.Floor(e); double e1 = Math.Ceiling(e);
            Console.WriteLine("La respuesta es: "+ e);

        }
        static double Factorial(double valor)
        {
            if (valor <= 0) return 1;
           else return valor * Factorial(valor - 1);
        }
    }
}