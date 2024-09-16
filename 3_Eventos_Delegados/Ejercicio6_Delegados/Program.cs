using System;


public delegate int OperacionAritmetica(int numero1, int numero2);

class program
{
    public static int Sumar(int numero1, int numero2)
    {
        return numero1 + numero2;
    }
   
    public static int Multiplicacion (int numero1, int numero2)
    {
        return numero1 * numero2;
    }


    static void Main()
    {
        OperacionAritmetica operacion = new OperacionAritmetica(Sumar);

        OperacionAritmetica operacion2 = new OperacionAritmetica(Multiplicacion);

        int Sumas = operacion(1, 4);
        Console.WriteLine("Resultado de la suma: " + Sumas);
        Console.WriteLine();
        int Multiplicar = operacion2(4, 4);
        Console.WriteLine("Resultados de la multiplicacion: " + Multiplicar) ;
    }

}

