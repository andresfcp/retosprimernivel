/*
Instrucciones: hay 1.609344 km en una milla (mi). Escribe un programa en el que el usuario indique 
una cantidad de millas y muestre en pantalla el resultado convertido a kilómetros.
 */
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
