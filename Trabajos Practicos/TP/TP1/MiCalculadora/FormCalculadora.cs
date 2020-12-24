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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificando que no sea una tecla distinta a un numero
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        
        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
       
        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(textNumero1.Text, textNumero2.Text, cmbOperador.Text).ToString();
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }

        static private double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Numero(numero1), new Numero(numero2), operador);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            textNumero1.Clear();
            textNumero2.Clear();
            cmbOperador.SelectedIndex = -1;
            lblResultado.Text = "";
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero resultado = new Numero(lblResultado.Text);

            lblResultado.Text = resultado.DecimalBinario(lblResultado.Text);

            btnConvertirADecimal.Enabled = lblResultado.Text != "Valor invalido" && !string.IsNullOrEmpty(lblResultado.Text) ? true : false;
            btnConvertirABinario.Enabled = false;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero resultado = new Numero(lblResultado.Text);
            
            lblResultado.Text = resultado.BinarioDecimal(lblResultado.Text);

            btnConvertirABinario.Enabled = lblResultado.Text != "Valor invalido" && !string.IsNullOrEmpty(lblResultado.Text) ? true : false;
            btnConvertirADecimal.Enabled = false;
        }
    }
}
