using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombres.Text) ||
            cmbCondicionContrato.SelectedIndex == -1 || cmbEspecialidad.SelectedIndex == -1 ||
            cmbTipoActividad.SelectedIndex == -1 || cmbTipoAfiliacion.SelectedIndex == -1)
        {
            MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            int codigo = int.Parse(txtCodigo.Text);
            string nombres = txtNombres.Text;
            CondicionContrato condicionContrato = (CondicionContrato)cmbCondicionContrato.SelectedIndex;
            Especialidad especialidad = (Especialidad)cmbEspecialidad.SelectedIndex;
            TipoActividad tipoActividad = (TipoActividad)cmbTipoActividad.SelectedIndex;
            TipoAfiliacion tipoAfiliacion = (TipoAfiliacion)cmbTipoAfiliacion.SelectedIndex;

            Arquitecto arquitecto = new Arquitecto(codigo, nombres, condicionContrato, especialidad, tipoActividad, tipoAfiliacion);

            lblSueldoBase.Text = arquitecto.SueldoBase.ToString("F2");
            lblBonificacion.Text = arquitecto.Bonificacion.ToString("F2");
            lblDescuentosAFP.Text = arquitecto.DescuentosAFP.ToString("F2");
            lblDescuentosSNP.Text = arquitecto.DescuentosSNP.ToString("F2");
            lblSueldoBruto.Text = arquitecto.SueldoBruto.ToString("F2");
            lblSueldoNeto.Text = arquitecto.SueldoNeto.ToString("F2");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

