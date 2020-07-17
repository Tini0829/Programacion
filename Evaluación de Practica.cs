using System;

namespace Evaluación_de_práctica
{
    class Program
    {
        static void Main()
        {
            // Entrada de datos
            Console.WriteLine("Ingresa el valor de tu salario mensual: ");
            double Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tipo de contrato (1:DEPENDIENTE 2:INDEPENDIENTE): ");
            int Contrato = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la clase de riesgo (ARL) del 1 al 5: ");
            int ARL = int.Parse(Console.ReadLine());

            double SMMV = 877803;
            //double AuxTransporte = 102854;
            double SaludDep = SMMV * 0.04;
            double PensionesDep = SMMV * 0.04;
            double SaludInd = SMMV * 0.16;
            double PensionesInd = SMMV * 0.125;
            

            // Entradas adicionales...


            if (Contrato == 1) // Dependiente
            { 
                double Deduccion = SaludDep + PensionesDep;
                double RealMensual1 = Salario - Deduccion;
                double RealMensual = Math.Ceiling(RealMensual1);
                Console.WriteLine("Real Mensual:" + RealMensual1);

                double Prima = Salario;
                double SalarioAnual = (Salario*12) - Deduccion + Prima;
                double SalarioAnual1 = Math.Ceiling(SalarioAnual);
                Console.WriteLine("Salario Anual:" + SalarioAnual1);

            }

            else // Independiente
            { 
                if (ARL == 0)
                {
                    double Deduccion = SaludInd + PensionesInd;
                    double RealMensuaInd = Salario - Deduccion;
                    double RealMensualInd1 = Math.Ceiling(RealMensuaInd);
                    Console.WriteLine("Real Mensual:" + RealMensualInd1);

                    double SalarioAnual = (Salario * 12) - Deduccion;
                    double SalarioAnual1 = Math.Ceiling(SalarioAnual);
                    Console.WriteLine("Salario Anual:" + SalarioAnual1);

                   // Console.WriteLine("EPS:" + SaludInd);
                   //Console.WriteLine("Pensión:" + PensionesInd);
                   // Console.WriteLine("Desucciones:" + Deduccion);
                }
                else if(ARL == 1)
                {
                    double Deduccion = SaludInd + PensionesInd + 0.00522;
                    double RealMensuaInd = Salario - Deduccion;
                    double RealMensualInd1 = Math.Ceiling(RealMensuaInd);
                    Console.WriteLine("Real Mensual:" + RealMensualInd1);

                    double SalarioAnual = (Salario * 12) - Deduccion;
                    double SalarioAnual1 = Math.Ceiling(SalarioAnual);
                    Console.WriteLine("Salario Anual:" + SalarioAnual1);

                    //Console.WriteLine("EPS:" + SaludInd);
                    // Console.WriteLine("Pensión:" + PensionesInd);
                    //Console.WriteLine("Desucciones:" + Deduccion);
                }
                else if (ARL == 2)
                {
                    double Deduccion = SaludInd + PensionesInd + 0.01044;
                    double RealMensuaInd = Salario - Deduccion;
                    double RealMensualInd1 = Math.Ceiling(RealMensuaInd);
                    Console.WriteLine("Real Mensual:" + RealMensualInd1);

                    double SalarioAnual = (Salario * 12) - Deduccion;
                    double SalarioAnual1 = Math.Ceiling(SalarioAnual);
                    Console.WriteLine("Salario Anual:" + SalarioAnual1);

                    //Console.WriteLine("EPS:" + SaludInd);
                    // Console.WriteLine("Pensión:" + PensionesInd);
                    //Console.WriteLine("Desucciones:" + Deduccion);
                }
                else if (ARL == 3)
                {
                    double Deduccion = SaludInd + PensionesInd + 0.02436;
                    double RealMensuaInd = Salario - Deduccion;
                    double RealMensualInd1 = Math.Ceiling(RealMensuaInd);
                    Console.WriteLine("Real Mensual:" + RealMensualInd1);

                    double SalarioAnual = (Salario * 12) - Deduccion;
                    double SalarioAnual1 = Math.Ceiling(SalarioAnual);
                    Console.WriteLine("Salario Anual:" + SalarioAnual1);

                    //Console.WriteLine("EPS:" + SaludInd);
                    //Console.WriteLine("Pensión:" + PensionesInd);
                    // Console.WriteLine("Desucciones:" + Deduccion);

                }
                else if (ARL == 4)
                {
                    double Deduccion = SaludInd + PensionesInd + 0.0435;
                    double RealMensuaInd = Salario - Deduccion;
                    double RealMensualInd1 = Math.Ceiling(RealMensuaInd);
                    Console.WriteLine("Real Mensual:" + RealMensualInd1);

                    double SalarioAnual = (Salario * 12) - Deduccion;
                    double SalarioAnual1 = Math.Ceiling(SalarioAnual);
                    Console.WriteLine("Salario Anual:" + SalarioAnual1);

                    // Console.WriteLine("EPS:" + SaludInd);
                    // Console.WriteLine("Pensión:" + PensionesInd);
                    //Console.WriteLine("Desucciones:" + Deduccion);
                }
                else
                {
                    double Deduccion = SaludInd + PensionesInd + 0.0696;
                    double RealMensuaInd = Salario - Deduccion;
                    double RealMensualInd1 = Math.Ceiling(RealMensuaInd);
                    Console.WriteLine("Real Mensual:" + RealMensualInd1);

                    double SalarioAnual = (Salario * 12) - Deduccion;
                    double SalarioAnual1 = Math.Ceiling(SalarioAnual);
                    Console.WriteLine("Salario Anual:" + SalarioAnual1);

                    //Console.WriteLine("EPS:" + SaludInd);
                    //Console.WriteLine("Pensión:" + PensionesInd);
                    // Console.WriteLine("Desucciones:" + Deduccion);
                }
            }

        }
    }
}
