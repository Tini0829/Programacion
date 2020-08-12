using System;

namespace simulacro_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Entradas
            Random aleatorio = new Random();
            int d = 0, total = 0, uno = 0, seis = 0, vida = 3, especial = 2, despecial = 0;
            string continuar = "si", UsarEspecial = "no";
            Console.WriteLine("Bienvenido al juego");

            while (continuar == "si" && vida > 0 && total < 100)
            {
                if (especial > 0)
                {
                    Console.WriteLine("Tienes " + especial + " dados especiales");
                    Console.WriteLine("¿Deseas usar uno? (si/no): ");
                    UsarEspecial = Console.ReadLine();

                    if (UsarEspecial == "si")
                    {
                        despecial = aleatorio.Next(1, 13);
                        total += despecial;


                        if (continuar == "no")
                            break;
                         especial--;

                        if (despecial == 1) uno++;
                        if (despecial == 6) seis++;
                        else seis = 0;
                        if (vida <= 3 && seis == 2) vida++;

                        if (uno == 2)
                        {
                            //operación de unos;
                            vida--;
                            if (total >= 10) total -= 10;
                            else total = 0;

                        }

                        if (especial == 0) Console.WriteLine("Ya no tienes más dados especiales");
                        Console.WriteLine("Tu dado especial: " + despecial);
                        Console.WriteLine("Tu total es de: " + total);
                        Console.WriteLine("¿Deseas continuar? (si/no): " + continuar);

                        continuar = Console.ReadLine();
                    }
                }

                if (UsarEspecial == "no" || especial == 0)
                {
                    d = aleatorio.Next(1, 7); //6
                    total += d;


                    if (d == 1) uno++;
                    if (d == 6 || seis != 2) seis++;
                    else seis = 0;
                 

                    //vidas
                    if (vida <= 3 && seis % 2 == 0) vida++;
                    if (uno == 2)
                    {
                        //operación de unos;
                        vida--;
                        if (total >= 10) total -= 10;
                        else total = 0;

                    }
                    if (vida == 0)
                    {    //Perdedor
                        Console.WriteLine("Tu dado es: " + d);
                        Console.WriteLine("Tu total es de: " + total);
                        Console.WriteLine("¡Eres lo un loser, perdedor!");
                        break;
                    }

                    //Salidas
                    Console.WriteLine("Tu dado es: " + d);
                    Console.WriteLine("Tu total es de: " + total);
                    Console.WriteLine("Tu vida es de: " + vida);
                    Console.WriteLine("¿Deseas continuar? (si/no): " );
                    continuar = Console.ReadLine();
                }
            }
            //Ganador
            if (total > 100) 
           Console.WriteLine("¡Eres lo máximo, ganaste!");
           Console.WriteLine("Tu total es de: " + total);
        }
    }
}

