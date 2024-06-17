namespace _007_wform
{
    public partial class Form1 : Form
    {

        Dictionary<string, string> ciudadesxPaises = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            // RAZAS DE PERROS

            // Array Inicializado
            string[] razasDePerrosArray = {
                "Policia",
                "Pequines",
                "Caniche",
                "Chihuahua",
                "Shitzu",
            };

            for (int i = 0; i < razasDePerrosArray.Length; i++)
            {
                lstRazasDePerros.Items.Add(razasDePerrosArray[i]);
            }


            // Ciudades por Paises
            ciudadesxPaises.Add("Buenos Aires", "Argentina");
            ciudadesxPaises.Add("Madrid", "España");
            ciudadesxPaises.Add("Paris", "Francia");
            ciudadesxPaises.Add("Roma", "Italia");
            ciudadesxPaises.Add("Londres", "Inglaterra");
            ciudadesxPaises.Add("Lima", "Bolivia");
            ciudadesxPaises.Add("Bogota", "Colombia");




        }
    }
}
