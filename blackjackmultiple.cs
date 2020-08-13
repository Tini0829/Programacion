using System;

namespace Blackjackmultijugador
{
    class Program
    {
        static void Main(string[] args)
        {

			Random aleatorio = new Random();
			int c1 = 0, c2 = 0, nc = 0, total = 0, jugador = 0;
			int n = 0, maximo = 0, ganador = 0;
			string continuar = "no";

			Console.WriteLine("Ingresa el número de jugadores (minimo 2, máximo 5): ");
			n = int.Parse(Console.ReadLine());

			while (n < 2 || n >= 5)
			{
				Console.WriteLine("¡Lo siento! mínimo 2 jugadores, máximo 5");
				n = int.Parse(Console.ReadLine());

			}

			while (jugador + 1 <= n)
			{

				Console.WriteLine("Inicio de juego");

				Console.WriteLine("Bienvenido jugador " + (jugador+1));

				c1 = aleatorio.Next(1, 10);
				c2 = aleatorio.Next(1, 10);
				Console.WriteLine("Carta 1: " + c1);
				Console.WriteLine("Carta 2: " + c2);
				total = c1 + c2;
				Console.WriteLine("Total: " + total);

				Console.Write("Desea tomar otra carta? (si/no): ");
				continuar = Console.ReadLine();

				jugador++;

				/*if (total > maximo && total <= 21)
				{
					maximo = total;
					ganador = jugador;
				}*/

				while (continuar == "si")
				{
					nc = aleatorio.Next(1, 11);
					Console.WriteLine("Carta: " + nc);
					total += nc;
					Console.WriteLine("Total: " + total);

					if (total >= 21)
					{
						Console.WriteLine("Eres un perdedor, mejor suerte la próxima");
						total = 0;
						continuar = "no";
					}

					else
					{
						Console.Write("¿Desea tomar otra carta? (si/no): ");
						continuar = Console.ReadLine();
					}
				}

				if (total > maximo && total <= 21)
				{
					maximo = total;
					ganador = jugador;
				}

			}

			Console.WriteLine("¡Eres lo máximo, ganaste!, El ganador fue el jugador " + ganador);
			Console.WriteLine("Gracias por jugar");
			Console.WriteLine("¡Hasta la próxima!");
		}
	}
}
