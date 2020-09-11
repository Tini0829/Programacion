using System;

namespace Matrices_03_y_04
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            string[] valores = { "-", "-", "O", "X" };
            int n = 10;
            int m = 15;


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
            Matriz(tablero);

            Console.WriteLine("Ingrese la fila deseada (x): ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la columna deseada (y): ");
            int y = int.Parse(Console.ReadLine());


            if (tablero[x - 1, y - 1] == "-")
            {
                tablero[x - 1, y - 1] = "X";
                Matriz(tablero);
            }

            else
            {
                Console.WriteLine("La posición seleccionada: " + "(" + x + "," + y + ")" + "se encuentra ocupada.");
                Console.WriteLine("Debe seleccionar otra posición.");
            }
        }

        static void Matriz(string[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("|" + matriz[i, j]);
                }

                Console.Write("|\n");

            }

        }

    }
}

