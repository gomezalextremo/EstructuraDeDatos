using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public class Form1 : Form
    {
        private TextBox txtCodigo;
        private TextBox txtNombres;
        private ComboBox cmbCondicionContrato;
        private ComboBox cmbEspecialidad;
        private ComboBox cmbTipoActividad;
        private ComboBox cmbTipoAfiliacion;
        private Label lblSueldoBase;
        private Label lblBonificacion;
        private Label lblSueldoBruto;
        private Label lblDescuento;
        private Label lblSueldoNeto;
        private Button btnCalcular;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            txtCodigo = new TextBox();
            txtNombres = new TextBox();
            cmbCondicionContrato = new ComboBox();
            cmbEspecialidad = new ComboBox();
            cmbTipoActividad = new ComboBox();
            cmbTipoAfiliacion = new ComboBox();
            lblSueldoBase = new Label();
            lblBonificacion = new Label();
            lblSueldoBruto = new Label();
            lblDescuento = new Label();
            lblSueldoNeto = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(150, 30);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(200, 23);
            txtCodigo.TabIndex = 22;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(150, 60);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(200, 23);
            txtNombres.TabIndex = 21;
            // 
            // cmbCondicionContrato
            // 
            cmbCondicionContrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondicionContrato.FormattingEnabled = true;
            cmbCondicionContrato.Items.AddRange(new object[] { "Estable", "Contratado" });
            cmbCondicionContrato.Location = new Point(150, 90);
            cmbCondicionContrato.Name = "cmbCondicionContrato";
            cmbCondicionContrato.Size = new Size(200, 23);
            cmbCondicionContrato.TabIndex = 20;
            cmbCondicionContrato.SelectedIndexChanged += cmbCondicionContrato_SelectedIndexChanged;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Items.AddRange(new object[] { "Estructuras", "Recursos Hídricos" });
            cmbEspecialidad.Location = new Point(150, 120);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(200, 23);
            cmbEspecialidad.TabIndex = 19;
            // 
            // cmbTipoActividad
            // 
            cmbTipoActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoActividad.FormattingEnabled = true;
            cmbTipoActividad.Items.AddRange(new object[] { "Supervisión de Obras", "Supervisión de Vías" });
            cmbTipoActividad.Location = new Point(150, 150);
            cmbTipoActividad.Name = "cmbTipoActividad";
            cmbTipoActividad.Size = new Size(200, 23);
            cmbTipoActividad.TabIndex = 18;
            // 
            // cmbTipoAfiliacion
            // 
            cmbTipoAfiliacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoAfiliacion.FormattingEnabled = true;
            cmbTipoAfiliacion.Items.AddRange(new object[] { "AFP", "SNP" });
            cmbTipoAfiliacion.Location = new Point(150, 180);
            cmbTipoAfiliacion.Name = "cmbTipoAfiliacion";
            cmbTipoAfiliacion.Size = new Size(200, 23);
            cmbTipoAfiliacion.TabIndex = 17;
            // 
            // lblSueldoBase
            // 
            lblSueldoBase.AutoSize = true;
            lblSueldoBase.Location = new Point(150, 210);
            lblSueldoBase.Name = "lblSueldoBase";
            lblSueldoBase.Size = new Size(0, 15);
            lblSueldoBase.TabIndex = 16;
            // 
            // lblBonificacion
            // 
            lblBonificacion.AutoSize = true;
            lblBonificacion.Location = new Point(150, 240);
            lblBonificacion.Name = "lblBonificacion";
            lblBonificacion.Size = new Size(0, 15);
            lblBonificacion.TabIndex = 15;
            // 
            // lblSueldoBruto
            // 
            lblSueldoBruto.AutoSize = true;
            lblSueldoBruto.Location = new Point(150, 270);
            lblSueldoBruto.Name = "lblSueldoBruto";
            lblSueldoBruto.Size = new Size(0, 15);
            lblSueldoBruto.TabIndex = 14;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(150, 300);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(0, 15);
            lblDescuento.TabIndex = 13;
            // 
            // lblSueldoNeto
            // 
            lblSueldoNeto.AutoSize = true;
            lblSueldoNeto.Location = new Point(150, 330);
            lblSueldoNeto.Name = "lblSueldoNeto";
            lblSueldoNeto.Size = new Size(0, 15);
            lblSueldoNeto.TabIndex = 12;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(150, 360);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(200, 30);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(400, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblSueldoNeto);
            Controls.Add(lblDescuento);
            Controls.Add(lblSueldoBruto);
            Controls.Add(lblBonificacion);
            Controls.Add(lblSueldoBase);
            Controls.Add(cmbTipoAfiliacion);
            Controls.Add(cmbTipoActividad);
            Controls.Add(cmbEspecialidad);
            Controls.Add(cmbCondicionContrato);
            Controls.Add(txtNombres);
            Controls.Add(txtCodigo);
            Name = "Form1";
            Text = "Calculadora de Sueldo de Arquitecto";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Captura los valores de los controles
            string codigo = txtCodigo.Text;
            string nombres = txtNombres.Text;
            string condicionContrato = cmbCondicionContrato.SelectedItem.ToString();
            string especialidad = cmbEspecialidad.SelectedItem.ToString();
            string tipoActividad = cmbTipoActividad.SelectedItem.ToString();
            string tipoAfiliacion = cmbTipoAfiliacion.SelectedItem.ToString();

            // Crea una instancia de Arquitecto
            Arquitecto arquitecto = new Arquitecto(codigo, nombres, condicionContrato, especialidad, tipoActividad, tipoAfiliacion);

            // Muestra la información en los labels
            lblSueldoBase.Text = "Sueldo Base: " + arquitecto.SueldoBase.ToString("C");
            lblBonificacion.Text = "Bonificación: " + arquitecto.Bonificacion.ToString("C");
            lblSueldoBruto.Text = "Sueldo Bruto: " + arquitecto.SueldoBruto.ToString("C");
            lblDescuento.Text = "Descuento: " + arquitecto.Descuento.ToString("C");
            lblSueldoNeto.Text = "Sueldo Neto: " + arquitecto.SueldoNeto.ToString("C");
        }

        // Clase Arquitecto
        public class Arquitecto
        {
            public string Codigo { get; set; }
            public string Nombres { get; set; }
            public string CondicionContrato { get; set; }
            public string Especialidad { get; set; }
            public string TipoActividad { get; set; }
            public string TipoAfiliacion { get; set; }
            public double SueldoBase { get; private set; }
            public double Bonificacion { get; private set; }
            public double Descuento { get; private set; }
            public double SueldoBruto { get; private set; }
            public double SueldoNeto { get; private set; }

            public Arquitecto(string codigo, string nombres, string condicionContrato, string especialidad, string tipoActividad, string tipoAfiliacion)
            {
                Codigo = codigo;
                Nombres = nombres;
                CondicionContrato = condicionContrato;
                Especialidad = especialidad;
                TipoActividad = tipoActividad;
                TipoAfiliacion = tipoAfiliacion;
                SueldoBase = CalcularSueldoBase();
                Bonificacion = CalcularBonificacion();
                SueldoBruto = CalcularSueldoBruto();
                Descuento = CalcularDescuento();
                SueldoNeto = CalcularSueldoNeto();
            }

            private double CalcularSueldoBase()
            {
                if (CondicionContrato == "Estable")
                {
                    if (TipoActividad == "Supervisión de Obras")
                        return 4000;
                    else if (TipoActividad == "Supervisión de Vías")
                        return 6000;
                }
                else if (CondicionContrato == "Contratado")
                {
                    if (TipoActividad == "Supervisión de Obras")
                        return 2000;
                    else if (TipoActividad == "Supervisión de Vías")
                        return 4500;
                }
                return 0;
            }

            private double CalcularBonificacion()
            {
                if (Especialidad == "Estructuras")
                    return SueldoBase * 0.16;
                else if (Especialidad == "Recursos Hídricos")
                    return SueldoBase * 0.18;
                return 0;
            }

            private double CalcularSueldoBruto()
            {
                return SueldoBase + Bonificacion;
            }

            private double CalcularDescuento()
            {
                if (TipoAfiliacion == "AFP")
                    return SueldoBruto * 0.15;
                else if (TipoAfiliacion == "SNP")
                    return SueldoBruto * 0.08;
                return 0;
            }

            private double CalcularSueldoNeto()
            {
                return SueldoBruto - Descuento;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbCondicionContrato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

