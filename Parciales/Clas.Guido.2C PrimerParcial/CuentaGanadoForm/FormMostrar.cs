using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CuentaGanadoForm
{
    public partial class FormMostrar : Form
    {
        public FormMostrar(string datos)
        {
            InitializeComponent();
            rtbSalidaDeTest.Text = datos;
        }
    }
}
