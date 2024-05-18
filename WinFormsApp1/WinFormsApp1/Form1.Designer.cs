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
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(283, 344);
            button2.Name = "button2";
            button2.Size = new Size(139, 23);
            button2.TabIndex = 1;
            button2.Text = "Mostrar información";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(461, 344);
            button3.Name = "button3";
            button3.Size = new Size(131, 23);
            button3.TabIndex = 2;
            button3.Text = "Calcular sueldo final";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 112);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 3;
            label1.Text = "DNI:\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 51);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombres:\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(583, 51);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 8;
            label7.Text = "Área del jefe:\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(382, 51);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 7;
            label8.Text = "Cargo del jefe:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Gerente", "Subgerente" });
            comboBox1.Location = new Point(382, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Contabilidad", "Planificacion" });
            comboBox2.Location = new Point(583, 69);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 23);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(54, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 23);
            textBox2.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(635, 344);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 17;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(500, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(60, 23);
            textBox3.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 129);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 18;
            label3.Text = "Años de antiguedad:\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 395);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
    }
}
