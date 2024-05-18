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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            domainUpDown1 = new DomainUpDown();
            domainUpDown2 = new DomainUpDown();
            label4 = new Label();
            label5 = new Label();
            domainUpDown3 = new DomainUpDown();
            label6 = new Label();
            domainUpDown4 = new DomainUpDown();
            label7 = new Label();
            domainUpDown5 = new DomainUpDown();
            label8 = new Label();
            domainUpDown6 = new DomainUpDown();
            label9 = new Label();
            domainUpDown7 = new DomainUpDown();
            textBox3 = new TextBox();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 51);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 96);
            label3.Name = "label3";
            label3.Size = new Size(70, 30);
            label3.TabIndex = 5;
            label3.Text = "Condicion\r\nde contacto\r\n";
            // 
            // domainUpDown1
            // 
            domainUpDown1.BackColor = SystemColors.MenuHighlight;
            domainUpDown1.ForeColor = SystemColors.ScrollBar;
            domainUpDown1.Location = new Point(91, 103);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(114, 23);
            domainUpDown1.TabIndex = 6;
            domainUpDown1.Text = "Contratado";
            // 
            // domainUpDown2
            // 
            domainUpDown2.AutoSize = true;
            domainUpDown2.BackColor = SystemColors.MenuHighlight;
            domainUpDown2.ForeColor = SystemColors.ScrollBar;
            domainUpDown2.ImeMode = ImeMode.NoControl;
            domainUpDown2.Location = new Point(91, 147);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(114, 23);
            domainUpDown2.TabIndex = 7;
            domainUpDown2.Text = "Estructuras";
            domainUpDown2.TextAlign = HorizontalAlignment.Center;
            domainUpDown2.SelectedItemChanged += domainUpDown2_SelectedItemChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 147);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 8;
            label4.Text = "Especialidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 185);
            label5.Name = "label5";
            label5.Size = new Size(57, 30);
            label5.TabIndex = 9;
            label5.Text = "Tipo de \r\nActividad\r\n";
            // 
            // domainUpDown3
            // 
            domainUpDown3.AutoSize = true;
            domainUpDown3.BackColor = SystemColors.MenuHighlight;
            domainUpDown3.ForeColor = SystemColors.ScrollBar;
            domainUpDown3.ImeMode = ImeMode.NoControl;
            domainUpDown3.Location = new Point(91, 192);
            domainUpDown3.Name = "domainUpDown3";
            domainUpDown3.Size = new Size(114, 23);
            domainUpDown3.TabIndex = 10;
            domainUpDown3.Text = "Supervision de Obras";
            domainUpDown3.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 229);
            label6.Name = "label6";
            label6.Size = new Size(57, 30);
            label6.TabIndex = 11;
            label6.Text = "Tipo de \r\nAfiliación";
            // 
            // domainUpDown4
            // 
            domainUpDown4.AutoSize = true;
            domainUpDown4.BackColor = SystemColors.MenuHighlight;
            domainUpDown4.ForeColor = SystemColors.ScrollBar;
            domainUpDown4.ImeMode = ImeMode.NoControl;
            domainUpDown4.Location = new Point(91, 236);
            domainUpDown4.Name = "domainUpDown4";
            domainUpDown4.Size = new Size(114, 23);
            domainUpDown4.TabIndex = 12;
            domainUpDown4.Text = "AFP";
            domainUpDown4.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(232, 105);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 13;
            label7.Text = "Sueldo";
            // 
            // domainUpDown5
            // 
            domainUpDown5.AutoSize = true;
            domainUpDown5.BackColor = SystemColors.MenuHighlight;
            domainUpDown5.ForeColor = SystemColors.ScrollBar;
            domainUpDown5.ImeMode = ImeMode.NoControl;
            domainUpDown5.Location = new Point(311, 105);
            domainUpDown5.Name = "domainUpDown5";
            domainUpDown5.Size = new Size(114, 23);
            domainUpDown5.TabIndex = 14;
            domainUpDown5.Text = "4000";
            domainUpDown5.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(232, 155);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 15;
            label8.Text = "Bonificación";
            // 
            // domainUpDown6
            // 
            domainUpDown6.AutoSize = true;
            domainUpDown6.BackColor = SystemColors.MenuHighlight;
            domainUpDown6.ForeColor = SystemColors.ScrollBar;
            domainUpDown6.ImeMode = ImeMode.NoControl;
            domainUpDown6.Location = new Point(311, 155);
            domainUpDown6.Name = "domainUpDown6";
            domainUpDown6.Size = new Size(114, 23);
            domainUpDown6.TabIndex = 16;
            domainUpDown6.Text = "18%";
            domainUpDown6.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(232, 244);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 17;
            label9.Text = "Descuento";
            // 
            // domainUpDown7
            // 
            domainUpDown7.AutoSize = true;
            domainUpDown7.BackColor = SystemColors.MenuHighlight;
            domainUpDown7.ForeColor = SystemColors.ScrollBar;
            domainUpDown7.ImeMode = ImeMode.NoControl;
            domainUpDown7.Location = new Point(311, 236);
            domainUpDown7.Name = "domainUpDown7";
            domainUpDown7.Size = new Size(114, 23);
            domainUpDown7.TabIndex = 18;
            domainUpDown7.Text = "15%";
            domainUpDown7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(91, 309);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(354, 142);
            textBox3.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(91, 291);
            label10.Name = "label10";
            label10.Size = new Size(124, 15);
            label10.TabIndex = 20;
            label10.Text = "Pago emnsual y Datos";
            // 
            // button1
            // 
            button1.Location = new Point(211, 12);
            button1.Name = "button1";
            button1.Size = new Size(65, 24);
            button1.TabIndex = 21;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(211, 51);
            button2.Name = "button2";
            button2.Size = new Size(65, 24);
            button2.TabIndex = 22;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(735, 495);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(textBox3);
            Controls.Add(domainUpDown7);
            Controls.Add(label9);
            Controls.Add(domainUpDown6);
            Controls.Add(label8);
            Controls.Add(domainUpDown5);
            Controls.Add(label7);
            Controls.Add(domainUpDown4);
            Controls.Add(label6);
            Controls.Add(domainUpDown3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(domainUpDown2);
            Controls.Add(domainUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            ForeColor = SystemColors.MenuHighlight;
            Name = "Form1";
            Text = "ARQUITECTO";
            TransparencyKey = Color.FromArgb(255, 255, 128);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private DomainUpDown domainUpDown1;
        private DomainUpDown domainUpDown2;
        private Label label4;
        private Label label5;
        private DomainUpDown domainUpDown3;
        private Label label6;
        private DomainUpDown domainUpDown4;
        private Label label7;
        private DomainUpDown domainUpDown5;
        private Label label8;
        private DomainUpDown domainUpDown6;
        private Label label9;
        private DomainUpDown domainUpDown7;
        private TextBox textBox3;
        private Label label10;
        private Button button1;
        private Button button2;
    }
}
