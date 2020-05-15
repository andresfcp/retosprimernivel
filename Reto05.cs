using System;

namespace reto05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, resultado;
            Console.WriteLine("Ingrese un número:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número:");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número:");
            numero3 = int.Parse(Console.ReadLine());
            resultado=(numero1+numero2)*numero3;
            Console.WriteLine("Resultado: "+ resultado);

        }
    }
}
