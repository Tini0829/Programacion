using System;

namespace Desafio_O__Y
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADAS
            Console.WriteLine("Número de votos por el partido 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de votos por el partido 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de votos en blanco: ");
            int blancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de votos en anulados: ");
            int anulados = int.Parse(Console.ReadLine());

            Console.WriteLine("Número total de la población de todas las edades: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("El porcentaje (de 0 a 100%) de la población que es mayor de edad: ");
            double p = double.Parse(Console.ReadLine());


            //DESARROLLO:
          
            int totalv = (a + b + blancos + anulados);
            Console.WriteLine("Total votaciones:" + totalv);

            double pme = (n * (p / 100));
            Console.WriteLine("Población mayor de edad:" + pme);

            double anuladosmenor = (0.3 * (a + b));
            Console.WriteLine("Anulados menor 30%:" + anuladosmenor);

            double abs = (pme - totalv);
            Console.WriteLine("Abstencion:" + abs);

            bool an = anulados < anuladosmenor;
            bool abmb = (a + b) > blancos;
            bool abstv = abs < totalv;

            //CONDICIONAL
            if ( an || abmb && abstv) 
            {
                Console.WriteLine("Las votaciones fueron exitosas");
                if (a > b)
                {
                    Console.WriteLine("Ganador partido 1");
                }
                else  Console.WriteLine("Ganador partido 2");
            }
            else
                {
                    Console.WriteLine("Deben repetirse las votaciones");
                }

        }

    }
}