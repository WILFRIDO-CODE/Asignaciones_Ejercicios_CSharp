using System;

class Programa
{
    public static void Main()
    {
       
        int? edad = null;

       
        Console.Write("Introduce la edad: ");
        string entrada = Console.ReadLine();

       
        if (string.IsNullOrWhiteSpace(entrada))
        {
           
            edad = null;
        }
        else
        {
          
            if (int.TryParse(entrada, out int edadTemp))
            {
                edad = edadTemp;
            }
            else
            {
                
                Console.WriteLine("La entrada no es un número válido.");
                return;
            }
        }

        
        if (edad.HasValue)
        {
          
            Console.WriteLine($"La edad introducida es: {edad.Value}");
        }
        else
        {
            
            Console.WriteLine("No se ha introducido una edad.");
        }
    }
}
