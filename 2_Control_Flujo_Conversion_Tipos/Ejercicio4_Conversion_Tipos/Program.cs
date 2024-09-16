// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese numero decimal: ");

Console.WriteLine();

decimal x = decimal.Parse(Console.ReadLine());
int numeroE = (int)x;
Console.WriteLine();
Console.WriteLine("Su conversion: " + numeroE);
Console.WriteLine();

Console.WriteLine("Ingrese numero entero");

int y = int.Parse(Console.ReadLine());
decimal numeroD = Convert.ToDecimal(y);
Console.WriteLine();
Console.WriteLine("Su conversion: " + numeroD);
