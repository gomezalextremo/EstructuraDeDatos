namespace PRACTICA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <=10 ; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    listBox1.Items.Add(i + "x" + j + "=" + (i*j));
                }

                listBox1.Items.Add("");
            }
        }
    }
}
