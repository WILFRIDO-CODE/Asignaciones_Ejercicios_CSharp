using System;

public class Caja<T>
{
    private T _contenido;

   
    public void Añadir(T contenido)
    {
        _contenido = contenido;
    }
 
    public T Obtener()
    {
        return _contenido;
    }
}

class Programa
{
    public static void Main()
    {
         
        Caja<int> cajaDeEnteros = new Caja<int>();
        cajaDeEnteros.Añadir(42);
        Console.WriteLine($"Contenido de la caja de enteros: {cajaDeEnteros.Obtener()}");
 
        Caja<string> cajaDeCadenas = new Caja<string>();
        cajaDeCadenas.Añadir("MANZABAS");
        Console.WriteLine($"Contenido de la caja de cadenas: {cajaDeCadenas.Obtener()}");

         
        Caja<Persona> cajaDePersonas = new Caja<Persona>();
        Persona persona = new Persona { Nombre = "Ana", Edad = 25 };
        cajaDePersonas.Añadir(persona);
        Persona contenidoPersona = cajaDePersonas.Obtener();
        Console.WriteLine($"Contenido de la caja de personas: {contenidoPersona.Nombre}, {contenidoPersona.Edad} años");
    }
}
 
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}
