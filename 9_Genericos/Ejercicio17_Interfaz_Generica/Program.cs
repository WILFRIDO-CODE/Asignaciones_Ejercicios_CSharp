using System;
public interface IContenedor<T>
{
    void Agregar(T elemento);
    T Obtener();
}


public class Caja<T> : IContenedor<T>
{
    private T _contenido;

     
    public void Agregar(T elemento)
    {
        _contenido = elemento;
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
         
        IContenedor<int> cajaDeEnteros = new Caja<int>();
        cajaDeEnteros.Agregar(42);
        Console.WriteLine($"Contenido de la caja de enteros: {cajaDeEnteros.Obtener()}");
         
        IContenedor<string> cajaDeCadenas = new Caja<string>();
        cajaDeCadenas.Agregar("PERAS");
        Console.WriteLine($"Contenido de la caja de cadenas: {cajaDeCadenas.Obtener()}");

        
        IContenedor<Persona> cajaDePersonas = new Caja<Persona>();
        Persona persona = new Persona { Nombre = "FRANCISCO", Edad = 45 };
        cajaDePersonas.Agregar(persona);
        Persona contenidoPersona = cajaDePersonas.Obtener();
        Console.WriteLine($"Contenido de la caja de personas: {contenidoPersona.Nombre}, {contenidoPersona.Edad} años");
    }
}

 
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

