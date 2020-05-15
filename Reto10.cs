using System;

namespace millasakilometros
{
    class Program
    {
        static void Main(string[] args)
        {
            double millas, km;

            Console.WriteLine("Ingrese el numero de Millas:");
            millas=float.Parse(Console.ReadLine());
            km = millas * 1.609344;
            Console.WriteLine(millas + " millas equivalen a "+ km + " kilómetros");
        }
            
    }
}
