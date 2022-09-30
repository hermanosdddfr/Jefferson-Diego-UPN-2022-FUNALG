using System;

namespace Solución_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do

            {

                Console.Write("INGRESE UN NUMERO SEGUID0 DE ENTER: ");

                numero = int.Parse(Console.ReadLine());



            }

            while (numero <= 100);

            Console.Write("Error!!! Numero fuera de rango: ");





        }
    }
}
