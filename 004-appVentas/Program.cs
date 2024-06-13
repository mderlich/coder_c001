

int precioCodigo(string codigo)
{
    int precio = 0;

    switch (codigo)
    {
        case "DES":
            precio = 200; 
            break;
        case "JP":
            precio = 300;
            break;
        case "DET":
            precio = 250;
            break;
        default:
            precio = 0;
            break;
    }
    return precio;
}

void venta()
{
    string codigo = "";
    int cantProductos;
    int montoAPagar = 0;
    string confirmacion = "";


    Console.WriteLine("Bienvenido! estos son nuestros productos...");
    Console.WriteLine("Codigo       Descripcion     Precio");
    Console.WriteLine("------       -----------     ------");
    Console.WriteLine("DES          Desodorante     200");
    Console.WriteLine("JP           Jabon en Polvo  300");
    Console.WriteLine("DET          Detergente      250");
    // -----------------

    // cargando productos...
    while (codigo != "FIN")
    {
        // producto...
        Console.WriteLine("Ingrese codigo que desee comprar...");
        codigo = Console.ReadLine().ToUpper();

        if (codigo == "FIN")
        {
            break;
        }

        // precio...
        int precio = precioCodigo(codigo);

        // cantidad...
        Console.WriteLine("Ingrese cantidad que desee comprar...");
        cantProductos = int.Parse(Console.ReadLine());
        montoAPagar += cantProductos * precio;

    }

    // termino la carga...
    Console.WriteLine("El total a pagar es...{0}", montoAPagar);
    Console.WriteLine("¿Desea realizar la compra? SI/NO");
    confirmacion = Console.ReadLine().ToUpper();
    if (confirmacion == "SI")
    {
        Console.WriteLine("Gracias por la compra!!");

    }



}






venta();