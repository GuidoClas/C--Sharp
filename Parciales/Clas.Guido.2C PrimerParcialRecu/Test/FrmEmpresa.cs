using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Importador;

namespace Test
{
    public partial class FrmEmpresa : Form
    {
        private Empresa empresa;

        public FrmEmpresa()
        {
            InitializeComponent();
            this.empresa = new Empresa("Samsung", 3);
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            this.cmbOrigen.DataSource = Enum.GetValues(typeof(Producto.Origen));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto.Origen origen;
            string nombre;
            int valorDeCompra;
            bool descuento;

            int.TryParse(this.txtValorCompra.Text, out valorDeCompra);
            nombre = this.txtNombre.Text;
            Enum.TryParse<Producto.Origen>(this.cmbOrigen.SelectedValue.ToString(), out origen);
            descuento = this.rdDescuento.Checked;

            Producto p;

            if(this.rdLinea.Checked)
            {
                p = new LineaBlanca(nombre, valorDeCompra, origen, descuento);
            }
            else
            {
                p = new Smartphone(nombre, valorDeCompra, origen);
            }

            this.empresa += p;

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FrmMostrar f = new FrmMostrar(this.empresa.ToString());
            f.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = string.Empty;
            this.txtValorCompra.Text = string.Empty;
            this.rdDescuento.Checked = false;
            this.rdLinea.Checked = false;
            this.rdSmart.Checked = false;
        }


    }
}
