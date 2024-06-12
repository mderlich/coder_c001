
int sumar(int num1, int num2)
{
    return num1 + num2;
}

Console.WriteLine("Ingrese numeros a sumar...");
Console.WriteLine("**************************");

Console.WriteLine("Ingrese primer numero...");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese segundo numero...");
int num2 = int.Parse(Console.ReadLine());

int total = sumar(num1, num2);
Console.WriteLine("Total de suma... {0}", total);
