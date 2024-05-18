namespace Laboratorio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> lista = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    // No es primo :(
                    return false;
                }
            }
            // Es primo :)
            return true;
        }
        private void btnAgregarNumero_Click(object sender, EventArgs e)
        {
            lista.Add(int.Parse(txtNumero.Text));
            txtLista1.Clear();
            foreach (var item in lista)
            {
                txtLista1.AppendText(item.ToString() + Environment.NewLine);
            }
            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            var lista2 = new List<int>();

            foreach (var item in lista)
            {
                var p = EsPrimo(item);
                if (p)
                {
                    lista2.Add(item);
                }
            }

            txtLista2.Clear();
            foreach (var item in lista2)
            {
                txtLista2.AppendText(item.ToString() + Environment.NewLine);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
