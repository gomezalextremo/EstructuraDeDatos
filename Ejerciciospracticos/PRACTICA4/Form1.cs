using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA4
{
    public partial class Form1 : Form
    {
        string[,] productos = new string[4, 3];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNombreP.Enabled = false;
            txtPrecio.Enabled = false;
            productos[0, 0] = "Código";
            productos[0, 1] = "Nombre";
            productos[0, 2] = "Precio";
            productos[1, 0] = "P001";
            productos[1, 1] = "ARROZ";
            productos[1, 2] = "2000";
            productos[2, 0] = "P002";
            productos[2, 1] = "ACEITE";
            productos[2, 2] = "5000";
            productos[3, 0] = "P003";
            productos[3, 1] = "LENTEJAS";
            productos[3, 2] = "2500";


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.ToUpper();
            int indice = 0;
            bool encuentra = false;
            for (int i = 1; i < 4 && encuentra == false; i++)
            {
                if (codigo.Equals(productos[i, 0]))
                {
                    indice = i;
                    encuentra = true;
                    txtNombreP.Text = productos[indice, 1];
                    txtPrecio.Text = productos[indice, 2];


                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

