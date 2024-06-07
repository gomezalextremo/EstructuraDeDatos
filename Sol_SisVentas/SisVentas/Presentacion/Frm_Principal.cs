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

namespace SisVentas.Presentacion
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();

            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #region "Mis variables"
            internal int nCodigo_us {  get; set; }
            internal string cLogin_us { get; set; }
            internal string cNombre_us { get; set; }    
            internal string cDescripcion_ru { get; set; }   
            internal int nCodigo_ru { get; set; }
        #endregion
        #region "Estilo del control del Titulo"
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wMsg, int wParam, int lParam);

        #endregion

        private void Pnl_contenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            lbl_nombre_us.Text = "Usuario: "+ cNombre_us;
            lblDescripcion_ru.Text = "Rol usuario: " + cDescripcion_ru;
        }

        private void Pnl_barraestado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pctLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Desea cerrar sesión?",
                                      "Aviso del sistema",
                                      MessageBoxButtons.OKCancel,
                                      MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void lbl_nombre_us_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (nCodigo_ru==1) //solo los adminitradores del sistema
            {
                Frm_Usuarios oFrm_us = new Frm_Usuarios();
                oFrm_us.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se tiene permiso para esta opcion",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
               
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Frm_Ventas oFrm_ventas = new Frm_Ventas();
            oFrm_ventas.ShowDialog();

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {

            string text = @"
                                        TODOBARATO S.A.C. 

                Dirección: Jirón Lima 169, Ayacucho 05003     
                Contacto: 999212121             

             NOMBRE DEL SOCIO = GOMEZ DE LA CRUZ, Alexander Ruben
             DNI: 76238902
             TOTAL DE ACCIONES = 33 %

             NOMBRE DEL SOCIO = ZAGA HUAYLLACO, Carlos Rodrigo
             DNI: 74087503
             TOTAL DE ACCIONES = 34 %

             NOMBRE DEL SOCIO = AVILA ALANYA, Neftaly Dianel
             DNI: 62535411
             TOTAL DE ACCIONES = 33 %";



            Frm_Empresa frmEmpresa = new Frm_Empresa(text);
            frmEmpresa.Show();




        }
    }
}
