/*
Instrucciones: escribe un programa al que le indiques una cantidad de días y como 
resultado deberá mostrar cuantas horas, minutos y segundos hay en dicha cantidad de días.
*/
using System;

namespace calculodias
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias, horas, minutos, segundos;
            Console.WriteLine("Ingrese un número de días:");
            dias=int.Parse(Console.ReadLine());
            horas=dias*24;
            minutos=horas*60;
            segundos=minutos*60;
             
            Console.WriteLine(dias + " días tiene "+horas+ " horas, o " + minutos +" minutos, o "+ segundos+ " segundos.");
        }
    }
}
