
namespace FormCarrrera
{
    partial class FrmCentroApuestas
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
            this.btnObservarPicada = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVerGrilla = new System.Windows.Forms.Button();
            this.grpApuestas = new System.Windows.Forms.GroupBox();
            this.cmbCorredor = new System.Windows.Forms.ComboBox();
            this.lblCorredor = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.nudMontoApuesta = new System.Windows.Forms.NumericUpDown();
            this.lblMiDinero = new System.Windows.Forms.Label();
            this.lblSigno = new System.Windows.Forms.Label();
            this.lblDinero = new System.Windows.Forms.Label();
            this.grpGrillas = new System.Windows.Forms.GroupBox();
            this.btnGuardarGrilla = new System.Windows.Forms.Button();
            this.grpDinero = new System.Windows.Forms.GroupBox();
            this.btnRetirarse = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpApuestas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoApuesta)).BeginInit();
            this.grpGrillas.SuspendLayout();
            this.grpDinero.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnObservarPicada
            // 
            this.btnObservarPicada.BackColor = System.Drawing.Color.DimGray;
            this.btnObservarPicada.ForeColor = System.Drawing.SystemColors.Info;
            this.btnObservarPicada.Location = new System.Drawing.Point(51, 283);
            this.btnObservarPicada.Name = "btnObservarPicada";
            this.btnObservarPicada.Size = new System.Drawing.Size(190, 41);
            this.btnObservarPicada.TabIndex = 0;
            this.btnObservarPicada.Text = "Observar Picada";
            this.btnObservarPicada.UseVisualStyleBackColor = false;
            this.btnObservarPicada.Click += new System.EventHandler(this.btnObservarPicada_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTitulo.Location = new System.Drawing.Point(372, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(299, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Centro de Apuestas";
            // 
            // btnVerGrilla
            // 
            this.btnVerGrilla.BackColor = System.Drawing.Color.DimGray;
            this.btnVerGrilla.Location = new System.Drawing.Point(20, 64);
            this.btnVerGrilla.Name = "btnVerGrilla";
            this.btnVerGrilla.Size = new System.Drawing.Size(190, 41);
            this.btnVerGrilla.TabIndex = 2;
            this.btnVerGrilla.Text = "Ver Grilla";
            this.btnVerGrilla.UseVisualStyleBackColor = false;
            this.btnVerGrilla.Click += new System.EventHandler(this.btnVerGrilla_Click);
            // 
            // grpApuestas
            // 
            this.grpApuestas.BackColor = System.Drawing.Color.Transparent;
            this.grpApuestas.Controls.Add(this.cmbCorredor);
            this.grpApuestas.Controls.Add(this.lblCorredor);
            this.grpApuestas.Controls.Add(this.btnObservarPicada);
            this.grpApuestas.Controls.Add(this.lblMonto);
            this.grpApuestas.Controls.Add(this.nudMontoApuesta);
            this.grpApuestas.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpApuestas.ForeColor = System.Drawing.SystemColors.Info;
            this.grpApuestas.Location = new System.Drawing.Point(383, 98);
            this.grpApuestas.Name = "grpApuestas";
            this.grpApuestas.Size = new System.Drawing.Size(288, 362);
            this.grpApuestas.TabIndex = 3;
            this.grpApuestas.TabStop = false;
            this.grpApuestas.Text = "Sección Apuestas";
            // 
            // cmbCorredor
            // 
            this.cmbCorredor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCorredor.FormattingEnabled = true;
            this.cmbCorredor.Location = new System.Drawing.Point(15, 108);
            this.cmbCorredor.Name = "cmbCorredor";
            this.cmbCorredor.Size = new System.Drawing.Size(121, 33);
            this.cmbCorredor.TabIndex = 5;
            // 
            // lblCorredor
            // 
            this.lblCorredor.AutoSize = true;
            this.lblCorredor.Location = new System.Drawing.Point(12, 59);
            this.lblCorredor.Name = "lblCorredor";
            this.lblCorredor.Size = new System.Drawing.Size(104, 25);
            this.lblCorredor.TabIndex = 4;
            this.lblCorredor.Text = "Corredor";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(12, 177);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(234, 25);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto de la Apuesta";
            // 
            // nudMontoApuesta
            // 
            this.nudMontoApuesta.Location = new System.Drawing.Point(16, 213);
            this.nudMontoApuesta.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.nudMontoApuesta.Name = "nudMontoApuesta";
            this.nudMontoApuesta.ReadOnly = true;
            this.nudMontoApuesta.Size = new System.Drawing.Size(120, 33);
            this.nudMontoApuesta.TabIndex = 0;
            this.nudMontoApuesta.ValueChanged += new System.EventHandler(this.nudMontoApuesta_ValueChanged);
            // 
            // lblMiDinero
            // 
            this.lblMiDinero.AutoSize = true;
            this.lblMiDinero.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiDinero.Location = new System.Drawing.Point(6, 59);
            this.lblMiDinero.Name = "lblMiDinero";
            this.lblMiDinero.Size = new System.Drawing.Size(109, 24);
            this.lblMiDinero.TabIndex = 4;
            this.lblMiDinero.Text = "Mi dinero:";
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigno.Location = new System.Drawing.Point(121, 59);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(23, 24);
            this.lblSigno.TabIndex = 5;
            this.lblSigno.Text = "$";
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinero.Location = new System.Drawing.Point(166, 61);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(0, 24);
            this.lblDinero.TabIndex = 6;
            // 
            // grpGrillas
            // 
            this.grpGrillas.BackColor = System.Drawing.Color.Transparent;
            this.grpGrillas.Controls.Add(this.btnGuardarGrilla);
            this.grpGrillas.Controls.Add(this.btnVerGrilla);
            this.grpGrillas.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGrillas.ForeColor = System.Drawing.SystemColors.Info;
            this.grpGrillas.Location = new System.Drawing.Point(37, 95);
            this.grpGrillas.Name = "grpGrillas";
            this.grpGrillas.Size = new System.Drawing.Size(235, 231);
            this.grpGrillas.TabIndex = 7;
            this.grpGrillas.TabStop = false;
            this.grpGrillas.Text = "Sección Grillas";
            // 
            // btnGuardarGrilla
            // 
            this.btnGuardarGrilla.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardarGrilla.Location = new System.Drawing.Point(20, 147);
            this.btnGuardarGrilla.Name = "btnGuardarGrilla";
            this.btnGuardarGrilla.Size = new System.Drawing.Size(190, 66);
            this.btnGuardarGrilla.TabIndex = 3;
            this.btnGuardarGrilla.Text = "Guardar Grilla en BBDD";
            this.btnGuardarGrilla.UseVisualStyleBackColor = false;
            this.btnGuardarGrilla.Click += new System.EventHandler(this.btnGuardarGrilla_Click);
            // 
            // grpDinero
            // 
            this.grpDinero.BackColor = System.Drawing.Color.Transparent;
            this.grpDinero.Controls.Add(this.btnRetirarse);
            this.grpDinero.Controls.Add(this.lblMiDinero);
            this.grpDinero.Controls.Add(this.lblSigno);
            this.grpDinero.Controls.Add(this.lblDinero);
            this.grpDinero.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDinero.ForeColor = System.Drawing.SystemColors.Info;
            this.grpDinero.Location = new System.Drawing.Point(787, 98);
            this.grpDinero.Name = "grpDinero";
            this.grpDinero.Size = new System.Drawing.Size(244, 231);
            this.grpDinero.TabIndex = 8;
            this.grpDinero.TabStop = false;
            this.grpDinero.Text = "Mi Cuenta";
            // 
            // btnRetirarse
            // 
            this.btnRetirarse.BackColor = System.Drawing.Color.DimGray;
            this.btnRetirarse.Location = new System.Drawing.Point(10, 134);
            this.btnRetirarse.Name = "btnRetirarse";
            this.btnRetirarse.Size = new System.Drawing.Size(219, 55);
            this.btnRetirarse.TabIndex = 7;
            this.btnRetirarse.Text = "Retirarse";
            this.btnRetirarse.UseVisualStyleBackColor = false;
            this.btnRetirarse.Click += new System.EventHandler(this.btnRetirarse_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DimGray;
            this.btnSalir.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSalir.Location = new System.Drawing.Point(833, 429);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(219, 53);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir del Centro";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmCentroApuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 494);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpDinero);
            this.Controls.Add(this.grpGrillas);
            this.Controls.Add(this.grpApuestas);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCentroApuestas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centro de Apuestas";
            this.Load += new System.EventHandler(this.FrmCentroApuestas_Load);
            this.grpApuestas.ResumeLayout(false);
            this.grpApuestas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoApuesta)).EndInit();
            this.grpGrillas.ResumeLayout(false);
            this.grpDinero.ResumeLayout(false);
            this.grpDinero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObservarPicada;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVerGrilla;
        private System.Windows.Forms.GroupBox grpApuestas;
        private System.Windows.Forms.Label lblCorredor;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.NumericUpDown nudMontoApuesta;
        private System.Windows.Forms.ComboBox cmbCorredor;
        private System.Windows.Forms.Label lblMiDinero;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.GroupBox grpGrillas;
        private System.Windows.Forms.Button btnGuardarGrilla;
        private System.Windows.Forms.GroupBox grpDinero;
        private System.Windows.Forms.Button btnRetirarse;
        private System.Windows.Forms.Button btnSalir;
    }
}