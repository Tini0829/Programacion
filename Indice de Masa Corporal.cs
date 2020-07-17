using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu peso en Kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu altura en centimetros: ");
            double estatura = double.Parse(Console.ReadLine());
            double estaturam = estatura * (1.0 / 100);

            double imc = peso / Math.Pow(estaturam, 2);
            double imc1 = Math.Ceiling(imc);
            Console.WriteLine("TU INDICE DE MASA CORPORAL ES:  " + imc1);

            if (imc <= 18.5)
            {
                Console.WriteLine("¡Estas por debajo del peso que deberías!");
            }
            else if (18.5 < imc && imc <= 24.9)
            {
                Console.WriteLine("¡Tu peso es normal, felicitaciones!");
            }
            else if (24.9 < imc && imc <= 29.9 )
            {
                Console.WriteLine("¡Estas por encima del peso que deberías!");
            }
            else
            {
                Console.WriteLine("¡Tienes sobrepeso, deberias ir al doctor!");
            }
        }
    }
}
