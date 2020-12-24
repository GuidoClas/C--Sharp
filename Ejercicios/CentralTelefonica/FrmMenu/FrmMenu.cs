using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace FrmMenu
{
    public partial class FrmMenu : Form
    {
        public Centralita centralita;
        public FrmMenu()
        {
            InitializeComponent();    
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(this.centralita);
            llamador.ShowDialog();
            this.centralita = llamador.Centralita;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.centralita = new Centralita("Nextel");
        }

        private void GenerarFormInforme(TipoLlamada tipo)
        {
            FrmMostrar mostrar = new FrmMostrar(this.centralita);
            mostrar.Tipo = tipo;
            mostrar.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            this.GenerarFormInforme(TipoLlamada.Todas);
            
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            this.GenerarFormInforme(TipoLlamada.Local);
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            this.GenerarFormInforme(TipoLlamada.Provincial);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
