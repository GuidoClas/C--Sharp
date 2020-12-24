using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class FrmMostrar : Form
    {
        private string datos;
        public FrmMostrar(string datosEmpresa)
        {
            InitializeComponent();
            this.datos = datosEmpresa;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            this.rtbDatos.Text = this.datos;
        }
    }
}
