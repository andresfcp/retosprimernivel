using System;

namespace suma
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1;
            float numero2;
            float total;
            Console.WriteLine("Digite el primer número:");
            numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el primer número:");
            numero2 = float.Parse(Console.ReadLine());
            total = numero1 + numero2;
            Console.WriteLine(numero1 + " + " + numero2 + "=" + total);

        }
    }
}
