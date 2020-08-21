using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Nezuko", "Tanjiro", "Zanitsu", "Inosuke", "Ganya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 165.5, 164, 180, 156, 176 };

            for (int j = 0; j < estatura.Length; j++)
            {
                for (int i = 0; i < estatura.Length - 1; i++)
                {
                    if (estatura[i] > estatura[i + 1])
                    {
                        double tmp = estatura[i];
                        estatura[i] = estatura[i + 1];
                        estatura[i + 1] = tmp;
                        string tmp1 = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = tmp1;
                    }
                }
            }
            for (int i = 0; i < estatura.Length; i++)
            {
                Console.WriteLine("Estatura: "+estatura[i]);
                Console.WriteLine("Nombre: "+nombres[i]);
            }


        }
    }
}
   