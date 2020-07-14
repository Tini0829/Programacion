using System;

namespace ASESORÍA_1
{

	public class Program
	{
		public static void Main()
		{
			// Entrada del usuario de la variable X1
			Console.Write("Ingrese X1: ");
			double x1 = double.Parse(Console.ReadLine());

			// Entrada del usuario de la variable Y1
			Console.Write("Ingrese Y1: ");
			double y1 = double.Parse(Console.ReadLine());

			// Entrada del usuario de las variables restantes
			// ...

			// Entrada del usuario de la variable X2
			Console.Write("Ingrese X2: ");
			double x2 = double.Parse(Console.ReadLine());

			// Entrada del usuario de la variable Y2
			Console.Write("Ingrese Y2: ");
			double y2 = double.Parse(Console.ReadLine());

			// Entrada del usuario de las variables restantes
			// ...

			double m = (y2 - y1) / (x2 - x1);
			Console.WriteLine("pendiente:" + m);

			double b = y1 - (m * x1);
			Console.WriteLine("intercepto:" + b);

			double d = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
			Console.WriteLine("distancia:" + d);
		}
	}
}



