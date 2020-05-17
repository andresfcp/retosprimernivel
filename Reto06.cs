/*
Instrucciones: llegaste a una fiesta con X cantidad de rebanadas de pizza 
(indicadas por el usuario), después de un rato se consumió Y cantidad de 
rebanadas y quedan Z. Fácil ¿cierto?
El reto está en que expreses lo que sucede es una forma comprensible para 
cualquier persona, imprescindible pensar en tus usuarios 😉
*/
using System;

namespace pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            int rodajasInicio, rodajasFin, total;
            Console.WriteLine("Cuántas rodajas tiene la piza? ");
            rodajasInicio=int.Parse(Console.ReadLine());
            Console.WriteLine("Cuántas rodajas se ha comido? ");
            rodajasFin=int.Parse(Console.ReadLine());
            total=rodajasInicio-rodajasFin;
            Console.WriteLine("restan "+ total +" rodajas.");

        }
    }
}
