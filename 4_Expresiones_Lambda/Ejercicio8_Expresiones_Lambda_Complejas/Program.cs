using System;
using System.Collections.Generic;
using System.Linq;

public class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Estudiante(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}
class Program
{
    static void Main()
    {

        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante("Ana", 20),
            new Estudiante("Luis", 17),
            new Estudiante("Marta", 22),
            new Estudiante("Carlos", 19),
            new Estudiante("Laura", 16)
        };

        
        var mayoresDeEdad = estudiantes.Where(e => e.Edad > 18);

       
        Console.WriteLine("Estudiantes mayores de 18 años:");
        foreach (var estudiante in mayoresDeEdad)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}");
        }
    }
}