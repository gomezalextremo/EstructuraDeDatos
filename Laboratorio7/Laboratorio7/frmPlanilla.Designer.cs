namespace Laboratorio7
{
    partial class frmPlanilla
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            txtSueldo = new TextBox();
            lblSueldo = new Label();
            txtHorasExtras = new TextBox();
            label3 = new Label();
            cboTipoSeguro = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            cboArea = new ComboBox();
            txtResultado = new TextBox();
            btnCrear = new Button();
            btnMostrar = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(28, 17);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(28, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(167, 27);
            txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(219, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(295, 27);
            txtNombre.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 17);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(28, 105);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(167, 27);
            txtSueldo.TabIndex = 5;
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(28, 82);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(55, 20);
            lblSueldo.TabIndex = 4;
            lblSueldo.Text = "Sueldo";
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Location = new Point(219, 105);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(167, 27);
            txtHorasExtras.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 82);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 6;
            label3.Text = "Horas Extras";
            // 
            // cboTipoSeguro
            // 
            cboTipoSeguro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoSeguro.FormattingEnabled = true;
            cboTipoSeguro.Items.AddRange(new object[] { "AFP", "SNP" });
            cboTipoSeguro.Location = new Point(594, 40);
            cboTipoSeguro.Name = "cboTipoSeguro";
            cboTipoSeguro.Size = new Size(151, 28);
            cboTipoSeguro.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 17);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 9;
            label2.Text = "Tipo Seguro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(594, 81);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 11;
            label4.Text = "Area";
            // 
            // cboArea
            // 
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "ADMINISTRACION", "INFORMATICA", "CONTABILIDAD", "ALMACEN" });
            cboArea.Location = new Point(594, 104);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(151, 28);
            cboArea.TabIndex = 10;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(28, 157);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(717, 233);
            txtResultado.TabIndex = 12;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(26, 400);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(123, 29);
            btnCrear.TabIndex = 13;
            btnCrear.Text = "Crear Objeto";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(169, 400);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(258, 29);
            btnMostrar.TabIndex = 14;
            btnMostrar.Text = "Mostrar Informacion del Objeto";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(622, 396);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(123, 29);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(481, 396);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 29);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmPlanilla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrear);
            Controls.Add(txtResultado);
            Controls.Add(label4);
            Controls.Add(cboArea);
            Controls.Add(label2);
            Controls.Add(cboTipoSeguro);
            Controls.Add(txtHorasExtras);
            Controls.Add(label3);
            Controls.Add(txtSueldo);
            Controls.Add(lblSueldo);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Name = "frmPlanilla";
            Text = "Gestion de Planillas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtSueldo;
        private Label lblSueldo;
        private TextBox txtHorasExtras;
        private Label label3;
        private ComboBox cboTipoSeguro;
        private Label label2;
        private Label label4;
        private ComboBox cboArea;
        private TextBox txtResultado;
        private Button btnCrear;
        private Button btnMostrar;
        private Button btnSalir;
        private Button btnLimpiar;
    }
}
