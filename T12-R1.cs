using System;

namespace T12_R1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string[] nombres = { "Nezuko", "Tanjiro", "Zanitsu", "Inosuke", "Ganya", "Kanao", "Tomioka" };
                double[] estatura = { 153, 165, 165.5, 164, 180, 156, 176 };
                int contador = 0;
                double total = 0;
                double sumatoria = 0, min=165.5;
                string nombre = "";

                for (int i=0; i<estatura.Length; i++)
                {
                    total += estatura[i];
                }

                double promedio = total / estatura.Length;
                Console.WriteLine("El promedio es de: " + promedio);


                double[] distancia = new double[estatura.Length];
                for (int i=0; i < estatura.Length; i++)
                {
                    contador++;
                    distancia[i] = Math.Abs(estatura[i] - promedio);

                    if (distancia[i]<min)
                    {
                        min = distancia[i];
                        nombre = nombres[i];
                    }

                    Console.WriteLine("Contador: " + contador);
                    Console.WriteLine("Distancia: " + distancia[i]);
                }

                for (int i = 0; i < estatura.Length; i++)
                {
                    sumatoria += Math.Pow((estatura[i] - promedio), 2);
                }

                double des = Math.Sqrt(sumatoria / estatura.Length);
                Console.WriteLine("Desviación: " + des);

                Console.WriteLine("El más parecido al promedio fue: "+nombre);
            }
        }
    }
}