namespace PRACTICA
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
            txtNumero = new TextBox();
            liTabla = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese numero:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(29, 43);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextChanged += textBox1_TextChanged;
            // 
            // liTabla
            // 
            liTabla.FormattingEnabled = true;
            liTabla.ItemHeight = 15;
            liTabla.Location = new Point(166, 25);
            liTabla.Name = "liTabla";
            liTabla.Size = new Size(165, 169);
            liTabla.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(29, 106);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 3;
            button1.Text = "Mostrar tabla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 208);
            Controls.Add(button1);
            Controls.Add(liTabla);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private ListBox liTabla;
        private Button button1;
    }
}
