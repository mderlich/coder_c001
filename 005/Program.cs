﻿namespace _005
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto producto = new Producto(01, "pañal", 3.45, 4.5, "Limpieza");

            if (producto.hayPrecioDeVenta())
            {
                Console.WriteLine("El producto esta a la venta");
            }
            else { 
                Console.WriteLine("El producto no fue publicado aun");
            }

            producto.categoria = "Limpieza";
            Console.WriteLine( producto.hayPrecioDeVenta());

        }
    }
}

