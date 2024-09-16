using System;

class Programa
{
    public static void Main()
    {
        
        dynamic objeto = null;
 
        objeto = 42;
        Console.WriteLine($"Valor entero: {objeto}");
       
        
        objeto = "KLK!";
        Console.WriteLine($"Cadena: {objeto}");
        
        Console.WriteLine($"Cadena en mayúsculas: {objeto.ToUpper()}");

         
        objeto = new Persona { Nombre = "Wilfrido", Edad = 23 };
        Console.WriteLine($"Objeto personalizado: {objeto.Nombre}, {objeto.Edad} años");
         
        objeto.Saludar();
    }
}

 
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
     
    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
    }
}
