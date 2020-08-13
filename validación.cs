using System;

namespace Validación
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int n1,n2,total,f;
            int op = 0;
            n1 = aleatorio.Next(1, 10);
            n2 = aleatorio.Next(1, 10);
            total = n1 + n2;
            Console.WriteLine("¡Bienvenido!");
            Console.WriteLine("Conteste esta simple pregunta:"); 
            Console.WriteLine("¿Cuanto es" + n1+ "+" + n2+"?:");
            f = int.Parse(Console.ReadLine());
          
            

            while (f != total)
            {
                Console.WriteLine("Vuelve a intentar, la respuesta esta incorrecta");
                n1 = aleatorio.Next(1, 10);
                n2 = aleatorio.Next(1, 10);
                total = n1 + n2; 
                Console.WriteLine("¿Cuanto es " + n1 + " + " + n2 + " ?:");
                f = int.Parse(Console.ReadLine());
                op += 1;
               

                if (op == 3)
                {
                    Console.WriteLine("¡Eres un fracaso o un computador, fuera de aquí!");break;
                } 

            }
                 
                if (f == total)
                {
                    Console.WriteLine("Puedes continuar"); 
                } 
        }

    }
}
