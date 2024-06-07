namespace PRACTICA1
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
            btnVer = new Button();
            liLista = new ListBox();
            txtNumero = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnVer
            // 
            btnVer.Location = new Point(66, 206);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(108, 44);
            btnVer.TabIndex = 7;
            btnVer.Text = "VER";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // liLista
            // 
            liLista.FormattingEnabled = true;
            liLista.ItemHeight = 15;
            liLista.Location = new Point(48, 89);
            liLista.Name = "liLista";
            liLista.Size = new Size(153, 109);
            liLista.TabIndex = 6;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(66, 51);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(135, 23);
            txtNumero.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 22);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Mostrar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 284);
            Controls.Add(btnVer);
            Controls.Add(liLista);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVer;
        private ListBox liLista;
        private TextBox txtNumero;
        private Label label1;
    }
}
