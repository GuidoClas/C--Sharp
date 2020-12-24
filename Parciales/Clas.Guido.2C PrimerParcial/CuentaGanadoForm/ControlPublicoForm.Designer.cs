namespace CuentaGanadoForm
{
    partial class ControlPublicoForm
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
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblGente = new System.Windows.Forms.Label();
            this.btnInforme = new System.Windows.Forms.Button();
            this.nudEmpleados = new System.Windows.Forms.NumericUpDown();
            this.nudGente = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblEmpleados.Location = new System.Drawing.Point(70, 35);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(367, 76);
            this.lblEmpleados.TabIndex = 0;
            this.lblEmpleados.Text = "Empleados";
            // 
            // lblGente
            // 
            this.lblGente.AutoSize = true;
            this.lblGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblGente.Location = new System.Drawing.Point(70, 162);
            this.lblGente.Name = "lblGente";
            this.lblGente.Size = new System.Drawing.Size(215, 76);
            this.lblGente.TabIndex = 1;
            this.lblGente.Text = "Gente";
            // 
            // btnInforme
            // 
            this.btnInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnInforme.Location = new System.Drawing.Point(559, 301);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(217, 62);
            this.btnInforme.TabIndex = 2;
            this.btnInforme.Text = "INFORME";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // nudEmpleados
            // 
            this.nudEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.nudEmpleados.Location = new System.Drawing.Point(559, 35);
            this.nudEmpleados.Name = "nudEmpleados";
            this.nudEmpleados.Size = new System.Drawing.Size(217, 83);
            this.nudEmpleados.TabIndex = 3;
            this.nudEmpleados.ValueChanged += new System.EventHandler(this.nudEmpleados_ValueChanged);
            // 
            // nudGente
            // 
            this.nudGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.nudGente.Location = new System.Drawing.Point(559, 160);
            this.nudGente.Name = "nudGente";
            this.nudGente.Size = new System.Drawing.Size(217, 83);
            this.nudGente.TabIndex = 4;
            this.nudGente.ValueChanged += new System.EventHandler(this.nudGente_ValueChanged);
            // 
            // ControlPublicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.nudGente);
            this.Controls.Add(this.nudEmpleados);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.lblGente);
            this.Controls.Add(this.lblEmpleados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlPublicoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblGente;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.NumericUpDown nudEmpleados;
        private System.Windows.Forms.NumericUpDown nudGente;
    }
}

