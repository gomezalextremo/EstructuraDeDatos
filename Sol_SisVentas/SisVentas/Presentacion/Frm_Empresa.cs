using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SisVentas.Presentacion
{
    public partial class Frm_Empresa : Form
    {
        public Frm_Empresa(string text)
        {
            InitializeComponent();

            // Configurar el TextBox para mostrar el texto pasado al constructor
            rtbInfo.Text = text;

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
        private void otherTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario cuando se hace clic en el botón
            this.Close();
        }

        private void rtbInfo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
