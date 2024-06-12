

bool validarContrasena(string contrasena)
{
    return contrasena.Equals("usSystem-2022");
}


string passOculto(string pass){
    char[] caracteres = pass.ToCharArray();
    for (int i = 0; i < caracteres.Length; i++)
    {
        caracteres[i] = '*';
    }
    string textoModificado = new string (caracteres);
    return textoModificado;
}

void validarIngreso()
{
    // ---------------------------

    int intentos = 0;
    string contrasena;
    bool ingreso = true;

    Console.WriteLine("Escriba la contraseña...");


    while (ingreso)
    {
        contrasena = Console.ReadLine();
        intentos++;
        if (validarContrasena(contrasena))
        {
            
            Console.WriteLine("Bienvenido a Coderhouse...");
            Console.WriteLine("Su contraseña es correcta {0}", passOculto(contrasena));
            break;

        }
        else if (intentos >= 5)
        {
            Console.WriteLine("Contraseña incorrecta, agoto intentos...");
            break;
        }
        int restoDeIntentos = 5 - intentos;
        Console.WriteLine("Contraseña incorrecta, quedan {0} intentos...", restoDeIntentos);


    }
    // ---------------------------
}


validarIngreso();