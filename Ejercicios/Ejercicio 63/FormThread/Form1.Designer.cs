namespace FormThread
{
    partial class Form1
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
            this.rtbPracticas = new System.Windows.Forms.RichTextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.dateHora = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // rtbPracticas
            // 
            this.rtbPracticas.Location = new System.Drawing.Point(12, 44);
            this.rtbPracticas.Name = "rtbPracticas";
            this.rtbPracticas.Size = new System.Drawing.Size(776, 394);
            this.rtbPracticas.TabIndex = 0;
            this.rtbPracticas.Text = "";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(13, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(35, 13);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "label1";
            // 
            // dateHora
            // 
            this.dateHora.Location = new System.Drawing.Point(532, 13);
            this.dateHora.Name = "dateHora";
            this.dateHora.Size = new System.Drawing.Size(256, 20);
            this.dateHora.TabIndex = 2;
            this.dateHora.Value = new System.DateTime(2020, 11, 11, 21, 19, 2, 0);
            this.dateHora.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.rtbPracticas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPracticas;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dateHora;
    }
}

