using System;
using System.Collections.Generic;

namespace Data_structures
{
    class Program
    {
        static void Main(string[] args)
        {        //lista contenedora de elementos
                // Generics: <>
            List<string> movieNames = new List<string>();

            movieNames.Add("Pulp Fiction");
            movieNames.Add("Harry Potter");
            movieNames.Add("Pacific Rim");

            Console.WriteLine(movieNames.[1]);

        }
    }
}
