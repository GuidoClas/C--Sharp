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
using Serializadores;

namespace FormCarrrera
{
    public partial class FrmGrilla : Form
    {
        private XmlSerializer<Carrera> serializador;
        private List<Carrera> listaCarreras;

        /// <summary>
        /// El constructor del formulario instanciara las listas permitiendo que sean usadas en el curso del funcionamiento.
        /// </summary>
        public FrmGrilla()
        {
            InitializeComponent();
            this.serializador = new XmlSerializer<Carrera>();
            this.listaCarreras = new List<Carrera>();
        }

        /// <summary>
        /// Deserializará el archivo xml para obtener la lista de carreras y guardarla en la lista del formulario.
        /// </summary>
        private void Deserializar()
        {
            try
            {
                this.serializador.Leer("Carreras.xml", out this.listaCarreras);
            }
            catch(ArchivosException)
            {
                MessageBox.Show("No existe un archivo o no hay carreras cargadas");
            }
        }
        /// <summary>
        /// El manejador del evento Load deserializará y cargara en el RichTextBox la lista de carreras bajo un formato.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGrilla_Load(object sender, EventArgs e)
        {
            this.Deserializar();
            this.rtbGrillaCarreras.Text = this.ToString();
        }
        /// <summary>
        /// Se encarga de presentar un formato para las carreras a mostrar, permitiendo entender al usuario 4 claves:
        /// Numero de carrera, quien ganó la carrera, por quien se apostó y cuanto se apostó.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if(this.listaCarreras != null)
            {
                int i = 1;

                foreach(Carrera c in this.listaCarreras)
                {
                    sb.AppendFormat("{0} - Ganador: {1} - Apostó a: {2} - Monto: {3}\n\n", i, c.Ganador, c.CorredorElegido, c.TotalApuestasPorPicada);
                    i++;
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// El manejador del boton Reporte determinará la diferencia de victorias entre ambos corredores, permitiendo dar un informe al jugador sobre quien ganó mas carreras,
        /// por ende, el mas confiable al momento de apostar a un corredor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReporte_Click(object sender, EventArgs e)
        {
            int t = 0;
            int w = 0;
            int dif = 0;

            if(this.listaCarreras != null)
            {
                foreach (Carrera c in this.listaCarreras)
                {
                    if (c.Ganador == "Toretto")
                    {
                        t++;
                    }
                    else
                    {
                        w++;
                    }
                }

                if (t > w)
                {
                    dif = t - w;
                    MessageBox.Show(String.Format("Toretto ganó {0} picada/s más", dif));
                }
                else if (w > t)
                {
                    dif = w - t;
                    MessageBox.Show(String.Format("Paul Walker ganó {0} picada/s más", dif));
                }
                else
                {
                    MessageBox.Show("Estan empatados en picadas ganadas");
                }
            }
            else
            {
                MessageBox.Show("No hay picadas cargadas");
            }
            
        }
    }
}
