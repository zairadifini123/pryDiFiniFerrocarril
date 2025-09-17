namespace pryDiFiniFerrocarril
{
    public partial class FrmFerrocaril : Form
    {
        decimal Kilometro = 5m;
        decimal PrecioIda;
        decimal Distancia;    
        int Dia;             
        decimal PrecioFinal;
        decimal PrecioTotal;
        decimal TotalRecorrer;
        public FrmFerrocaril()
        {
            InitializeComponent();
        }

        private void FrmFerrocaril_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 30; i++)
            {
                dudDias.Items.Add(i);
            }

            // Opcional: que arranque mostrando el primer valor
            dudDias.SelectedIndex = 0;

            PrecioIda = 0m;
            PrecioTotal = 0m;
            TotalRecorrer = 0m;
            PrecioFinal = 0m;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Distancia = Convert.ToDecimal(txtDistancia.Text);
            Dia = Convert.ToInt32(dudDias.SelectedItem);


            PrecioIda = Kilometro * Distancia;
            PrecioTotal = PrecioIda * 2;
            PrecioFinal = PrecioTotal; 

            if (Dia >= 7 && Distancia >= 100)
            {
                PrecioFinal = PrecioTotal * 0.50m; 
            }

            lblResultado.Text = "Precio Final: $" + PrecioFinal.ToString("0.00");


        }
    }
}
