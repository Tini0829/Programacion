using System;

namespace EJERCICIO_2
{
    class Program
    {

		static void Main(string[] args)
		{
			//ejercicio 02-02 conociendo t, a
			double t = 3.61;
			double a = 33.69;

			//para encontrar "c"
			double c = 180 - (90 + a);
			Console.WriteLine("c:" + c);


			//para encontrar "z"
			double zRad = t * Math.Sin(90); ;
			double zDregress = zRad;
			Console.WriteLine("z:" + zDregress);

			//para encontrar "y"
			double yRad = t * Math.Sin(a);
			double yDregress = yRad;
			Console.WriteLine("y:" + yDregress);
		}

	}
}
