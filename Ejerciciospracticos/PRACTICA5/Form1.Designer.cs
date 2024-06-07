namespace PRACTICA5
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
            label1 = new Label();
            label2 = new Label();
            btnMayusculas = new Button();
            btnMinusculas = new Button();
            txtPrincipal = new TextBox();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 23);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Texto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 195);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Resultado";
            // 
            // btnMayusculas
            // 
            btnMayusculas.Location = new Point(168, 167);
            btnMayusculas.Name = "btnMayusculas";
            btnMayusculas.Size = new Size(108, 49);
            btnMayusculas.TabIndex = 3;
            btnMayusculas.Text = "Convertir a \r\nMAYUSCULAS";
            btnMayusculas.UseVisualStyleBackColor = true;
            btnMayusculas.Click += btnMayusculas_Click;
            // 
            // btnMinusculas
            // 
            btnMinusculas.Location = new Point(353, 165);
            btnMinusculas.Name = "btnMinusculas";
            btnMinusculas.Size = new Size(108, 52);
            btnMinusculas.TabIndex = 4;
            btnMinusculas.Text = "Convertir a \r\nminusculas";
            btnMinusculas.UseVisualStyleBackColor = true;
            btnMinusculas.Click += btnMinusculas_Click;
            // 
            // txtPrincipal
            // 
            txtPrincipal.Location = new Point(23, 45);
            txtPrincipal.Multiline = true;
            txtPrincipal.Name = "txtPrincipal";
            txtPrincipal.Size = new Size(703, 114);
            txtPrincipal.TabIndex = 5;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(37, 235);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(689, 108);
            txtResultado.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 355);
            Controls.Add(txtResultado);
            Controls.Add(txtPrincipal);
            Controls.Add(btnMinusculas);
            Controls.Add(btnMayusculas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnMayusculas;
        private Button btnMinusculas;
        private TextBox txtPrincipal;
        private TextBox txtResultado;
    }
}
