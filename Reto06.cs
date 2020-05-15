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
