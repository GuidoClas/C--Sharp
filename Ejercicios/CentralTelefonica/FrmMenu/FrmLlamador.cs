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
    public partial class FrmLlamador : Form
    {
        protected Centralita centralita;
        public FrmLlamador(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
        }

        public Centralita Centralita 
        {
            get
            {
                return this.centralita;
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if(this.txtNroDestino.Text.IndexOf('#') == 0)
            {
                this.cmbFranja.Enabled = true;
            }
            else
            {
                this.cmbFranja.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarNumero(string digit)
        {
            if(this.txtNroDestino.Text == "Nro Destino")
            {
                this.txtNroDestino.Text = string.Empty;
            }

            this.txtNroDestino.Text += digit;
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNum1.Text);
        }
        private void btnNum2_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNum2.Text);
        }
        private void btnNum3_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNum3.Text);
        }
        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnAsterisco.Text);
        }
        private void btnNumeral_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumeral.Text);
        }
        private void btnNum4_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNum4.Text);
        }
        private void btnNum5_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNum5.Text);
        }
        private void btnNum6_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNum6.Text);
        }
        private void btnNum7_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNum7.Text);
        }
        private void btnNum8_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNum8.Text);
        }
        private void btnNum9_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNum9.Text);
        }
        private void btnNum0_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNum0.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroOrigen.Text = "Nro Origen";
        }

        private void txtNroOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random nro = new Random();
            Llamada l1;
            string destino;
            string origen;
            Provincial.Franja franjas;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);

            destino = this.txtNroDestino.Text;
            origen = this.txtNroOrigen.Text;

            if(this.txtNroDestino.Text.IndexOf('#') == 0)
            {
                l1 = new Provincial(origen, franjas, nro.Next(1, 50), destino);
            }
            else
            {
                l1 = new Local(origen, nro.Next(1, 50), destino, nro.Next(0, 5));
            }

            this.centralita += l1;
        }
    }
}
