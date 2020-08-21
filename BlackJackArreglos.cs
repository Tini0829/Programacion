using System;

namespace JackbalckArreglos
{
    class Program
    {
        static void Main(string[] args)
        {

			Random aleatorio = new Random();
			int c1 = 0, c2 = 0, nc = 0, total = 0, jugadores = 0;
			int n = 0, max = 0, ganador = 0;
			string continuar = "n";

			Console.WriteLine("Ingresa el número de jugadores (minimo 2, máximo 5): ");
			n = int.Parse(Console.ReadLine());

			while (n < 2 || n > 5)
			{
				Console.WriteLine("¡Lo siento! mínimo 2 jugadores, máximo 5");
				n = int.Parse(Console.ReadLine());

			}

			string[] players = new string[n];
			int[] puntajes = new int[n];

			while (jugadores < n)
			{


				Console.WriteLine("Inicio de juego");

				Console.WriteLine("Bienvenido jugador " + (jugadores + 1));

				Console.WriteLine("¿Cuál es tu nombre?");
				string nombre = Console.ReadLine();
				players[jugadores] = nombre;


				c1 = aleatorio.Next(1, 10);
				c2 = aleatorio.Next(1, 10);
				Console.WriteLine("Carta 1 = " + c1);
				Console.WriteLine("Carta 2 = " + c2);
				total = c1 + c2;
				Console.WriteLine("Total = " + total);

				Console.Write("¿Deseas tomar otra carta? (si/no): ");
				continuar = Console.ReadLine();



				if (total > max && total <= 21)
				{
					max = total;
					ganador = jugadores;
				}


				while (continuar == "si")
				{
					nc = aleatorio.Next(1, 11);
					Console.WriteLine("Carta = " + nc);
					total += nc;
					Console.WriteLine("Total = " + total);

					if (total >= 21)
					{
						Console.WriteLine("Eres un perdedor, mejor suerte la próxima");
						total = 0;
						continuar = "n0";
					}

					else
					{
						Console.Write("Desea tomar otra carta? (si/no): ");
						continuar = Console.ReadLine();
					}

					if (total > max && total <= 21)
					{
						max = total;
						ganador = jugadores;
					}
				}

				puntajes[jugadores] = total;
				jugadores++;
			}

			for (int c = 0; c < players.Length; c++)
			{

				for (int j = 0; j < players.Length; j++)
				{

					for (int i = 0; i < players.Length - 1; i++)
					{
						if (puntajes[i] > puntajes[i + 1])
						{
							int tmp1 = puntajes[i + 1];
							puntajes[i + 1] = puntajes[i];
							puntajes[i] = tmp1;

							string tmp2 = players[i];
							players[i] = players[i + 1];
							players[i + 1] = tmp2;
						}

					}
				}
			}


			Console.WriteLine("¡Eres lo máximo, ganaste!, "+"el ganador fue " + players[n - 1] + " con " + puntajes[n - 1] + " puntos");
			Console.WriteLine("¡Eres lo máximo!, " + "el segundo lugar fue " + players[n - 2] + " con " + puntajes[n - 2] + " puntos");
			Console.WriteLine("Gracias por jugar.");
			Console.WriteLine("¡Hasta la próxima!");
		}
	}

}
    

