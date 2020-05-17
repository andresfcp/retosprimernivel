/*
Instrucciones: este es un clásico de clásicos, pero haremos un pequeño cambio. En lugar 
de solo imprimir un mensaje en pantalla, pedirás al usuario que digite un nombre y 
mostrarás en pantalla lo siguiente: Hola, [nombre]

*/
using System;

namespace hola_nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Digita tu nombre");
            String nombre;
            nombre = Console.ReadLine();
            Console.WriteLine("Hola,  " + nombre);
        }
    }
}
