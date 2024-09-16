using System;
using System.Linq;
using System.Collections.Generic;

public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public string Categoria { get; set; }
}

class Programa
{
    public static void Main()
    {
        
        List<Producto> productos = new List<Producto>
        {
            new Producto { Nombre = "Laptop", Precio = 1200m, Categoria = "Electrónica" },
            new Producto { Nombre = "Auriculares", Precio = 150m, Categoria = "Electrónica" },
            new Producto { Nombre = "Mesa", Precio = 200m, Categoria = "Muebles" },
            new Producto { Nombre = "Silla", Precio = 80m, Categoria = "Muebles" },
            new Producto { Nombre = "Televisor", Precio = 600m, Categoria = "Electrónica" },
            new Producto { Nombre = "Escritorio", Precio = 250m, Categoria = "Muebles" }
        };

       
        var preciosPromedioPorCategoria = from producto in productos
                                          group producto by producto.Categoria into grupo
                                          select new
                                          {
                                              Categoria = grupo.Key,
                                              PrecioPromedio = grupo.Average(p => p.Precio)
                                          };

        
        Console.WriteLine("Precio promedio por categoría:");
        foreach (var resultado in preciosPromedioPorCategoria)
        {
            Console.WriteLine($"Categoría: {resultado.Categoria}, Precio Promedio: {resultado.PrecioPromedio:C}");
        }
    }
}
