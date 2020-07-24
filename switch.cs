using System;

namespace Desafio_01_Tipos_de_contrato_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double SalarioBase, cotizacion, Pension, EPS, SalarioRealMensual;
            double Salarioa;
            double minimo = 877803;
            double ARL = 0;
            double deduccionn;
            int dependencia;
            int ndr = 0;

            //Entradas:
            Console.WriteLine("Ingresa tu salario Mensual: ");
            SalarioBase = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tipo de contrato (1:DEPENDIENTE 2:INDEPENDIENTE): ");
            dependencia = int.Parse(Console.ReadLine());

            // Condiciones:
            if (dependencia == 2)
            {
                Console.WriteLine("Ingresa el nivel de riesgo del 1 al 5:");
                ndr = int.Parse(Console.ReadLine());
            }

            //Desarrollo
            cotizacion = (40 * SalarioBase) / 100;
            if (cotizacion < minimo)
            {
                cotizacion = minimo;
            }

            if (cotizacion == 1)
            {
                Pension = (4 * cotizacion) / 100;
                EPS = (4 * cotizacion) / 100;
                deduccionn = (EPS + Pension);
            }
            else
            {
                Pension = (16 * cotizacion) / 100;
                EPS = (12.5 * cotizacion) / 100;


                switch (ndr)
                {
                    case 1:
                        Console.WriteLine("nivel de riesgo 1: ");
                        ARL = (0.522 * cotizacion) / 100;
                        break;

                    case 2:
                        ARL = (1.044 * cotizacion) / 100;
                        break;

                    case 3:
                        ARL = (2.436 * cotizacion) / 100;
                        break;

                    case 4:
                        ARL = (4.350 * cotizacion) / 100;
                        break;

                    case 5:
                        ARL = (6.960 * cotizacion) / 100;
                        break;
            
                }
             deduccionn = (EPS + Pension + ARL); 

            }

            SalarioRealMensual = SalarioBase - deduccionn;

            //Salidas:
            Console.WriteLine("Tu salario real mensual es: " + SalarioRealMensual);

            if (dependencia == 1)
            {
                Salarioa = ((SalarioRealMensual * 12) + SalarioBase);
            }
            else
            {
                Salarioa = SalarioRealMensual * 12;
            }
            Console.WriteLine("Tu salario Anual: " + Salarioa);
        }
    }
}
 