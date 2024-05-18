namespace Ejercicio2
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
            btnCalcular = new Button();
            txtCodigo = new TextBox();
            txtNombres = new TextBox();
            cmbCondicionContrato = new ComboBox();
            cmbTipoAfiliacion = new ComboBox();
            cmbTipoActividad = new ComboBox();
            cmbEspecialidad = new ComboBox();
            lblCodigo = new Label();
            lblNombres = new Label();
            lblCondicionContrato = new Label();
            Especialidad = new Label();
            lblTipoActividad = new Label();
            lblTipoAfiliacion = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(592, 265);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(40, 49);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(204, 49);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(100, 23);
            txtNombres.TabIndex = 2;
            // 
            // cmbCondicionContrato
            // 
            cmbCondicionContrato.FormattingEnabled = true;
            cmbCondicionContrato.Location = new Point(366, 50);
            cmbCondicionContrato.Name = "cmbCondicionContrato";
            cmbCondicionContrato.Size = new Size(103, 23);
            cmbCondicionContrato.TabIndex = 3;
            // 
            // cmbTipoAfiliacion
            // 
            cmbTipoAfiliacion.FormattingEnabled = true;
            cmbTipoAfiliacion.Location = new Point(201, 104);
            cmbTipoAfiliacion.Name = "cmbTipoAfiliacion";
            cmbTipoAfiliacion.Size = new Size(103, 23);
            cmbTipoAfiliacion.TabIndex = 5;
            // 
            // cmbTipoActividad
            // 
            cmbTipoActividad.FormattingEnabled = true;
            cmbTipoActividad.Location = new Point(40, 104);
            cmbTipoActividad.Name = "cmbTipoActividad";
            cmbTipoActividad.Size = new Size(103, 23);
            cmbTipoActividad.TabIndex = 6;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(509, 51);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(103, 23);
            cmbEspecialidad.TabIndex = 7;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(43, 23);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 8;
            lblCodigo.Text = "Código";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(204, 23);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(56, 15);
            lblNombres.TabIndex = 9;
            lblNombres.Text = "Nombres";
            // 
            // lblCondicionContrato
            // 
            lblCondicionContrato.AutoSize = true;
            lblCondicionContrato.Location = new Point(366, 23);
            lblCondicionContrato.Name = "lblCondicionContrato";
            lblCondicionContrato.Size = new Size(128, 15);
            lblCondicionContrato.TabIndex = 10;
            lblCondicionContrato.Text = "Condición de Contrato";
            // 
            // Especialidad
            // 
            Especialidad.AutoSize = true;
            Especialidad.Location = new Point(509, 23);
            Especialidad.Name = "Especialidad";
            Especialidad.Size = new Size(72, 15);
            Especialidad.TabIndex = 11;
            Especialidad.Text = "Especialidad";
            // 
            // lblTipoActividad
            // 
            lblTipoActividad.AutoSize = true;
            lblTipoActividad.Location = new Point(43, 86);
            lblTipoActividad.Name = "lblTipoActividad";
            lblTipoActividad.Size = new Size(99, 15);
            lblTipoActividad.TabIndex = 12;
            lblTipoActividad.Text = "Tipo de Actividad";
            // 
            // lblTipoAfiliacion
            // 
            lblTipoAfiliacion.AutoSize = true;
            lblTipoAfiliacion.Location = new Point(201, 86);
            lblTipoAfiliacion.Name = "lblTipoAfiliacion";
            lblTipoAfiliacion.Size = new Size(99, 15);
            lblTipoAfiliacion.TabIndex = 13;
            lblTipoAfiliacion.Text = "Tipo de Afiliación";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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

        private Button btnCalcular;
        private TextBox txtCodigo;
        private TextBox txtNombres;
        private ComboBox cmbCondicionContrato;
        private ComboBox cmbTipoAfiliacion;
        private ComboBox cmbTipoActividad;
        private ComboBox cmbEspecialidad;
        private Label lblCodigo;
        private Label lblNombres;
        private Label lblCondicionContrato;
        private Label Especialidad;
        private Label lblTipoActividad;
        private Label lblTipoAfiliacion;
    }
}
