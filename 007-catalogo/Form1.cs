namespace _007_catalogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, Dictionary<string, double>> CatalogoPetShop = new Dictionary<string, Dictionary<string, double>>();

            // Alimento para gatos
            CatalogoPetShop.Add(
                "Alimento para gatos",
                new Dictionary<string, double> {
                    { "Cat Chow", 900 },
                    { "Wiskas", 1200 },
                    { "Pedigres", 1800 },

                }
            );

            // Alimento para perros
            CatalogoPetShop.Add(
                "Alimento para perros",
                new Dictionary<string, double> {
                    { "Dow Chow", 1500 },
                    { "Pro Plan", 2500 },
                    { "Pedigres", 5800 },

                }
            );

            lstAlimentos.Items.Add("Seccion\t\t\t\t\tProducto\t\tPrecio");
            foreach (KeyValuePair<string, Dictionary<string, double>> seccion in CatalogoPetShop)
            {
                lstAlimentos.Items.Add(seccion.Key);

                foreach (KeyValuePair<string, double> productoPrecio in seccion.Value)
                {
                    lstAlimentos.Items.Add("\t\t\t\t\t" + productoPrecio.Key + "\t\t" + productoPrecio.Value);
                }
            }
        }
    }
}
