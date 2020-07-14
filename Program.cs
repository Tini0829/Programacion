using System;

namespace EJERCICIO_1
{
	class Program
	{
		static void Main(string[] args)
		{
			//ejercicio 02-01 conociendo y, z
			double y = 2;
			double z = 3;

			//para encontrar "a" 
			double aRad = Math.Atan(y / z);
			double aDregress = aRad * 180 / Math.PI;
			Console.WriteLine("a:" + aDregress);

			//para calcular "c"
			double cRad = Math.Atan(z / y);
			double cDregress = cRad * 180 / Math.PI;
			Console.WriteLine("c:" + cDregress);

			//para encontrar "t"
			double H = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2));
			Console.WriteLine("t:" + H);
		}

	}
}