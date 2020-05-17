/*
Instrucciones: añadiendo un extra al reto anterior ahora el usuario ingresará 3 números, sumarás los 2 primeros y el resultado será multiplicado por el tercero. Añade las consideraciones del punto decimal del reto anterior.
Ejemplo:

Datos de entrada:2, 3, 4
Resultado:20

*/
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
