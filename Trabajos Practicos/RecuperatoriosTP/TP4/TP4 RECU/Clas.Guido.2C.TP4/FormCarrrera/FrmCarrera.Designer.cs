
namespace FormCarrrera
{
    partial class FrmCarrera
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
            this.components = new System.ComponentModel.Container();
            this.pb_Auto1 = new System.Windows.Forms.PictureBox();
            this.pb_Auto2 = new System.Windows.Forms.PictureBox();
            this.btnIniciarPicada = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblGanador = new System.Windows.Forms.Label();
            this.lblSeparador1 = new System.Windows.Forms.Label();
            this.lblGanaPierde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Auto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Auto2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Auto1
            // 
            this.pb_Auto1.BackColor = System.Drawing.Color.Transparent;
            this.pb_Auto1.Location = new System.Drawing.Point(15, 27);
            this.pb_Auto1.Name = "pb_Auto1";
            this.pb_Auto1.Size = new System.Drawing.Size(200, 89);
            this.pb_Auto1.TabIndex = 0;
            this.pb_Auto1.TabStop = false;
            // 
            // pb_Auto2
            // 
            this.pb_Auto2.BackColor = System.Drawing.Color.Transparent;
            this.pb_Auto2.Location = new System.Drawing.Point(15, 135);
            this.pb_Auto2.Name = "pb_Auto2";
            this.pb_Auto2.Size = new System.Drawing.Size(200, 89);
            this.pb_Auto2.TabIndex = 1;
            this.pb_Auto2.TabStop = false;
            // 
            // btnIniciarPicada
            // 
            this.btnIniciarPicada.BackColor = System.Drawing.Color.DimGray;
            this.btnIniciarPicada.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPicada.ForeColor = System.Drawing.SystemColors.Info;
            this.btnIniciarPicada.Location = new System.Drawing.Point(262, 246);
            this.btnIniciarPicada.Name = "btnIniciarPicada";
            this.btnIniciarPicada.Size = new System.Drawing.Size(378, 56);
            this.btnIniciarPicada.TabIndex = 3;
            this.btnIniciarPicada.Text = "Iniciar Picada";
            this.btnIniciarPicada.UseVisualStyleBackColor = false;
            this.btnIniciarPicada.Click += new System.EventHandler(this.btnIniciarPicada_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DimGray;
            this.btnSalir.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSalir.Location = new System.Drawing.Point(741, 246);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(336, 56);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblGanador
            // 
            this.lblGanador.Location = new System.Drawing.Point(0, 0);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(100, 23);
            this.lblGanador.TabIndex = 0;
            // 
            // lblSeparador1
            // 
            this.lblSeparador1.BackColor = System.Drawing.Color.DimGray;
            this.lblSeparador1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparador1.Location = new System.Drawing.Point(15, 122);
            this.lblSeparador1.Name = "lblSeparador1";
            this.lblSeparador1.Size = new System.Drawing.Size(1271, 10);
            this.lblSeparador1.TabIndex = 16;
            this.lblSeparador1.Text = "\r\n";
            // 
            // lblGanaPierde
            // 
            this.lblGanaPierde.Location = new System.Drawing.Point(0, 0);
            this.lblGanaPierde.Name = "lblGanaPierde";
            this.lblGanaPierde.Size = new System.Drawing.Size(100, 23);
            this.lblGanaPierde.TabIndex = 0;
            // 
            // FrmCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1314, 331);
            this.Controls.Add(this.lblSeparador1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIniciarPicada);
            this.Controls.Add(this.pb_Auto2);
            this.Controls.Add(this.pb_Auto1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Picada en curso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCarrera_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Auto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Auto2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Auto1;
        private System.Windows.Forms.PictureBox pb_Auto2;
        private System.Windows.Forms.Button btnIniciarPicada;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.Label lblSeparador1;
        private System.Windows.Forms.Label lblGanaPierde;
    }
}

