using System;

namespace EJERCICIO_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 Entrada: w, d, x Salida: y

            // Ingreso de datos:
            Console.WriteLine("Ingresar w: ");
            double w = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar x: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar d: ");
            double dGrados = double.Parse(Console.ReadLine());

            // Encontrar "c, a":
            double dRad = dGrados * (Math.PI / 180);
            double z = w * (Math.Sin(dRad));
            double W = w * w;
            double Z = z * z;

            // Valores:
            double y = (x - (Math.Sqrt(W - Z)));

            // Respuesta de y:
            double y1 = Math.Ceiling(y);
            Console.WriteLine("y: " + y1);
        }
    }
}
