namespace PRACTICA4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCodigo = new TextBox();
            txtNombreP = new TextBox();
            txtPrecio = new TextBox();
            btnConsultar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 97);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 165);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            label3.Click += label3_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(29, 53);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 3;
            // 
            // txtNombreP
            // 
            txtNombreP.Location = new Point(29, 115);
            txtNombreP.Name = "txtNombreP";
            txtNombreP.Size = new Size(100, 23);
            txtNombreP.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(29, 183);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 5;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(29, 244);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(120, 37);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 302);
            Controls.Add(btnConsultar);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombreP);
            Controls.Add(txtCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCodigo;
        private TextBox txtNombreP;
        private TextBox txtPrecio;
        private Button btnConsultar;
    }
}