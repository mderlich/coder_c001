// See https://aka.ms/new-console-template for more information

string mensaje = "Bienvenidos!";

Console.WriteLine(mensaje);

string nombre;
nombre = "Homero";
Console.WriteLine("Mi nombre es " + nombre);

string apellido = "Simpson";
Console.WriteLine("Mi apellido es " + apellido);

const int dni = 123123123;
Console.WriteLine("Mi DNI es " + dni);

string msgLinea = $"mi nombre es {nombre} \"El profe\" {apellido}";
Console.WriteLine(msgLinea);

// ******************
// ejemplo 2
int num1;
int num2;

Console.WriteLine("Ingrese el 1er numero");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el 2do numero");
num2 = Convert.ToInt32(Console.ReadLine());

int total = num1 + num2;
Console.WriteLine("El total de la suma es " + total);

Console.ReadKey();
