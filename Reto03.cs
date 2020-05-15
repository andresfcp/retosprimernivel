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
