namespace _005_app2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mayorEdad;
            bool gmail;
            string nuevaDireccion;


            Usuario usuario_1 = new Usuario("Juan", "Bida", 2323322, "bida@gmail.com", 44, "Cabildo 22");
            Usuario usuario_2 = new Usuario("Luis", "Lopez", 4323322, "bida@mail.com", 17, "Cabildo 10");

            mayorEdad = usuario_1.EsMayorDeEdad();
            Console.WriteLine("Usuario 1 es mayor de edad?:... " + mayorEdad);

            mayorEdad = usuario_2.EsMayorDeEdad();
            Console.WriteLine("Usuario 2 es mayor de edad?:... " + mayorEdad);

            // -----------------------

            gmail = usuario_1.EsGmail();
            Console.WriteLine("Usuario 1 tiene @gmail?:... " + gmail);

            gmail = usuario_2.EsGmail();
            Console.WriteLine("Usuario 2 tiene @gmail?:... " + gmail);

            // -----------------------

            nuevaDireccion = usuario_1.CambiarDireccion("Congreso 230");
            Console.WriteLine("Usuario 1 tiene @gmail?:... " + nuevaDireccion);

            nuevaDireccion = usuario_2.CambiarDireccion("Avellaneda 233");
            Console.WriteLine("Usuario 2 tiene @gmail?:... " + nuevaDireccion);

        }
    }
}
