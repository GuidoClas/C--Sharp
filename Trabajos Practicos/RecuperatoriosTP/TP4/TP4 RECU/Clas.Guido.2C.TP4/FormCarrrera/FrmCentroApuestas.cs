using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Entidades;
using Serializadores;
using SQL;

namespace FormCarrrera
{
    public partial class FrmCentroApuestas : Form
    {
        public enum Corredores { Toretto, PaulWalker }

        static bool flag;
        private XmlSerializer<List<Carrera>> ser;
        private List<Carrera> carreras;

        /// <summary>
        /// El constructor se encargará de cargar la estétitica del formulario, insertar los enumerados en el ComboBox, inicializar el dinero en 500 por defecto,
        /// e instanciar el resto de los atributos correspondientes.
        /// </summary>
        public FrmCentroApuestas()
        {
            InitializeComponent();

            string pathFondo1 = Directory.GetCurrentDirectory() + "\\Recursos\\ImagenFondo1.jpg";

            Bitmap imgFondo1 = new Bitmap(pathFondo1);
            this.BackgroundImage = imgFondo1;

            this.carreras = new List<Carrera>();
            this.ser = new XmlSerializer<List<Carrera>>();

            this.cmbCorredor.DataSource = Enum.GetValues(typeof(Corredores));

            this.lblDinero.Text = "500";

        }

        /// <summary>
        /// El manejador del boton Observar Picada obtendrá los datos correspondientes para instanciar al FrmCarrera, realizará las validaciones correspondientes antes de instanciarlo,
        /// Determinará luego que el FrmCarrera haya cumplido su función correctamente y en ese caso actualizará el dinero, hará un merge entre ambas listas, y guardará la lista en xml.
        /// En caso de que el jugador pierda todo su dinero, se cerrará el programa con un mensaje de salida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObservarPicada_Click(object sender, EventArgs e)
        {
            string corredorElegido = this.cmbCorredor.SelectedItem.ToString();
            int monto = int.Parse(this.nudMontoApuesta.Text);
            int maximo = int.Parse(this.lblDinero.Text);

            if(monto > 0 && monto <= maximo)
            {
                FrmCarrera form = new FrmCarrera(corredorElegido, monto, maximo);

                if (DialogResult.OK == form.ShowDialog())
                {
                    this.lblDinero.Text = form.MiDinero.ToString();
                    this.carreras.AddRange(form.ListaCarreras);
                    
                    this.ser.Guardar("Carreras.xml", this.carreras);
                    FrmCentroApuestas.flag = true;

                    if(int.Parse(this.lblDinero.Text) <= 0)
                    {
                        this.FinalizarJuego();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes apostar un numero entre 0 y tu dinero");
            }

        }

        /// <summary>
        /// El manejador del boton Ver Grilla instanciara y mostrará la grilla de carreras con sus datos y atributos correspondientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerGrilla_Click(object sender, EventArgs e)
        {
            FrmGrilla form = new FrmGrilla();
            form.ShowDialog();
        }

        /// <summary>
        /// El manejador del click del boton Guardar Grilla verificara antes que corresponda guardar la grilla en la base de datos, determinando si hay algo que guardar o no.
        /// En caso de que corresponda, leera la lista de picadas del XML, y verificará que sea la misma cantidad que se cuenta en la lista del form.
        /// Por ultimo, si es asi, se guardará en la base de datos la lista de carreras, y se establece el flag estatico en false para su proximo uso.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarGrilla_Click(object sender, EventArgs e)
        {
            if(FrmCentroApuestas.flag == true)
            {
                List<Carrera> aux1;
                List<Carrera> aux2;
                CarreraDao cdao = new CarreraDao();

                try
                {
                    aux1 = cdao.ListarCarreras();
            
                    this.ser.Leer("Carreras.xml", out aux2);

                    if(aux1.Count == aux2.Count)
                    {
                        MessageBox.Show("Ya están guardadas todas las picadas");
                    }
                    else
                    {
                        cdao.AgregarCarreras(aux2);
                        FrmCentroApuestas.flag = false;
                        MessageBox.Show("Guardado en Base de Datos con exito");
                    }
                }
                catch(ArchivosException)
                {
                    MessageBox.Show("Primero debes correr una picada para guardar");
                }
            }
            else
            {
                MessageBox.Show("Debes correr otra picada para actualizar la base de datos");
            }
        }

        /// <summary>
        /// El manejador del load, verificara que el archivo exista antes de deserializarlo en la lista de carreras, ya que sinó puede producir errores en tiempo de ejecución.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCentroApuestas_Load(object sender, EventArgs e)
        {
            if (File.Exists("Carreras.xml"))
            {
                this.ser.Leer("Carreras.xml", out this.carreras);
            }

            if(File.Exists("Dinero.txt"))
            {
                Texto text = new Texto();
                string dinero;
                text.Leer("Dinero.txt", out dinero);
                this.lblDinero.Text = dinero;
            }
        }

        /// <summary>
        /// El manejador del boton Retirarse, guardará en una archivo de texto el dinero actual del jugador, para permitir tener un conteo de su ultima jugada y cuanto dinero obtuvo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetirarse_Click(object sender, EventArgs e)
        {
            Texto text = new Texto();
            text.Guardar("Dinero.txt", this.lblDinero.Text);

            MessageBox.Show(String.Format("Te retiraste con {0} pesos!, se guardaron en el archivo Dinero.txt!", this.lblDinero.Text));
            this.Close();
        }

        /// <summary>
        /// Finaliza el juego si el jugador perdió todo su dinero.
        /// </summary>
        private void FinalizarJuego()
        {
             MessageBox.Show("Perdiste toda tu plata, juntá más y volvé!");
             this.Close();
        }

        /// <summary>
        /// Validación hacia el NumericUpDown, para que no se introduzcan valores no deseados o invalidos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudMontoApuesta_ValueChanged(object sender, EventArgs e)
        {
            if(this.nudMontoApuesta.Value > decimal.Parse(this.lblDinero.Text))
            {
                this.nudMontoApuesta.Value = int.Parse(this.lblDinero.Text);
                MessageBox.Show("Error, recordá que no podés apostar más de lo que tenés!");
            }
            
        }

        /// <summary>
        /// El manejador del boton Salir del Centro, cierra automaticamente el programa indicando que no se guardo el dinero del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu progreso no se guardó.");
            this.Close();
        }
    }
}
