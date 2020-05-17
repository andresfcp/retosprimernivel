/*
Instrucciones: vas con tus amigos a tu restaurante favorito y acuerdan dividir la cuenta. 
Para facilitar las cosa pedirás al usuario que indique el total a pagar, entre cuantas 
personas se dvidirá la cuenta, porcentaje de propina a incluir, un porcentaje de impuestos, 
total a pagar incluyendo propina más impuestos y el total a pagar por cada persona.
*/
using System;

namespace splitbill
{
    class Program
    {
        static void Main(string[] args)
        {
            float cuenta, porcentajeImpuestos, impuestos, porcentajePropina, propina, comensales, total, totalPersona;
            Console.WriteLine("Monto de la cuenta");
            cuenta=float.Parse(Console.ReadLine());
            Console.WriteLine("Número de comensales?");
            comensales=float.Parse(Console.ReadLine());
            Console.WriteLine("Porcentaje de impuestos");
            porcentajeImpuestos=float.Parse(Console.ReadLine());
            Console.WriteLine("Porcentaje de propina");
            porcentajePropina=float.Parse(Console.ReadLine());
            impuestos=((cuenta*porcentajeImpuestos)/100);
            propina=(cuenta*porcentajePropina)/100;
            total=cuenta + propina + impuestos;
            totalPersona=total/comensales;
            Console.WriteLine("___________________________");
            Console.WriteLine("Impuestos $"+impuestos);
            Console.WriteLine("Popina $"+propina);
            Console.WriteLine("Total a Pagar $"+total);
            
            Console.WriteLine("Total a Pagar por persona $"+totalPersona);
            
        }
    }
}
