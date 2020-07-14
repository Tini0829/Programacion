using System;
using System.ComponentModel;

namespace desafio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Entrada: b.z.y   Salida: x

            // Ingreso de datos:
            Console.Write("Ingrese b: ");
            double bGrados = double.Parse(Console.ReadLine());

            Console.Write("Ingrese z: ");
            double z = double.Parse(Console.ReadLine());

            Console.Write("Ingrese y: ");
            double y = double.Parse(Console.ReadLine());

            // De ángulos a Radianes:
            double b = bGrados * (Math.PI / 180);

            // Encontrar "t":
            double t = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(y, 2));

            // Valores:
            double x = t * Math.Sin(19.44);

            // Respuesta de x:
            double x1 = Math.Floor(x);
            Console.WriteLine("x: " + x1);


        }
    }
}
