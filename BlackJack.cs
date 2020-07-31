using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();
            int carta = 0, total = 0, partida = 0;
            string respuesta = "si";

            while (respuesta == "si" && total < 22)
            {
                if (partida == 0)
                {
                    carta = aleatorio.Next(1, 10);
                    Console.WriteLine(carta);
                    total = (carta + total);
                    carta = aleatorio.Next(1, 10);
                    Console.WriteLine(carta);
                    total = (carta + total);
                    Console.WriteLine("Total:" + total);

                    Console.WriteLine("Si quiere una carta presionan Si, si no presiona No:");
                    respuesta = Console.ReadLine();
                }
                else
                {
                    carta = aleatorio.Next(1, 10);
                    Console.WriteLine(carta);
                    total = (carta + total);
                    Console.WriteLine("Total:" + total);

                    if (total > 21)
                    {
                        Console.WriteLine("No puede continuar");
                    }

                    else if (total == 21)
                    {
                        Console.WriteLine("¡Ganaste!Eres un pro:");
                        respuesta = "No";

                    }
                    else
                    {
                        Console.WriteLine("Si quiere una carta presionan Si, si no presiona No:");
                        respuesta = Console.ReadLine();

                    }
                }
                partida = (partida + 1);
            }
        }
    }
}