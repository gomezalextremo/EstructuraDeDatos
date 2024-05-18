namespace Ejercicio1
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
            lblTipoAfiliacion = new Label();
            lblTipoActividad = new Label();
            Especialidad = new Label();
            lblCondicionContrato = new Label();
            lblNombres = new Label();
            lblCodigo = new Label();
            cmbEspecialidad = new ComboBox();
            cmbTipoActividad = new ComboBox();
            cmbTipoAfiliacion = new ComboBox();
            cmbCondicionContrato = new ComboBox();
            txtNombres = new TextBox();
            txtCodigo = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblTipoAfiliacion
            // 
            lblTipoAfiliacion.AutoSize = true;
            lblTipoAfiliacion.Location = new Point(192, 103);
            lblTipoAfiliacion.Name = "lblTipoAfiliacion";
            lblTipoAfiliacion.Size = new Size(99, 15);
            lblTipoAfiliacion.TabIndex = 26;
            lblTipoAfiliacion.Text = "Tipo de Afiliación";
            // 
            // lblTipoActividad
            // 
            lblTipoActividad.AutoSize = true;
            lblTipoActividad.Location = new Point(34, 103);
            lblTipoActividad.Name = "lblTipoActividad";
            lblTipoActividad.Size = new Size(99, 15);
            lblTipoActividad.TabIndex = 25;
            lblTipoActividad.Text = "Tipo de Actividad";
            // 
            // Especialidad
            // 
            Especialidad.AutoSize = true;
            Especialidad.Location = new Point(500, 40);
            Especialidad.Name = "Especialidad";
            Especialidad.Size = new Size(72, 15);
            Especialidad.TabIndex = 24;
            Especialidad.Text = "Especialidad";
            // 
            // lblCondicionContrato
            // 
            lblCondicionContrato.AutoSize = true;
            lblCondicionContrato.Location = new Point(357, 40);
            lblCondicionContrato.Name = "lblCondicionContrato";
            lblCondicionContrato.Size = new Size(128, 15);
            lblCondicionContrato.TabIndex = 23;
            lblCondicionContrato.Text = "Condición de Contrato";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(195, 40);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(56, 15);
            lblNombres.TabIndex = 22;
            lblNombres.Text = "Nombres";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(34, 40);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 21;
            lblCodigo.Text = "Código";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(500, 68);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(103, 23);
            cmbEspecialidad.TabIndex = 20;
            // 
            // cmbTipoActividad
            // 
            cmbTipoActividad.FormattingEnabled = true;
            cmbTipoActividad.Location = new Point(31, 121);
            cmbTipoActividad.Name = "cmbTipoActividad";
            cmbTipoActividad.Size = new Size(103, 23);
            cmbTipoActividad.TabIndex = 19;
            // 
            // cmbTipoAfiliacion
            // 
            cmbTipoAfiliacion.FormattingEnabled = true;
            cmbTipoAfiliacion.Location = new Point(192, 121);
            cmbTipoAfiliacion.Name = "cmbTipoAfiliacion";
            cmbTipoAfiliacion.Size = new Size(103, 23);
            cmbTipoAfiliacion.TabIndex = 18;
            // 
            // cmbCondicionContrato
            // 
            cmbCondicionContrato.FormattingEnabled = true;
            cmbCondicionContrato.Location = new Point(357, 67);
            cmbCondicionContrato.Name = "cmbCondicionContrato";
            cmbCondicionContrato.Size = new Size(103, 23);
            cmbCondicionContrato.TabIndex = 17;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(195, 66);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(100, 23);
            txtNombres.TabIndex = 16;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(31, 66);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 15;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(583, 282);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 344);
            Controls.Add(lblTipoAfiliacion);
            Controls.Add(lblTipoActividad);
            Controls.Add(Especialidad);
            Controls.Add(lblCondicionContrato);
            Controls.Add(lblNombres);
            Controls.Add(lblCodigo);
            Controls.Add(cmbEspecialidad);
            Controls.Add(cmbTipoActividad);
            Controls.Add(cmbTipoAfiliacion);
            Controls.Add(cmbCondicionContrato);
            Controls.Add(txtNombres);
            Controls.Add(txtCodigo);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoAfiliacion;
        private Label lblTipoActividad;
        private Label Especialidad;
        private Label lblCondicionContrato;
        private Label lblNombres;
        private Label lblCodigo;
        private ComboBox cmbEspecialidad;
        private ComboBox cmbTipoActividad;
        private ComboBox cmbTipoAfiliacion;
        private ComboBox cmbCondicionContrato;
        private TextBox txtNombres;
        private TextBox txtCodigo;
        private Button btnCalcular;
    }
}
