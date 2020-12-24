namespace Test
{
    partial class FrmEmpresa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.rdLinea = new System.Windows.Forms.RadioButton();
            this.rdSmart = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblValorDeCompra = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDescuento = new System.Windows.Forms.RadioButton();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(252, 191);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(268, 49);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 335);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(257, 51);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar Productos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // rdLinea
            // 
            this.rdLinea.AutoSize = true;
            this.rdLinea.Location = new System.Drawing.Point(153, 44);
            this.rdLinea.Name = "rdLinea";
            this.rdLinea.Size = new System.Drawing.Size(115, 24);
            this.rdLinea.TabIndex = 6;
            this.rdLinea.TabStop = true;
            this.rdLinea.Text = "LineaBlanca";
            this.rdLinea.UseVisualStyleBackColor = true;
            // 
            // rdSmart
            // 
            this.rdSmart.AutoSize = true;
            this.rdSmart.Location = new System.Drawing.Point(17, 44);
            this.rdSmart.Name = "rdSmart";
            this.rdSmart.Size = new System.Drawing.Size(115, 24);
            this.rdSmart.TabIndex = 5;
            this.rdSmart.TabStop = true;
            this.rdSmart.Text = "Smartphone";
            this.rdSmart.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(16, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(16, 219);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(192, 21);
            this.cmbOrigen.TabIndex = 3;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(16, 138);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(191, 20);
            this.txtValorCompra.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombre.Location = new System.Drawing.Point(12, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // lblValorDeCompra
            // 
            this.lblValorDeCompra.AutoSize = true;
            this.lblValorDeCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblValorDeCompra.Location = new System.Drawing.Point(12, 103);
            this.lblValorDeCompra.Name = "lblValorDeCompra";
            this.lblValorDeCompra.Size = new System.Drawing.Size(131, 20);
            this.lblValorDeCompra.TabIndex = 12;
            this.lblValorDeCompra.Text = "Valor De Compra";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOrigen.Location = new System.Drawing.Point(12, 182);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(56, 20);
            this.lblOrigen.TabIndex = 13;
            this.lblOrigen.Text = "Origen";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(290, 333);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(230, 53);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdSmart);
            this.groupBox1.Controls.Add(this.rdLinea);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(252, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 133);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de producto";
            // 
            // rdDescuento
            // 
            this.rdDescuento.AutoSize = true;
            this.rdDescuento.Location = new System.Drawing.Point(17, 298);
            this.rdDescuento.Name = "rdDescuento";
            this.rdDescuento.Size = new System.Drawing.Size(34, 17);
            this.rdDescuento.TabIndex = 4;
            this.rdDescuento.TabStop = true;
            this.rdDescuento.Text = "Si";
            this.rdDescuento.UseVisualStyleBackColor = true;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDescuento.Location = new System.Drawing.Point(12, 264);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(87, 20);
            this.lblDescuento.TabIndex = 14;
            this.lblDescuento.Text = "Descuento";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(252, 246);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(268, 49);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(538, 435);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.rdDescuento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblValorDeCompra);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de Productos";
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.RadioButton rdLinea;
        private System.Windows.Forms.RadioButton rdSmart;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblValorDeCompra;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

