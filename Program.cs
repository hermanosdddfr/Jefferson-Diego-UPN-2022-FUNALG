using System;

namespace Solución_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Ingrese un numero");
                num=int.Parse(Console.ReadLine());
            } while (num < 1 || num > 5);
        } 
    }
}
