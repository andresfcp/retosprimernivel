/*
Instrucciones: seguro has visto que en Platzi hay más de 600 cursos 
¿puedes mostrar a que categorías corresponden en una sola línea de código?


Debe mostrarse así:

Platzi cuenta con cursos de:
[categoría1]
[categoría2]
[categoría3]
[categoría4]
[categoría5]
[categoría6]
*/


using System;
using System.Collections.Generic;

namespace categoriasplatzi
{
    class Program
    {
        static void Main(string[] args)
        {
            var categorias =new List<string>{"Desarrollo e Ingenieria","Diseño y UX",
             "Marketing","Negocios y emprendimiento","Producción Audiovisual",
             "Crecimiento Profesional"};
            Console.WriteLine("Platzi cuenta con cursos de:");
            Console.WriteLine("============================");
            Console.WriteLine("");
            
            foreach (string categoria in categorias)
            {
                Console.WriteLine(categoria);
            }

        }
    }
}
