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
    public partial class ControlPublicoForm : Form
    {
        private Bar bar;
        public ControlPublicoForm()
        {
            InitializeComponent();
            this.bar = Bar.GetBar();
        }
      
        private void nudEmpleados_ValueChanged(object sender, EventArgs e)
        {
            if (nudEmpleados.Value > this.bar.Empleados.Count)
            {
                Datos datosForm = new Datos();
                if(datosForm.ShowDialog() == DialogResult.OK)
                {
                    bool respuesta;
                    short edad;
                    int dni;

                    short.TryParse(datosForm.Edad, out edad);
                    int.TryParse(datosForm.Dni, out dni);

                    respuesta = this.bar + new Empleado(datosForm.Nombre, edad, dni);
                    if(respuesta)
                    {
                        MessageBox.Show("Empleado agregado!");
                    }
                    else
                    {
                        MessageBox.Show("Error, no se pudo agregar");
                        nudEmpleados.ValueChanged -= nudEmpleados_ValueChanged;
                        nudEmpleados.Value--;
                        nudEmpleados.ValueChanged += nudEmpleados_ValueChanged;
                    }
                }

            }
            else
            {
                if (nudEmpleados.Value < 1)
                {
                    nudEmpleados.Value = 0;
                }
                else
                {
                    bar.Empleados.RemoveAt(this.bar.Empleados.Count - 1);
                    MessageBox.Show("Empleado eliminado");
                }
               
            }
            this.nudEmpleados.Value = this.bar.Empleados.Count;
        }

        private void nudGente_ValueChanged(object sender, EventArgs e)
        {
            //Se suma Gente si cumple
            if (nudGente.Value > this.bar.Gente.Count)
            {
                Datos datosForm = new Datos();
                if (datosForm.ShowDialog() == DialogResult.OK)
                {
                    bool respuesta;
                    short edad;

                    short.TryParse(datosForm.Edad, out edad);

                    respuesta = this.bar + new Gente(edad);

                    if (respuesta)
                    {
                        MessageBox.Show("Gente agregada!");
                    }
                    else
                    {
                        MessageBox.Show("Error, no se pudo agregar");
                        nudGente.ValueChanged -= nudGente_ValueChanged;
                        nudGente.Value--;
                        nudGente.ValueChanged += nudGente_ValueChanged;
                    }
                }
            }
            else
            {
                if (nudGente.Value < 1)
                {
                    nudGente.Value = 0;
                }
                else
                {
                    this.bar.Gente.RemoveAt(0);
                    MessageBox.Show("Gente eliminada");
                }
            }
            this.nudGente.Value = this.bar.Gente.Count;
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            FormMostrar formMostrar = new FormMostrar(this.bar.ToString());
            DialogResult result = formMostrar.ShowDialog();
        }
    }
}
