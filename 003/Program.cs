string cadenaNula = null;
string cadenaVacia = string.Empty;
string cadenaSaludo = "hola!";


Console.WriteLine(cadenaSaludo + cadenaNula + cadenaVacia); ;

if (cadenaNula == cadenaVacia)
{
    Console.WriteLine("Las cadenas son iguales"); ;

}
else {
    Console.WriteLine("Las cadenas NO son iguales"); ;

}

Console.WriteLine("Longitud... " + cadenaVacia.Length );
Console.WriteLine("Longitud... " + cadenaSaludo.Length);

// --------------------
string mensaje = "VOY a DEsarrollar en C#";

Console.WriteLine(mensaje );
Console.WriteLine(mensaje.ToLower() );
Console.WriteLine(mensaje.ToUpper());

// --------------------

int numeroEntero = 22;
double numeroConDecimales = 1.22;
bool booleano  = true;

Console.WriteLine(numeroEntero.ToString() + numeroConDecimales.ToString() + booleano.ToString());


// --------------------
string cadena1 = "soy cadena ";
string cadena2 = "soy cadena";

if (cadena1.Equals(cadena2))
{
    Console.WriteLine("son iguales");

}
else {
    Console.WriteLine("NO son iguales");

}


if (cadena1.Contains(cadena2))
{
    Console.WriteLine("SI la contiene");

}
else
{
    Console.WriteLine("NO la contiene");

}


// --------------------

Console.WriteLine("Ingrese un numero...");

string cadena = Console.ReadLine();
double cte = 0.5;

double numeroConvertido;
double sumaConDouble;

if (String.IsNullOrEmpty(cadena))
{
    Console.WriteLine("no se puede parsear...");
}
else {
    numeroConvertido = double.Parse(cadena);
    sumaConDouble = numeroConvertido + cte;
    Console.WriteLine("resultado... " + sumaConDouble);

}

// BUCLES *********************

int numero = 0;
while (numero < 100) {
    Console.WriteLine(numero);
    numero++;
}
