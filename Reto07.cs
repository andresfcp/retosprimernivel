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
