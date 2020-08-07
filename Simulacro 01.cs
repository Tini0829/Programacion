using System;
using System.ComponentModel.Design;

namespace simulacro_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //*Entradas
                Random aleatorio = new Random();
                int d1 = 0, d2 = 0, total = 0, contador = 0, seis=0, dobles=0;
                string continuar = "si";
                Console.WriteLine("Bienvenido al juego");

                while (continuar == "si" && (d1 != 1 || d2 != 1))
                {
                    d1 = aleatorio.Next(1, 7);
                    d2 = aleatorio.Next(1, 7);
                    Console.Write("Dado 1: " + d1 + " Dado 2: " + d2);

                    if (d1 == 1 && d2 == 1) //*DERROTA
                    {
                        total = 0;
                        Console.WriteLine(" Fuiste eliminado, perdedor");
                    }
                    else
                    {
                        total += (d1 + d2);
                        Console.WriteLine(" Total: " + total);

                        if (d1 == d2) dobles += 1; //*contador de dobles
                        else dobles = 0;
                        if ((d1 + d2) > 6) seis += 1;

                        if (total >= 100 || dobles >= 3) //*victoria
                        {
                            Console.WriteLine("Eres un ganador!!");
                            continuar = "no";
                        }
                        else
                        {
                            Console.Write("Desea continuar si/no: ");
                            continuar = Console.ReadLine();
                        }
                    }
                    contador += 1;
                }

                //*Porcentaje
                double porcentaje = 100 * (((double)seis) / contador);

                //*Salidas
                Console.WriteLine("Su total fue " + total + " puntos ");
                Console.WriteLine("El " + porcentaje + "% de turnos fue superior a 6");
                Console.WriteLine("Gracias por jugar");
            }
        }
    }
}
