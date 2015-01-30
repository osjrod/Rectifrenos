namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtutilidad = new System.Windows.Forms.TextBox();
            this.txtventa = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.seleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtimagen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.foto = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.abrir = new System.Windows.Forms.OpenFileDialog();
            this.guardar = new System.Windows.Forms.SaveFileDialog();
            this.txtCantidadMinima = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadMinima)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(146, 197);
            this.txtcantidad.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(120, 20);
            this.txtcantidad.TabIndex = 5;
            this.txtcantidad.ThousandsSeparator = true;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cantidad en Inventario:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Precio de costo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "+";
            // 
            // txtutilidad
            // 
            this.txtutilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtutilidad.Location = new System.Drawing.Point(158, 148);
            this.txtutilidad.Name = "txtutilidad";
            this.txtutilidad.Size = new System.Drawing.Size(120, 26);
            this.txtutilidad.TabIndex = 3;
            this.txtutilidad.Text = "0";
            this.txtutilidad.Click += new System.EventHandler(this.txtutilidad_Click);
            this.txtutilidad.TextChanged += new System.EventHandler(this.txtutilidad_TextChanged);
            this.txtutilidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtutilidad_KeyDown);
            this.txtutilidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtutilidad_KeyUp);
            // 
            // txtventa
            // 
            this.txtventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtventa.Location = new System.Drawing.Point(296, 148);
            this.txtventa.Name = "txtventa";
            this.txtventa.Size = new System.Drawing.Size(120, 26);
            this.txtventa.TabIndex = 4;
            this.txtventa.Text = "0";
            this.txtventa.Click += new System.EventHandler(this.txtventa_Click);
            this.txtventa.TextChanged += new System.EventHandler(this.txtventa_TextChanged);
            this.txtventa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtventa_KeyDown);
            this.txtventa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtventa_KeyUp);
            // 
            // txtcosto
            // 
            this.txtcosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcosto.Location = new System.Drawing.Point(21, 148);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(120, 26);
            this.txtcosto.TabIndex = 2;
            this.txtcosto.Text = "0";
            this.txtcosto.Click += new System.EventHandler(this.txtcosto_Click);
            this.txtcosto.TextChanged += new System.EventHandler(this.txtcosto_TextChanged);
            this.txtcosto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcosto_KeyDown);
            this.txtcosto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcosto_KeyUp);
            // 
            // seleccionar
            // 
            this.seleccionar.Location = new System.Drawing.Point(579, 275);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(113, 30);
            this.seleccionar.TabIndex = 7;
            this.seleccionar.Text = "Seleccionar foto";
            this.seleccionar.UseVisualStyleBackColor = true;
            this.seleccionar.Click += new System.EventHandler(this.seleccionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descripcion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidadMinima);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtimagen);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtutilidad);
            this.groupBox1.Controls.Add(this.txtventa);
            this.groupBox1.Controls.Add(this.txtcosto);
            this.groupBox1.Controls.Add(this.seleccionar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.foto);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 323);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // txtimagen
            // 
            this.txtimagen.Location = new System.Drawing.Point(442, 281);
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.Size = new System.Drawing.Size(100, 20);
            this.txtimagen.TabIndex = 29;
            this.txtimagen.Visible = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(294, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Precio de venta";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(155, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "% Utilidad";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(90, 78);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(327, 20);
            this.txtdescripcion.TabIndex = 1;
            this.txtdescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdescripcion_KeyDown);
            // 
            // foto
            // 
            this.foto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("foto.BackgroundImage")));
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto.Location = new System.Drawing.Point(442, 19);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(250, 250);
            this.foto.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Codigo de Articulo:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(117, 31);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(300, 20);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodigo_KeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(655, 341);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(68, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(581, 341);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(68, 30);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // abrir
            // 
            this.abrir.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";
            // 
            // txtCantidadMinima
            // 
            this.txtCantidadMinima.Location = new System.Drawing.Point(146, 228);
            this.txtCantidadMinima.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.txtCantidadMinima.Name = "txtCantidadMinima";
            this.txtCantidadMinima.Size = new System.Drawing.Size(120, 20);
            this.txtCantidadMinima.TabIndex = 30;
            this.txtCantidadMinima.ThousandsSeparator = true;
            this.txtCantidadMinima.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Cantidad Minima:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadMinima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtutilidad;
        public System.Windows.Forms.TextBox txtventa;
        public System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Button seleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Panel foto;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.OpenFileDialog abrir;
        private System.Windows.Forms.TextBox txtimagen;
        private System.Windows.Forms.SaveFileDialog guardar;
        private System.Windows.Forms.NumericUpDown txtCantidadMinima;
        private System.Windows.Forms.Label label8;

    }
}