using System;

namespace Desafío_1___Calculo_de_tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el valor de tu salario mínimo mensual legal vigente: ");
            double SalarioBase = double.Parse(Console.ReadLine());

            double Salario = 877803;

            //Tarifa A
            if (SalarioBase < (Salario * 2))
            {
                Console.WriteLine("Tu tarifa es A, te pagan menos de 2 salarios mínimos");
            }
            //Tarifa B
            else 
            if ((Salario*2) >= SalarioBase && SalarioBase <= (Salario * 4))
            {
                Console.WriteLine("Tu tarifa es B, te pagan 2 o más salarios mínimos pero menos de 4");
            }
           else if (SalarioBase <= (Salario * 4))
            {
                Console.WriteLine("Tu tarifa es B, te pagan 2 o más salarios mínimos pero menos de 4");
            }
            //Tarifa C
            else 
            {
               Console.WriteLine("Tu tarifa es C, te pagan 4 o más salarios mínimos");
            }


        }
    }

}
