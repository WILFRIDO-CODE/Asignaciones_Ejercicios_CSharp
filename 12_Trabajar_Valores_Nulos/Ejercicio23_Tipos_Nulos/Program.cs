using System;

class Programa
{
    public static void Main()
    {
         
        int? numero = null;

         
        int valorPorDefecto = numero ?? 10;

         
        Console.WriteLine($"El valor es: {valorPorDefecto}");
    }
}

