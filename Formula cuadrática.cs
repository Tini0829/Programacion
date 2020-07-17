using System;

namespace Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa A: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa B: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa C: ");
            double c = double.Parse(Console.ReadLine());

            double discriminante = (Math.Pow(b, 2) - (4 * a * c));

            if (discriminante == 0)
            {
                double positivo = (-b) / (2 * a);
                Console.WriteLine("LA SOLUCIÓN ES ÚNICA");
                Console.WriteLine("SOLUCIÓN:" + positivo);
            }
            else if (discriminante > 0)
            {
                double positivo = ((-b) + Math.Sqrt(discriminante) )/ (2*a);
                double negativo = ((-b) - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("EXISTEN DOS SOLUCIONES");
                Console.WriteLine("SOLUCIÓN 1:" + positivo);
                Console.WriteLine("SOLUCIÓN 2:" + negativo);
            }
            else
            {
                Console.WriteLine("NO HAY SOLUCIÓN");
            }
        }
    }
}
