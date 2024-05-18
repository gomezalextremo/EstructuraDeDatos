namespace WinFormsApp1
{
    partial class Form1
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
            this.lblTipoActividad = new Label();
            this.lblEspecialidad = new Label();
            txtNombres = new TextBox();
            lblNombres = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            lblCondicionContrato = new Label();
            lblTipoAfiliacion = new Label();
            cmbEspecialidad = new ComboBox();
            cmbCondicionContrato = new ComboBox();
            cmbTipoAfiliacion = new ComboBox();
            cmbTipoActividad = new ComboBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblTipoActividad
            // 
            this.lblTipoActividad.AutoSize = true;
            this.lblTipoActividad.Location = new Point(190, 90);
            this.lblTipoActividad.Name = "lblTipoActividad";
            this.lblTipoActividad.Size = new Size(99, 15);
            this.lblTipoActividad.TabIndex = 18;
            this.lblTipoActividad.Text = "Tipo de Actividad";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new Point(22, 90);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new Size(72, 15);
            this.lblEspecialidad.TabIndex = 16;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(190, 58);
            txtNombres.Margin = new Padding(3, 2, 3, 2);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(259, 23);
            txtNombres.TabIndex = 15;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(190, 41);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(69, 15);
            lblNombres.TabIndex = 14;
            lblNombres.Text = "lblNombres";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(22, 58);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(147, 23);
            txtCodigo.TabIndex = 13;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(22, 41);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 12;
            lblCodigo.Text = "Codigo";
            lblCodigo.Click += lblCodigo_Click;
            // 
            // lblCondicionContrato
            // 
            lblCondicionContrato.AutoSize = true;
            lblCondicionContrato.Location = new Point(511, 41);
            lblCondicionContrato.Name = "lblCondicionContrato";
            lblCondicionContrato.Size = new Size(128, 15);
            lblCondicionContrato.TabIndex = 21;
            lblCondicionContrato.Text = "Condición de Contrato";
            // 
            // lblTipoAfiliacion
            // 
            lblTipoAfiliacion.AutoSize = true;
            lblTipoAfiliacion.Location = new Point(334, 90);
            lblTipoAfiliacion.Name = "lblTipoAfiliacion";
            lblTipoAfiliacion.Size = new Size(99, 15);
            lblTipoAfiliacion.TabIndex = 25;
            lblTipoAfiliacion.Text = "Tipo de Afiliacion";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(22, 108);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(121, 23);
            cmbEspecialidad.TabIndex = 26;
            // 
            // cmbCondicionContrato
            // 
            cmbCondicionContrato.FormattingEnabled = true;
            cmbCondicionContrato.Location = new Point(511, 59);
            cmbCondicionContrato.Name = "cmbCondicionContrato";
            cmbCondicionContrato.Size = new Size(121, 23);
            cmbCondicionContrato.TabIndex = 27;
            // 
            // cmbTipoAfiliacion
            // 
            cmbTipoAfiliacion.FormattingEnabled = true;
            cmbTipoAfiliacion.Location = new Point(334, 121);
            cmbTipoAfiliacion.Name = "cmbTipoAfiliacion";
            cmbTipoAfiliacion.Size = new Size(121, 23);
            cmbTipoAfiliacion.TabIndex = 28;
            cmbTipoAfiliacion.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // cmbTipoActividad
            // 
            cmbTipoActividad.FormattingEnabled = true;
            cmbTipoActividad.Location = new Point(190, 108);
            cmbTipoActividad.Name = "cmbTipoActividad";
            cmbTipoActividad.Size = new Size(121, 23);
            cmbTipoActividad.TabIndex = 29;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(544, 228);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 30;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(cmbTipoActividad);
            Controls.Add(cmbTipoAfiliacion);
            Controls.Add(cmbCondicionContrato);
            Controls.Add(cmbEspecialidad);
            Controls.Add(lblTipoAfiliacion);
            Controls.Add(lblCondicionContrato);
            Controls.Add(this.lblTipoActividad);
            Controls.Add(this.lblEspecialidad);
            Controls.Add(txtNombres);
            Controls.Add(lblNombres);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox cboArea;
        private Label label2;
        private ComboBox cboTipoSeguro;
        private TextBox txtHorasExtras;
        private Label label3;
        private TextBox txtSueldo;
        private Label lblSueldo;
        private TextBox txtNombres;
        private Label lblNombres;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label lblCondicionContrato;
        private Label lblTipoAfiliacion;
        private ComboBox cmbEspecialidad;
        private ComboBox cmbCondicionContrato;
        private ComboBox cmbTipoAfiliacion;
        private ComboBox cmbTipoActividad;
        private Button btnCalcular;
    }
}
