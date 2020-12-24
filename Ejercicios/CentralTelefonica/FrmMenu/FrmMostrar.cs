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
    public partial class FrmMostrar : Form
    {
        private TipoLlamada tipo;
        protected Centralita centralita;
        
        public FrmMostrar(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
        }

        public TipoLlamada Tipo
        {
            set 
            {
                this.tipo = value;
            } 
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            switch(tipo)
            {
                case TipoLlamada.Local:
                    this.richTextBox1.Text = this.centralita.GananciasPorLocal.ToString();
                    break;
                case TipoLlamada.Provincial:
                    this.richTextBox1.Text = this.centralita.GananciasPorProvincial.ToString();
                    break;
                case TipoLlamada.Todas:
                    this.richTextBox1.Text = this.centralita.GananciasPorTotal.ToString();
                    break;
                default:
                    break;  
            }
        }
    }
}
