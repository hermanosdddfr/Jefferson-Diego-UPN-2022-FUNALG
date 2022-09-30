using System;

namespace Solución_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, suma = 0;

            Console.WriteLine("ESCRIBA UN NUMERO: ");

            num = int.Parse(Console.ReadLine());



            for (int i = 1; i <= num; i = i + 2)

            {

                suma = suma + i;



            }

            Console.WriteLine("La suma de numeros impares es : " + suma);





        }
    }
}
