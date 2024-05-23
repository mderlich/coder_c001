
// **********************************
// CATEOGORIA

string categoria;
Console.WriteLine("Ingrese categoria A / B / C / D");
categoria = Console.ReadLine();

switch (categoria)
{
    case "A":
    case "D":
        Console.WriteLine("Empleado Administrativo");
        break;

    case "B":
        Console.WriteLine("Empleado Profesional");
        break;
    case "C":
        Console.WriteLine("Empleado Maestranza");
        break;
    default:
        Console.WriteLine("Sin categoria");
        break;
}

// **********************************
// TURNO
string comision;

Console.WriteLine("Bienvenidos a la universidad Coderhouse");
Console.WriteLine("Ingrese su comision A / B / C ");

comision = Console.ReadLine();

switch (comision)
{
    case "A":
        Console.WriteLine("Turno mañana");
        break;
    case "B":
        Console.WriteLine("Turno tarde");
        break;
    case "C":
        Console.WriteLine("Turno noche");
        break;
    default:
        Console.WriteLine("Sin turno fijo");
        break;
}

// **********************************
// CALIFICACION

int calificacion;

Console.WriteLine("Ingrese su nota");

calificacion = Convert.ToInt32(Console.ReadLine());

if (calificacion >= 0 && calificacion < 4)
{
    Console.WriteLine("Recursa");
}
else if (calificacion >= 4 && calificacion <= 7)
{
    Console.WriteLine("Aprobo cursada");
}
else if (calificacion > 7 && calificacion <= 10)
{
    Console.WriteLine("Promociono cursada");
}
else {
    Console.WriteLine("Calificar solo del 0 al 10");

}