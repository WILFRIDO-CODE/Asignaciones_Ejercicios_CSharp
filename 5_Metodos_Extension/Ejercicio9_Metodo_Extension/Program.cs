using System;

public static class ExtensionesDeCadena
{
    public static int ContarVocales(this string texto, char vocal)
    {
        if (string.IsNullOrEmpty(texto))
        {
            throw new ArgumentException("El texto no puede ser nulo o vacío.", nameof(texto));
        }

        if (!"aeiouAEIOU".Contains(vocal))
        {
            throw new ArgumentException("El carácter proporcionado no es una vocal.", nameof(vocal));
        }

        int cantidad = 0;
        foreach (char caracter in texto)
        {
            if (caracter == vocal)
            {
                cantidad++;
            }
        }

        return cantidad;
    }
}

public class Programa
{
    public static void Main()
    {
        Console.Write("Ingrese palabras: ");
       
        string texto = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Cual vocal desea contar? ");
        char vocal = char.Parse(Console.ReadLine());

        int cantidad = texto.ContarVocales(vocal);
        Console.WriteLine($"La vocal '{vocal}' aparece {cantidad} veces en el texto.");
    }
}
