namespace PRACTICA5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubcadena_Click(object sender, EventArgs e)
        {
            

        }

        private void btnMayusculas_Click(object sender, EventArgs e)
        {
            String cadena = txtPrincipal.Text.ToUpper();
            txtResultado.Text = cadena;


        }

        private void btnMinusculas_Click(object sender, EventArgs e)
        {
            String cadena = txtPrincipal.Text.ToLower();    
            txtResultado.Text = cadena;
        }
    }
}

//determinar la cantidad de dinero que recibira un trabajdor por concepto de las horas extras trabajadas
