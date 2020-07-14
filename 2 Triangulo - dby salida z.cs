using System;

namespace EJERCICIO_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 Entrada: d, b, y Salida: z

            // Ingreso de datos:
            Console.WriteLine("Ingresar b: ");
            double bGrados = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar d: ");
            double dGrados = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar y: ");
            double y = double.Parse(Console.ReadLine());

            // De ángulos a Radianes:
            double b = bGrados * (Math.PI / 180);
            double d = dGrados * (Math.PI / 180);

            // Encontrar "c, a":
            double a = 180 - (b + d);
            double c = 180 - (a + 90) ;
            double a1 = Math.PI - (Math.PI / 2) - c;

            // Valores:
            double t = y / Math.Cos(a1);
            double z1 = Math.Sqrt(Math.Pow(t, 2) + Math.Pow(y, 2));

            // Respuesta de z:
            double z = Math.Ceiling(z1);
            Console.WriteLine("z: " + z);

        }
    }
}
