using System;

namespace Solución_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma = 0;

            Console.WriteLine("Ingrese el primer numero ");

            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero ");

            num2 = int.Parse(Console.ReadLine());



            for (int i = num1; i <= num2; i++)

            {

                suma = suma + i;



            }

            Console.WriteLine("La suma de los 2 numeros es: " + suma);



           














        }
    }
}
