/*
Instrucciones: pide al usuario que indique su nombre y su edad. Como mensaje de salida 
le indicarás que edad tuvo el año pasado y cuantos años tendrá el siguiente año.

Ejemplo: [nombre] el año pasado tenías X años y el próximo año cumplirás Y años.
*/
using System;

namespace edad
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad, pasado, futuro;
            Console.WriteLine("Digita tu nombre:");
            nombre=Console.ReadLine();
            Console.WriteLine("Digita tu edad:");
            edad=int.Parse(Console.ReadLine());
            pasado=edad-1;
            futuro=edad+1;
            Console.WriteLine(nombre + " el año pasado tenías " + pasado +" años y el próximo año cumplirás " + futuro +" años");

        }
    }
}
