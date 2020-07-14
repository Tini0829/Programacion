using System;

namespace EJERCICIO_4._4
{
    class Program
    {
        static void Main(string[] args)
        {

            //4 Entrada: w, t, c Salida: x

            // Ingreso de datos:
            Console.WriteLine("Ingresar w: ");
            double w = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar t: ");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar c: ");
            double cGrados = double.Parse(Console.ReadLine());

            //Encontrar "e":
            double aGrados = 180 - (cGrados + 90);
            double aRad = aGrados * (Math.PI / 180);
           
            //Valores:
            double y = t *(Math.Sin(aRad));
            double z = t * (Math.Cos(aRad));
            double xy = Math.Sqrt(Math.Pow(w,2)-Math.Pow(z,2));
            double x = xy - y;
       

            //Respuesta:
            double x1 = Math.Ceiling(x);
            Console.WriteLine("x: " + x1);


        }
    }
}
