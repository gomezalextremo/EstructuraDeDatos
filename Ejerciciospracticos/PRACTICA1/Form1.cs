namespace PRACTICA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            while (numero > 0)
            {
                liLista.Items.Add("Mensaje del while");
                numero--;
            }
        }
    }
}
