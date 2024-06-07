namespace SisVentas.Presentacion
{
    partial class Frm_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Pnl_opciones = new System.Windows.Forms.Panel();
            this.btnCerrarsesion = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Pnl_barraestado = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDescripcion_ru = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nombre_us = new System.Windows.Forms.Label();
            this.Pnl_contenido = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.Pnl_opciones.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.Pnl_barraestado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pnl_contenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_opciones
            // 
            this.Pnl_opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(198)))), ((int)(((byte)(42)))));
            this.Pnl_opciones.Controls.Add(this.btnCerrarsesion);
            this.Pnl_opciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_opciones.Location = new System.Drawing.Point(534, 0);
            this.Pnl_opciones.Name = "Pnl_opciones";
            this.Pnl_opciones.Size = new System.Drawing.Size(160, 360);
            this.Pnl_opciones.TabIndex = 0;
            // 
            // btnCerrarsesion
            // 
            this.btnCerrarsesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarsesion.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarsesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrarsesion.Location = new System.Drawing.Point(9, 24);
            this.btnCerrarsesion.Name = "btnCerrarsesion";
            this.btnCerrarsesion.Size = new System.Drawing.Size(139, 52);
            this.btnCerrarsesion.TabIndex = 2;
            this.btnCerrarsesion.Text = "Cerrar sesión";
            this.btnCerrarsesion.UseVisualStyleBackColor = false;
            this.btnCerrarsesion.Click += new System.EventHandler(this.btnCerrarsesion_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ImageKey = "community_users_12977.png";
            this.btnUsuarios.ImageList = this.imageList1;
            this.btnUsuarios.Location = new System.Drawing.Point(345, 53);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(110, 82);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empresa.png");
            this.imageList1.Images.SetKeyName(1, "packge.png");
            this.imageList1.Images.SetKeyName(2, "documents-paper-sheets-stack-stroke-interface-symbol_icon-icons.com_57854.png");
            this.imageList1.Images.SetKeyName(3, "proveedor.png");
            this.imageList1.Images.SetKeyName(4, "Carrycart_icon-icons.com_51194.png");
            this.imageList1.Images.SetKeyName(5, "puntodeventa.png");
            this.imageList1.Images.SetKeyName(6, "community_users_12977.png");
            this.imageList1.Images.SetKeyName(7, "finance_receipt_dollar_calculator_payment_money_icon_142011.png");
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.ImageKey = "empresa.png";
            this.btnEmpresa.ImageList = this.imageList1;
            this.btnEmpresa.Location = new System.Drawing.Point(206, 53);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(110, 82);
            this.btnEmpresa.TabIndex = 0;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(196)))), ((int)(((byte)(126)))));
            this.Pnl_titulo.Controls.Add(this.pctLogo);
            this.Pnl_titulo.Controls.Add(this.lblTitulo);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(534, 76);
            this.Pnl_titulo.TabIndex = 1;
            this.Pnl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_titulo_MouseDown);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(12, 12);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(68, 58);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 2;
            this.pctLogo.TabStop = false;
            this.pctLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctLogo_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(156, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(279, 43);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "TODOBARATO S.A.C.";
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            // 
            // Pnl_barraestado
            // 
            this.Pnl_barraestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(219)))), ((int)(((byte)(195)))));
            this.Pnl_barraestado.Controls.Add(this.pictureBox2);
            this.Pnl_barraestado.Controls.Add(this.lblDescripcion_ru);
            this.Pnl_barraestado.Controls.Add(this.pictureBox1);
            this.Pnl_barraestado.Controls.Add(this.lbl_nombre_us);
            this.Pnl_barraestado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_barraestado.Location = new System.Drawing.Point(0, 277);
            this.Pnl_barraestado.Name = "Pnl_barraestado";
            this.Pnl_barraestado.Size = new System.Drawing.Size(534, 83);
            this.Pnl_barraestado.TabIndex = 2;
            this.Pnl_barraestado.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_barraestado_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblDescripcion_ru
            // 
            this.lblDescripcion_ru.AutoSize = true;
            this.lblDescripcion_ru.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion_ru.Location = new System.Drawing.Point(51, 57);
            this.lblDescripcion_ru.Name = "lblDescripcion_ru";
            this.lblDescripcion_ru.Size = new System.Drawing.Size(91, 14);
            this.lblDescripcion_ru.TabIndex = 2;
            this.lblDescripcion_ru.Text = "Rol usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_nombre_us
            // 
            this.lbl_nombre_us.AutoSize = true;
            this.lbl_nombre_us.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_us.Location = new System.Drawing.Point(51, 16);
            this.lbl_nombre_us.Name = "lbl_nombre_us";
            this.lbl_nombre_us.Size = new System.Drawing.Size(63, 14);
            this.lbl_nombre_us.TabIndex = 0;
            this.lbl_nombre_us.Text = "Usuario:";
            this.lbl_nombre_us.Click += new System.EventHandler(this.lbl_nombre_us_Click);
            // 
            // Pnl_contenido
            // 
            this.Pnl_contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(202)))));
            this.Pnl_contenido.Controls.Add(this.btnVentas);
            this.Pnl_contenido.Controls.Add(this.btnUsuarios);
            this.Pnl_contenido.Controls.Add(this.btnEmpresa);
            this.Pnl_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_contenido.Location = new System.Drawing.Point(0, 76);
            this.Pnl_contenido.Name = "Pnl_contenido";
            this.Pnl_contenido.Size = new System.Drawing.Size(534, 201);
            this.Pnl_contenido.TabIndex = 3;
            this.Pnl_contenido.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_contenido_Paint);
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ImageKey = "puntodeventa.png";
            this.btnVentas.ImageList = this.imageList1;
            this.btnVentas.Location = new System.Drawing.Point(75, 53);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(110, 82);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 360);
            this.Controls.Add(this.Pnl_contenido);
            this.Controls.Add(this.Pnl_barraestado);
            this.Controls.Add(this.Pnl_titulo);
            this.Controls.Add(this.Pnl_opciones);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Principal";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.Pnl_opciones.ResumeLayout(false);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.Pnl_barraestado.ResumeLayout(false);
            this.Pnl_barraestado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pnl_contenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_opciones;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Panel Pnl_barraestado;
        private System.Windows.Forms.Panel Pnl_contenido;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Label lbl_nombre_us;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDescripcion_ru;
        private System.Windows.Forms.Button btnCerrarsesion;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnEmpresa;
    }
}