
// FOR *********************
int cantidadDeNotas = 0;
double promedioNotas = 0;
double nota;
double sumaNotas = 0;

Console.WriteLine("Ingrese cantidad de notas a calcular");
cantidadDeNotas = int.Parse(Console.ReadLine());

for (int i = 1; i <= cantidadDeNotas; i++)
{
    Console.WriteLine("Ingrese la nota...");
    nota = double.Parse(Console.ReadLine());
    sumaNotas = sumaNotas + nota;
}

promedioNotas = sumaNotas / cantidadDeNotas;
Console.WriteLine("El promedio de nota de alumnos es... {0}", promedioNotas);

// ****************************************
Console.WriteLine("************************************");
Console.WriteLine("Ingrese un numero para clasificar");
Console.WriteLine("Para salir ingrese 0");

int numero;
numero = int.Parse(Console.ReadLine());

while (numero != 0)
{
    if (numero > 0)
    {
        Console.WriteLine("numero positivo");
    } else {
        Console.WriteLine("numero negativo");
    }

    Console.WriteLine("Ingrese un numero para clasificar");
    Console.WriteLine("Para salir ingrese 0");
    numero = int.Parse(Console.ReadLine());
}


// ****************************************
Console.WriteLine("************************************");
Console.WriteLine("Ingrese un numero tope, para calcular los multiplos");

int numeroTopeMultiplos;
numeroTopeMultiplos = int.Parse(Console.ReadLine());

Console.WriteLine("Los multiplos de 5 son...");

for (int i = 1; i <= numeroTopeMultiplos; i++)
{
    if (i % 5 == 0)
    {
        // write... no le hace salto de linea
        Console.Write(i + ", ");

    }
}