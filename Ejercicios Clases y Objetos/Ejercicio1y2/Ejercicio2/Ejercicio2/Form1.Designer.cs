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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            domainUpDown1 = new DomainUpDown();
            label4 = new Label();
            domainUpDown2 = new DomainUpDown();
            label5 = new Label();
            domainUpDown3 = new DomainUpDown();
            domainUpDown4 = new DomainUpDown();
            label6 = new Label();
            label7 = new Label();
            domainUpDown5 = new DomainUpDown();
            label8 = new Label();
            domainUpDown6 = new DomainUpDown();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(29, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(29, 50);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(29, 86);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Cargo";
            // 
            // domainUpDown1
            // 
            domainUpDown1.BackColor = Color.FromArgb(128, 128, 255);
            domainUpDown1.Location = new Point(105, 78);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(133, 23);
            domainUpDown1.TabIndex = 5;
            domainUpDown1.Text = "Gerente";
            domainUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(29, 115);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Área";
            // 
            // domainUpDown2
            // 
            domainUpDown2.BackColor = Color.FromArgb(128, 128, 255);
            domainUpDown2.Location = new Point(105, 115);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(133, 23);
            domainUpDown2.TabIndex = 7;
            domainUpDown2.Text = "Contabilidad";
            domainUpDown2.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(29, 146);
            label5.Name = "label5";
            label5.Size = new Size(67, 30);
            label5.TabIndex = 8;
            label5.Text = "Años de \r\nantiguedad";
            // 
            // domainUpDown3
            // 
            domainUpDown3.BackColor = Color.FromArgb(128, 128, 255);
            domainUpDown3.Location = new Point(105, 153);
            domainUpDown3.Name = "domainUpDown3";
            domainUpDown3.Size = new Size(133, 23);
            domainUpDown3.TabIndex = 9;
            domainUpDown3.Text = "7 años";
            domainUpDown3.TextAlign = HorizontalAlignment.Center;
            // 
            // domainUpDown4
            // 
            domainUpDown4.Location = new Point(293, 78);
            domainUpDown4.Name = "domainUpDown4";
            domainUpDown4.Size = new Size(133, 23);
            domainUpDown4.TabIndex = 10;
            domainUpDown4.Text = "6000";
            domainUpDown4.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(244, 80);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 11;
            label6.Text = "Sueldo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(432, 78);
            label7.Name = "label7";
            label7.Size = new Size(60, 30);
            label7.TabIndex = 12;
            label7.Text = "Monto \r\nmovilidad\r\n";
            // 
            // domainUpDown5
            // 
            domainUpDown5.Location = new Point(498, 78);
            domainUpDown5.Name = "domainUpDown5";
            domainUpDown5.Size = new Size(133, 23);
            domainUpDown5.TabIndex = 13;
            domainUpDown5.Text = "700";
            domainUpDown5.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(293, 131);
            label8.Name = "label8";
            label8.Size = new Size(76, 45);
            label8.TabIndex = 14;
            label8.Text = "Bonificacion \r\nsobre el \r\nsueldo\r\n";
            // 
            // domainUpDown6
            // 
            domainUpDown6.Location = new Point(375, 144);
            domainUpDown6.Name = "domainUpDown6";
            domainUpDown6.Size = new Size(133, 23);
            domainUpDown6.TabIndex = 15;
            domainUpDown6.Text = "5%";
            domainUpDown6.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(293, 13);
            button1.Name = "button1";
            button1.Size = new Size(61, 26);
            button1.TabIndex = 16;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(293, 44);
            button2.Name = "button2";
            button2.Size = new Size(61, 26);
            button2.TabIndex = 17;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(255, 224, 192);
            textBox3.Location = new Point(49, 229);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(468, 178);
            textBox3.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(128, 255, 128);
            label9.Location = new Point(49, 211);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 19;
            label9.Text = "Resultados\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(domainUpDown6);
            Controls.Add(label8);
            Controls.Add(domainUpDown5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(domainUpDown4);
            Controls.Add(domainUpDown3);
            Controls.Add(label5);
            Controls.Add(domainUpDown2);
            Controls.Add(label4);
            Controls.Add(domainUpDown1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Jefe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private DomainUpDown domainUpDown1;
        private Label label4;
        private DomainUpDown domainUpDown2;
        private Label label5;
        private DomainUpDown domainUpDown3;
        private DomainUpDown domainUpDown4;
        private Label label6;
        private Label label7;
        private DomainUpDown domainUpDown5;
        private Label label8;
        private DomainUpDown domainUpDown6;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private Label label9;
    }
}
