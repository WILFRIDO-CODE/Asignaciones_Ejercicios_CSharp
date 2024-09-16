using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Programa
{
    
    public static async Task DescargarArchivoAsync(string nombreArchivo, int tiempoDescarga)
    {
        Console.WriteLine($"Descargando {nombreArchivo}...");
        await Task.Delay(tiempoDescarga);  
        Console.WriteLine($"{nombreArchivo} descargado.");
    }

    public static async Task Main()
    {
        
        Stopwatch stopwatch = Stopwatch.StartNew();

         
        Task tarea1 = DescargarArchivoAsync("Archivo1.txt", 3000);  
        Task tarea2 = DescargarArchivoAsync("Archivo2.txt", 2000);  
        Task tarea3 = DescargarArchivoAsync("Archivo3.txt", 1000); 

        
        await Task.WhenAll(tarea1, tarea2, tarea3);

       
        stopwatch.Stop();

         
        Console.WriteLine($"Tiempo total de descarga: {stopwatch.Elapsed.TotalSeconds} segundos");
    }
}
