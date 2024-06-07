namespace PRACTICA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Permite que el formulario capture las teclas presionadas antes que los controles
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick(); // Ejecuta el click del botón cuando se presiona Enter
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            for (int i = 1; i <=10; i++)
            {
                liTabla.Items.Add(numero + "x" +i + "=" + (numero*i));
            }
        }
    }
}
