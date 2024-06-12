int intentos = 0;
string contrasena;
bool ingreso = true;

Console.WriteLine("Escriba la contraseña...");

while (ingreso)
{
    contrasena = Console.ReadLine();
    intentos++;
    if (contrasena.Equals("usSystem-2022"))
    {
        Console.WriteLine("Bienvenido a Coderhouse...");
        break;

    }
    else if (intentos >= 5)
    {
        Console.WriteLine("Contraseña incorrecta, agoto intentos...");
        break;
    }
    Console.WriteLine("Contraseña incorrecta, quedan {0} intentos...", intentos) ;


}