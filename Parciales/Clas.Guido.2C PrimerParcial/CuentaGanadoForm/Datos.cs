using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentaGanadoForm
{
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        public string Dni 
        {
            get 
            {
                return txtDni.Text;
            }
        }
        public string Nombre
        {
            get
            {
                return txtNombre.Text;
            }
        }
        public string Edad
        {
            get
            {
                return txtEdad.Text;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
