using System;

namespace simulacro_2___casa
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Entradas
            Random aleatorio = new Random();
            int d = 0, d2 = 0, total = 0, vida = 3, turnosvida = 0, turnosdados = 0;
            string continuar = "si";
            Console.WriteLine("Bienvenido al juego");

            while (continuar == "si" && total < 100)
            {
                //Turnos 
                turnosdados += 1;
                turnosvida += 1;

                //Dos dados, turno 3 y suma de vidas
                if (turnosdados == 3)
                {
                    turnosdados = 0;
                    d = 3;
                    d2 = 3;
                    Console.WriteLine("Dado 1: " + d);
                    Console.WriteLine("Dado 2: " + d2);
                    total += d + d2;

                    if (d == d2)
                    {
                        vida += 1;
                        Console.WriteLine("+1 de vida");
                        Console.WriteLine("Tienes " + vida + " vida");
                    }
                }
                else
                {
                    d= aleatorio.Next(1, 7);
                    Console.WriteLine("Dado: " +d);
                    total += d;
                }
                //perder vida
                if (turnosvida==2)
                {
                    turnosvida = 0;
                    vida -= 1;
                    Console.WriteLine("-1 de vida");
                    Console.WriteLine("Te quedan "+vida+" vida");

                    if (vida == 0)
                    {
                        Console.WriteLine("Fuiste eliminado, eres un perdedor :(");
                        break;
                    }
                }
                //Total
                Console.WriteLine("Total: "+total);

                //Ganar
                if(total > 99)
                {
                    Console.WriteLine("Eres lo máximo, ganaste");
                    break;
                }

                //Continuación del juego
                else
                {
                    Console.WriteLine("¿Deseas continuar? (si/no)");
                    continuar= Console.ReadLine();
                    if (continuar == "no") break;
                }
            }

            Console.WriteLine("Tu total fue: " + total);
            Console.WriteLine("Gracias por participar");
        }
    }
}
