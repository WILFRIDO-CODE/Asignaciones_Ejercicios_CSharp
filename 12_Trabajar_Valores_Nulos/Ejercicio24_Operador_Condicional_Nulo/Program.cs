using System;

class Programa
{
    public static void Main()
    {
         
        Persona personaConApellidoNulo = new Persona { Apellido = null };

         
        Persona personaConApellido = new Persona { Apellido = "García" };

         
        string apellido1 = personaConApellidoNulo?.Apellido ?? "No disponible";
        string apellido2 = personaConApellido?.Apellido ?? "No disponible";

         
        Console.WriteLine($"Apellido de personaConApellidoNulo: {apellido1}");
        Console.WriteLine($"Apellido de personaConApellido: {apellido2}");
    }
}

 
public class Persona
{
    public string? Apellido { get; set; }  
}
