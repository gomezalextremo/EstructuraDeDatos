namespace GestionArquitectos
{
    public partial class Form1 : Form
    {
        private List<Arquitecto> arquitectos = new List<Arquitecto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string nombres = txtNombres.Text;
                string condicionContrato = cmbCondicionContrato.SelectedItem.ToString();
                string especialidad = cmbEspecialidad.SelectedItem.ToString();
                string tipoActividad = cmbTipoActividad.SelectedItem.ToString();
                string tipoAfiliacion = cmbTipoAfiliacion.SelectedItem.ToString();

                Arquitecto arquitecto = new Arquitecto(codigo, nombres, condicionContrato, especialidad, tipoActividad, tipoAfiliacion);
                arquitectos.Add(arquitecto);

                MessageBox.Show("Arquitecto agregado correctamente");
                LimpiarFormulario();
            }
