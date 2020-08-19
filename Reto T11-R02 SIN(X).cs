using System;

namespace Reto_T11_R02_SIN_X_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de x");
            double x = double.Parse(Console.ReadLine());
            double sin = 0;

            for (int i = 0; i < 1000; i++)
            {
                double numerador = Math.Pow(-1, i);
                double denominador = Factorial (2 * i + 1);
                sin += (numerador / denominador) * Math.Pow (x, 2 * i + 1);

            }
            //*double sen1 = Math.Floor(sen); double sin1 = Math.Ceiling(sin);

            Console.WriteLine("La respuesta es: "+sin);

        }
       static double Factorial(double valor)
        {
            if (valor == 1) return 1;
            return valor * Factorial(valor - 1);
        }
    }
}