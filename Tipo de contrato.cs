using System;

namespace Tipos_de_Contrato
{
    class Program
    {
        static void Main()
        {

            //variables
            double SalarioBase, Cotizacion, Pension, EPS, SalarioRealMensual;
            double Salarioa;
            double minimo = 877803;
            double ARL = 0;
            double Deduccion;
            int dependencia;
            int NRG = 0;

            //Entradas:
            Console.WriteLine("Ingresa tu salario Mensual: ");
            SalarioBase = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tipo de contrato (1:DEPENDIENTE 2:INDEPENDIENTE): ");
            dependencia = int.Parse(Console.ReadLine());

            // Condiciones:
            if (dependencia == 2)
            {
                Console.WriteLine("Ingresa el nivel de riesgo del 1 al 5:");
                NRG = int.Parse(Console.ReadLine());
            }

            //Desarrollo
            Cotizacion = (40 * SalarioBase) / 100;
            if (Cotizacion < minimo)
            {
                Cotizacion = minimo;
            }

            if (Cotizacion == 1)
            {
                Pension = (4 * Cotizacion) / 100;
                EPS = (4 * Cotizacion) / 100;
                Deduccion = (EPS + Pension);
            }
            else
            {
                Pension = (16 * Cotizacion) / 100;
                EPS = (12.5 * Cotizacion) / 100;
                if (NRG == 1)
                {
                    ARL = (0.522 * Cotizacion) / 100;
                }
                else if (NRG == 2)
                {
                    ARL = (1.044 * Cotizacion) / 100;
                }
                else if (NRG == 3)
                {
                    ARL = (2.436 * Cotizacion) / 100;
                }
                else if (NRG == 4)
                {
                    ARL = (4.350 * Cotizacion) / 100;
                }
                else if (NRG == 5)
                {
                    ARL = (6.960 * Cotizacion) / 100;
                }
                Deduccion = (EPS + Pension + ARL);
            }
            SalarioRealMensual = SalarioBase - Deduccion;

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



