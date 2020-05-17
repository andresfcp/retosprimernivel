/*Instrucciones: pide al usuario ingresar un número mayor a 1000 y otro menor a 100. Indica de una forma 
sencilla de entender al usuario cuantas veces cabe el número menor a 100 en el número mayor a 1000
*/
using System;

namespace reto11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1,numero2, resultado;
            Console.WriteLine("Ingrese un número mayor de 1000:");
            numero1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número menor de 100:");
            numero2=int.Parse(Console.ReadLine());
            resultado=numero1/numero2;
            Console.WriteLine("el número "+ numero2 +" cabe "+ resultado + " veces en "+ numero1);


        }
    }
}
