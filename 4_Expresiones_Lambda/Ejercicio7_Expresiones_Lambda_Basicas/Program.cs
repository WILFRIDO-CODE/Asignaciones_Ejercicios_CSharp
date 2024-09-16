using System;
using System.Collections.Generic;
using System.Linq;

class program
{
    static void Main()
    {
        List<int> Numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var numerospares = Numeros.Where(proceso => proceso  %2  == 0);

        Console.WriteLine("Numeros pares de la lista: ");

        foreach (var x in numerospares)

        {
            Console.WriteLine(x);
        }




    }
}