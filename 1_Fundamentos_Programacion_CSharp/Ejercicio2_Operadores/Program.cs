using System.ComponentModel.Design;

Console.WriteLine("Calculadora Simple");
Console.WriteLine("----------------------");
Console.WriteLine();

Console.Write("Que desea hacer? ");
string opcion = Console.ReadLine();

if (opcion == "Sumar")
{


    Console.Write("Ingrese el primer digito: ");
    int X = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el segundo digito: ");
    int Y = int.Parse(Console.ReadLine());

    int resultado = X + Y;
    Console.WriteLine();
    Console.WriteLine("El resultado de su suma es: " + resultado);

}
else if (opcion == "Restar")
{
    Console.Write("Ingrese el primer digito: ");
    int X = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el segundo digito: ");
    int Y = int.Parse(Console.ReadLine());

    int resultado = X - Y;
    Console.WriteLine();
    Console.WriteLine("El resultado de su resta es: " + resultado);

}

if  (opcion == "Multiplicar")
{
    Console.Write("Ingrese el primer digito: ");
    int X = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el segundo digito: ");
    int Y = int.Parse(Console.ReadLine());

    int resultado = X * Y;
    Console.WriteLine();
    Console.WriteLine("El resultado de su multiplicacion es: " + resultado);

}
else if(opcion == "Dividir")
{
    Console.Write("Ingrese el primer digito: ");
    int X = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el segundo digito: ");
    int Y = int.Parse(Console.ReadLine());

    int resultado = X / Y;
    Console.WriteLine();
    Console.WriteLine("El resultado de su division es: " + resultado);
  
    if ( Y == 0 )
    {
        Console.WriteLine("Error") ;
       

    }
}
