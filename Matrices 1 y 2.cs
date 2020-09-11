using System;

namespace Matrices_1_y_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "O", "X" };
            int n = 10;
            int m = 15;

            double xs = 0;
            double os = 0;
            double slash = 0;

            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";

                }

            }

            //ENTRADA
            Console.WriteLine("ENTRADA: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }

                Console.Write("|\n");
            }

            //PROCESO
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1) - 2; j++)
                {
                    if (tablero[i, j] == tablero[i, j + 1] && tablero[i, j + 1] == tablero[i, j + 2])
                    {
                        if (tablero[i, j] == "X")
                        {
                            salida[i, j] = "1";
                            salida[i, j + 1] = "1";
                            salida[i, j + 2] = "1";
                        }

                        if (tablero[i, j] == "O")
                        {
                            salida[i, j] = "2";
                            salida[i, j + 1] = "2";
                            salida[i, j + 2] = "2";
                        }
                    }
                }
            }


            for (int i = 0; i < tablero.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    if (tablero[i, j] == tablero[i + 1, j] && tablero[i + 1, j] == tablero[i + 2, j])
                    {
                        if (tablero[i, j] == "X")
                        {
                            salida[i, j] = "1";
                            salida[i + 1, j] = "1";
                            salida[i + 2, j] = "1";
                        }

                        if (tablero[i, j] == "O")
                        {
                            salida[i, j] = "2";
                            salida[i + 1, j] = "2";
                            salida[i + 2, j] = "2";
                        }
                    }
                }
            }

            //porcentaje
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    if (tablero[i, j] == "X")
                    {
                        xs++;
                    }

                    if (tablero[i, j] == "O")
                    {
                        os++;
                    }

                    if (tablero[i, j] == "-")
                    {
                        slash++;
                    }
                }
            }
            
            double total = os + slash + xs;
            double porcentajeXs = (xs / total) * 100;
            double porcentajeOs = (os / total) * 100;
            double porcentajeSlash = (slash / total) * 100;

            //SALIDA
            Console.WriteLine("\nSALIDA: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + salida[i, j]);
                }
                Console.Write("|\n");
            }
            Console.Write("|\n");

            Console.WriteLine("Porcentaje de X:  " + porcentajeXs + "%");
            Console.WriteLine("Porcentaje de O:  " + porcentajeOs + "%");
            Console.WriteLine("Porcentaje de -:  " + porcentajeSlash + "%");
        }
    }
}
