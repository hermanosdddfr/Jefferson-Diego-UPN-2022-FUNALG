using System;

namespace Solución_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char caracter;
            caracter = 'a';
            caracter = 'e';
            caracter = 'i';
            caracter = 'o';
            caracter = 'u';
            do
            {
                Console.Write("Ingrese un numero seguido de ENTER: ");
                caracter = char.Parse(Console.ReadLine());
            }
            while (caracter != 'a' && caracter != 'e' && caracter != 'i' && caracter != 'o' && caracter != 'u');


        }
    }
}
