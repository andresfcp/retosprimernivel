/*
Instrucciones: Ahora que sabemos incluir nombres, podemos agregar más datos. 
Intentemos con un apellido para tener algo así: ``Hola, [nombre] [apellido]```
*/

using System;

namespace holanombreapellido
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            String apellido;
            Console.WriteLine("Hola Digita tu nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Digita tu apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Hola,  " + nombre + " "+ apellido);
        }
        
    }
}
