using System;

namespace EJERCICIO_3
{
    class Program
    {

		static void Main(string[] args)
		{
			//ejercicio 02-03 conociendo c, z
			double c = 56.31;
			double z = 3;

			//para encontrar "a" en grados
			double a = 180 - (90 + c);
			Console.WriteLine("a:" + a);

			//convertir "a" en rad
			double aRad = a * (Math.PI / 180);
			Console.WriteLine("aRad:" + aRad);

			//convertir "c" en rad
			double cRad = c * (Math.PI / 180);
			Console.WriteLine("cRad:" + cRad);

			//para encontrar "y"
			double yRad = z / Math.Tan(cRad);
			Console.WriteLine("y:" + yRad);

			//para encontrar "t"
			double t = Math.Sqrt(Math.Pow(yRad, 2) + Math.Pow(z, 2));
			Console.WriteLine("t:" + t);
		}
	}
}
