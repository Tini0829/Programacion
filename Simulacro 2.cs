using System;

namespace simulacro_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, contador = 0, turno = 0;
            string continuar = "si";
            
            Console.WriteLine("Bienvenido al juego");
            
            while (continuar == "si" && total < 100)
            {
                turno += 1;
                Console.WriteLine("Turno:" + turno);
                dado = aleatorio.Next(1, 13);
                Console.WriteLine("Dado:" + dado);
                total = (dado + total);
                Console.WriteLine("Total:" + total);
               

                if (turno > 3)
                {
                    if (dado % 2 != 0)
                    {
                        total = 0;
                        Console.WriteLine("Fuiste eliminado, eres un perdedor :(");
                        continuar = "no";
                    }
                    if (dado == 12)
                    {
                        contador += 1;
                    }

                    if (contador == 1)
                    {
                        if (dado == 10)
                        {
                            contador += 1;
                        }
                        if (dado != 10)
                        {
                            contador = 0;
                        }
                    }

                    if (total >= 100 || contador == 2)
                    {
                        Console.WriteLine("Eres lo máximo, ganaste :)");
                        continuar = "n0";
                    }
                }

                if (continuar == "si")

                {
                    Console.WriteLine("¿Quieres seguir jugando (si/no)?:");
                    continuar = Console.ReadLine();
                }
            }


        }
    }
}

