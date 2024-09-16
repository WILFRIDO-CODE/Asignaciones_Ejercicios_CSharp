// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Ingrese cualquier numero");
Console.WriteLine("--------------------------");
Console.WriteLine();

int numero = int.Parse(Console.ReadLine());

if (numero %2 == 0)
{
    Console.WriteLine("Es par");   
}
else if (numero %2 != 0)
{
    Console.WriteLine("Es impar");
}
