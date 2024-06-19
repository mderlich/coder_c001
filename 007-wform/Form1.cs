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


            // Ciudades por Pais
            ciudadesxPaises.Add("Buenos Aires", "Argentina");
            ciudadesxPaises.Add("Madrid", "España");
            ciudadesxPaises.Add("Paris", "Francia");
            ciudadesxPaises.Add("Roma", "Italia");
            ciudadesxPaises.Add("Londres", "Inglaterra");
            ciudadesxPaises.Add("Lima", "Bolivia");
            ciudadesxPaises.Add("Bogota", "Colombia");

            foreach (KeyValuePair<string, string> ciudad in ciudadesxPaises)
            {
                lstCiudadesPais.Items.Add(ciudad.Key + " - " + ciudad.Value);

            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstCiudadesPais.Items.Clear();
            ciudadesxPaises.Clear();
            MessageBox.Show("Se limpio contenido del diccionario");

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ciudadesxPaises["Londres"] = "Madrid";

            lstCiudadesPais.Items.Clear();

            foreach (KeyValuePair<string, string> ciudad in ciudadesxPaises)
            {
                lstCiudadesPais.Items.Add(ciudad.Key + " - " + ciudad.Value);

            }
        }
    }
}
