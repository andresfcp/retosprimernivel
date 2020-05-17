/*

Instrucciones: otro clásico conocido, donde pedirás al usuario que ingrese
2 números y muestre en pantalla el resultado. Si quieres añadir más dificultad 
puedes utilizar números con punto decimal y especificar el número de decimales
después del punto.

Ejemplo: 2.5633 + 5.6883 = 8.25

*/
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
