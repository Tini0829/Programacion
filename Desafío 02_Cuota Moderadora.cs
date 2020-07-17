using System;

namespace Desafío_02___Cuota_Moderadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el valor de tu salario mínimo mensual legal vigente: ");
            double SalarioBase = double.Parse(Console.ReadLine());

            double Salario = 877803;

           // double A = SalarioBase -  0.115;
           // double A1 = Math.Ceiling(A);

            //double B = Salario * 0.173;
            // double B1 = Math.Ceiling(B);

            //double C = Salario * 0.23;
            //double C1 = Math.Ceiling(C);

            //Tarifa A
            if (SalarioBase < (Salario * 2))
            {
                Console.WriteLine("Tu tarifa es A, te pagan menos de 2 salarios mínimos");
                Console.WriteLine("TU CUOTA ES: 3.400 " );
            }
            //Tarifa B
            else
            if ((Salario * 2) >= SalarioBase && SalarioBase <= (Salario * 4))
            {
                Console.WriteLine("Tu tarifa es B, te pagan 2 o más salarios mínimos pero menos de 4");
                Console.WriteLine("TU CUOTA ES: 13.500" );
            }
            else if (SalarioBase <= (Salario * 4))
            {
                Console.WriteLine("Tu tarifa es B, te pagan 2 o más salarios mínimos pero menos de 4");
                Console.WriteLine("TU CUOTA ES: 13.500 " );
            }
            //Tarifa C
            else
            {
                Console.WriteLine("Tu tarifa es C, te pagan 4 o más salarios mínimos");
                Console.WriteLine("TU CUOTA ES: 35.600 ");
            }
            
        }
    }
}
