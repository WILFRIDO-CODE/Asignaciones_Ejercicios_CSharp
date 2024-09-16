 
using System;
using System.Threading.Tasks;

class Programa
{
     
    public static async Task<int> OperacionLargaAsync()
    {
         
        await Task.Delay(2000);

         
        Random random = new Random();
        return random.Next(1, 101);  
    }

    public static async Task Main()
    {
         Task<int> tarea1 = OperacionLargaAsync();
        Task<int> tarea2 = OperacionLargaAsync();
 
        int resultado1 = await tarea1;
        int resultado2 = await tarea2;

         
        Console.WriteLine($"Resultado de la primera operación: {resultado1}");
        Console.WriteLine($"Resultado de la segunda operación: {resultado2}");
    }
}

