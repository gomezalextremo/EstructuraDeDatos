using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SisVentas.Presentacion
{
    public partial class Frm_Ventas : Form
    {
        public Frm_Ventas()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


        }
        #region "Estilo del control del Titulo"
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wMsg, int wParam, int lParam);

        #endregion
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
           

            string NumeroDni;
            string nombreu;
            double todacompra;
            
            NumeroDni = txtDNIV.Text;
            nombreu = txtNombreV.Text;
            todacompra = Convert.ToDouble(tbtotaldetotal.Text);

            if (txtNombreV.Text == string.Empty ||
               txtDNIV.Text == string.Empty)
            {
                MessageBox.Show("Ingrese dato requerido (*)",
                                "Aviso del sistemas",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("NOMBRES: " + nombreu + " " + '\n' +
                            "DNI: " + NumeroDni + '\n' +
                            "TOTAL DE VENTA: S/ " + todacompra + '\n' +
                            '\n' +
                            "           ! VENTA EXITOSA ¡      " + '\n');
            }



        }

        private void btnSum_Click(object sender, EventArgs e)
        {
         

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Ventas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N1;
            string N2;
            double N3;
            double Total = 0;
            double sumap = 0;

            N1 = Convert.ToInt32(txtCantidad.Text);
            N2 = txtAnadirproducto.Text;
            N3 = Convert.ToDouble(txtPrecioUnitario.Text);
            //salida de datos de producto
            lbfactorial.Items.Add("(" + Convert.ToString(N1) + ")");
            lbmobreP.Items.Add(Convert.ToString(N2));
            lbpreciouni.Items.Add(Convert.ToString(N3));
            sumap = N1 * N3;
            lbtotalpre.Items.Add(Convert.ToString(sumap));
            foreach (object item in lbtotalpre.Items)
            {
                Total += Convert.ToDouble(item);
                tbtotaldetotal.Text = (Total).ToString();


            }
            txtCantidad.Text = "";
            txtAnadirproducto.Text = "";
            txtPrecioUnitario.Text = "";
            txtCantidad.Focus();



        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtDNIV_TextChanged(object sender, EventArgs e)
        {
            txtDNIV.MaxLength = 8;
        }

        private void lbpreciouni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void lbtotalpre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbmobreP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnadirproducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbfactorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void pctLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
