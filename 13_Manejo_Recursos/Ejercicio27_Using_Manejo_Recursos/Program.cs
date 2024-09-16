using System;

class Programa
{
    public static void Main()
    {
        
        using (Recurso recurso = new Recurso())
        {
            
            Console.WriteLine("Usando el recurso dentro del bloque using...");

        } 

        
        Console.WriteLine("Recurso fuera del bloque using.");
    }
}


public class Recurso : IDisposable
{
    
    private bool _disponible = false;

     
    public void Dispose()
    {
         
        Dispose(true);
        
        GC.SuppressFinalize(this);
    }

     
    protected virtual void Dispose(bool disposing)
    {
         
        if (_disponible)
        {
            return;
        }

         
        _disponible = true;
         
        Console.WriteLine("El recurso ha sido liberado.");
    }

     
    ~Recurso()
    {
        Dispose(false);
    }
}
