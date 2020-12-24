
namespace FormCarrrera
{
    partial class FrmGrilla
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
            this.rtbGrillaCarreras = new System.Windows.Forms.RichTextBox();
            this.lblGrilla = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbGrillaCarreras
            // 
            this.rtbGrillaCarreras.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGrillaCarreras.Location = new System.Drawing.Point(13, 59);
            this.rtbGrillaCarreras.Name = "rtbGrillaCarreras";
            this.rtbGrillaCarreras.ReadOnly = true;
            this.rtbGrillaCarreras.Size = new System.Drawing.Size(775, 379);
            this.rtbGrillaCarreras.TabIndex = 0;
            this.rtbGrillaCarreras.Text = "";
            // 
            // lblGrilla
            // 
            this.lblGrilla.AutoSize = true;
            this.lblGrilla.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrilla.Location = new System.Drawing.Point(13, 22);
            this.lblGrilla.Name = "lblGrilla";
            this.lblGrilla.Size = new System.Drawing.Size(181, 24);
            this.lblGrilla.TabIndex = 1;
            this.lblGrilla.Text = "Grilla de Carreras";
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(525, 13);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(263, 33);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Reporte de Carreras";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // FrmGrilla
            // 
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.lblGrilla);
            this.Controls.Add(this.rtbGrillaCarreras);
            this.Name = "FrmGrilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grilla";
            this.Load += new System.EventHandler(this.FrmGrilla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbGrillaCarreras;
        private System.Windows.Forms.Label lblGrilla;
        private System.Windows.Forms.Button btnReporte;
    }
}