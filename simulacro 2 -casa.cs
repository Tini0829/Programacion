using System;

namespace simulacro_2___casa
{
    class Program
    {
        static void Main(string[] args)
        {
           

            {
                Random aleatorio = new Random();
                int d1 = 0, d2 = 0, vida = 3, total = 0, totald = 0, turno = 0;

                Console.WriteLine("¡Bienvenido al juego!");
                string continuar = "si";


                while (continuar == "si")
                {
                    turno += 1;
             
                    if (turno % 2 == 0)
                    {
                        vida -= 1;
                    }
                    if (vida == 0)
                    {
                        Console.WriteLine("Total: " + total);
                        Console.WriteLine("Vida: " + vida);
                        Console.WriteLine("Eres un perdedor, mejor suerte la próxima");
                        break;
                    }


                    if (turno % 3 == 0)
                    {
                        Console.WriteLine("Vas a tiran dos dados, si te salen dobles tienes un +1 vida");
                        d1 = aleatorio.Next(1, 7);
                        Console.WriteLine("Dado 1: " + d1);
                        total = (d1 + total);
                        Console.WriteLine(d1);
                        d2 = aleatorio.Next(1, 7);
                        Console.WriteLine("Dado 2: " + d2);
                        total = (d2 + total);
                        Console.WriteLine(d2);
                        Console.WriteLine("Total: " + total);
                        Console.WriteLine("Vida: " + vida);

                        if (d1 == d2)
                        {
                            vida += 1;
                            Console.WriteLine("+1 vida");
                        }
                    }
                    else
                    {
                        d1 = aleatorio.Next(1, 7);
                        total = (d1 + total);
                        Console.WriteLine(d1);
                        Console.WriteLine("Total: " + total);
                        Console.WriteLine("Vida: " + vida);
                    }
                    if (total > 100)
                    {
                        Console.WriteLine("Total: " + total);
                        Console.WriteLine("¡Eres lo máximo, ganaste!");
                        Console.WriteLine("Vida: " + vida);
                        continuar = "no";
                    }
                    if (continuar == "si")

                    {
                        Console.WriteLine("Si quieres volver a tirar el dado di que si, de lo contrario presiona di que no:");
                        continuar = Console.ReadLine();
                    }

                }
            }
        }
    }
}