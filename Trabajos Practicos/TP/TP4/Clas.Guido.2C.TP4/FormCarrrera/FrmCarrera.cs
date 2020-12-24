using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Entidades;
using Serializadores;
using SQL;

namespace FormCarrrera
{
    public partial class FrmCarrera : Form
    {
        public delegate void Callback();

        private List<Thread> threadsCarrera;
        private List<Carrera> carreras;

        private Auto corredorUno;
        private Auto corredorDos;
        private Auto ganador;

        private string corredorElegido;
        private int montoApuesta;
        private int miDinero;

        public List<Carrera> ListaCarreras { get => this.carreras; }
        public int MiDinero { get => miDinero; set => miDinero = value; }

        /// <summary>
        /// El constructor del form, buscara dentro del directorio del proyecto, las imagenes que permiten la funcionalidad del form y estetica.
        /// Inicializara los atributos correspondientes y los asignara.
        /// Recibe del form principal, el corredor elegido, el monto que se apostó a ese corredor, y el dinero actual del usuario para poder efectuar los calculos correspondientes
        /// y luego actualizarlos para que el form principal acceda.
        /// </summary>
        public FrmCarrera(string corredorElegido, int montoApuesta, int miDinero)
        {
            InitializeComponent();

            string pathFondo = Directory.GetCurrentDirectory() + "\\Recursos\\ImagenFondo2.jpg";
            string pathAuto1 = Directory.GetCurrentDirectory() + "\\Recursos\\Auto1.png";
            string pathAuto2 = Directory.GetCurrentDirectory() + "\\Recursos\\Auto2.png";

            Bitmap imgFondo = new Bitmap(pathFondo);
            Bitmap auto1 = new Bitmap(pathAuto1);
            Bitmap auto2 = new Bitmap(pathAuto2);

            this.BackgroundImage = imgFondo;
            this.pb_Auto1.Image = auto1;
            this.pb_Auto2.Image = auto2;

            this.corredorUno = new Auto("Toretto", 200, 1);
            this.corredorDos = new Auto("PaulWalker", 200, 2);

            this.threadsCarrera = new List<Thread>();
            this.carreras = new List<Carrera>();

            this.corredorElegido = corredorElegido;
            this.montoApuesta = montoApuesta;
            this.MiDinero = miDinero;

            this.btnSalir.Enabled = false;
        }
        
        /// <summary>
        /// Iniciar picada comienza el Timer, coloca al ganador en nulo, suscribe ambos corredores a Picada, y crea un hilo por cada auto/carril.
        /// Luego, iniciará los threads para comenzar la picada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIniciarPicada_Click(object sender, EventArgs e)
        {
                this.ganador = null;
                this.timer1.Start();

                this.corredorUno.Trayecto += this.Picada;
                this.corredorDos.Trayecto += this.Picada;

                this.threadsCarrera.Add(new Thread(this.corredorUno.Comenzar));
                this.threadsCarrera.Add(new Thread(this.corredorDos.Comenzar));

                
                foreach (Thread t in this.threadsCarrera)
                {
                    t.Start();
                }
                
                this.btnIniciarPicada.Enabled = false;   
        }
        /// <summary>
        /// El metodo ReiniciarPuestos se encarga de llamar al metodo FinalizarPicada para abortar todos los hilos,
        /// finalizando la picada. A su vez debe permitir que cada auto vuelva a su posición inicial.
        /// </summary>
        private void ReiniciarPuestos()
        {
            this.FinalizarPicada();

            if (this.pb_Auto1.InvokeRequired)
            {
                Callback callback = new Callback(ReiniciarPuestos);
                this.Invoke(callback);
            }
            else
            {
                this.pb_Auto1.Location = new Point(0, this.pb_Auto1.Location.Y);
                this.pb_Auto2.Location = new Point(0, this.pb_Auto2.Location.Y);
            }
            
        }

        /// <summary>
        /// El metodo FinalizarPicada tiene como funcion recorrer cada hilo de la lista de hilos, y abortar cada uno, por ultimo limpia la lista de elementos.
        /// </summary>
        public void FinalizarPicada()
        {
            foreach (Thread t in this.threadsCarrera)
            {
                if (t != null && t.IsAlive)
                {
                    t.Abort();
                }
            }

            this.threadsCarrera.Clear();
        }
        /// <summary>
        /// El metodo determina que corredor ganó la carrera, a partir del nombre del corredor que recibe como parametro, verificando antes que sea el primer y unico ganador.
        /// Para esto asignara al objeto llamado "ganador", el objeto ganador, actualizará el dinero, y agregara la carrera a una lista de carreras.
        /// </summary>
        /// <param name="corredor"></param>
        private void Ganador(string corredor)
        {
            this.btnSalir.Enabled = true;
            this.timer1.Stop();
            this.FinalizarPicada();

            if (this.ganador == null)
            {
                if (corredor == this.corredorUno.NombreCorredor)
                {
                    this.ganador = this.corredorUno;

                    if(this.corredorElegido == this.corredorUno.NombreCorredor)
                    {
                        this.MiDinero = this.MiDinero + this.montoApuesta;
                        Carrera c = new Carrera(corredor, corredor, this.montoApuesta);
                        this.carreras.Add(c);
                    }
                    else
                    {
                        this.MiDinero = this.MiDinero - this.montoApuesta;
                        Carrera c = new Carrera(corredor, this.corredorDos.NombreCorredor, this.montoApuesta);
                        this.carreras.Add(c);
                    }
                    
                    MessageBox.Show("GANO TORETTO!");
                }
                else
                {
                    this.ganador = this.corredorDos;

                    if (this.corredorElegido == this.corredorDos.NombreCorredor)
                    {
                        this.MiDinero = this.MiDinero + this.montoApuesta;
                        Carrera c = new Carrera(corredor, corredor, this.montoApuesta);
                        this.carreras.Add(c);
                    }
                    else
                    {
                        this.MiDinero = this.MiDinero - this.montoApuesta;
                        Carrera c = new Carrera(corredor, this.corredorUno.NombreCorredor, this.montoApuesta);
                        this.carreras.Add(c);
                    }

                    MessageBox.Show("GANO WALKER!");
                }
            }
        }

        /// <summary>
        /// VerificarSiGana tiene como funcionalidad verificar si algun PictureBox(auto) llega al final del trayecto (el borde calculado del form),
        /// luego, en caso de que ese borde sea intersecado, invocara al metodo para verificar cual de los corredores es el que ganó.
        /// </summary>
        /// <param name="auto"></param>
        /// <param name="corredor"></param>
        private void VerificarSiGana(PictureBox auto, string corredor)
        {
            int tamañoForm = this.Size.Width;
            int lineaFinal = tamañoForm - 200;
            int posicionActual = auto.Location.X;
            
            if (posicionActual > lineaFinal)
            {
                this.Ganador(corredor);
            }
        }

        /// <summary>
        /// El metodo Picada es al cual los corredores se suscriben, y permitirá comenzar a verificar el trayecto de los corredores, verificando cada uno de los dos carriles.
        /// Además, se encargará de capturar la excepcion PicadaInterrumpidaException, y evitar que rompa el programa.
        /// </summary>
        /// <param name="avance"></param>
        /// <param name="carril"></param>
        /// 
        private void Picada(string corredor)
        {
            try
            {
                if (this.pb_Auto1.InvokeRequired)
                {
                    CorrePicada callbackPicada = new CorrePicada(Picada);
                    object [] args = { corredor };
                    this.Invoke(callbackPicada, args);
                }
                else
                {
                    if (corredor == this.corredorUno.NombreCorredor)
                    {
                        this.VerificarSiGana(this.pb_Auto1, corredor);
                    }

                    if (corredor == this.corredorDos.NombreCorredor)
                    {
                        this.VerificarSiGana(this.pb_Auto2, corredor);
                    }
                }
            }
            catch(PicadaInterrumpidaException ex)
            {
                this.timer1.Stop();
                this.ReiniciarPuestos();
                MessageBox.Show(ex.Message);
            }
        }
       
        /// <summary>
        /// El manejador del evento Tick del Timer, de manera constante se encargará de mover los PictureBox(autos), en base a su velocidadPunta,
        /// agregandole un extra de aceleración con el factor Random, para que las carreras sean determinadas al azar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random sumarVelocidad = new Random();
            int movimientoAutoUno = (this.corredorUno.VelocidadPunta / 10) + sumarVelocidad.Next(10, 40);
            int movimientoAutoDos = (this.corredorDos.VelocidadPunta / 10) + sumarVelocidad.Next(10, 40);

            this.pb_Auto1.Location = new Point(this.pb_Auto1.Location.X + movimientoAutoUno, this.pb_Auto1.Location.Y);
            this.pb_Auto2.Location = new Point(this.pb_Auto2.Location.X + movimientoAutoDos, this.pb_Auto2.Location.Y);
        }

        /// <summary>
        /// De cerrarse el programa, se cuenta con la tranquilidad de que se abortan los hilos activos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCarrera_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Thread t in this.threadsCarrera)
            {
                if (t != null && t.IsAlive)
                {
                    t.Abort();
                }
            }
            
        }

        /// <summary>
        /// Cierra el programa automaticamente, devolverá un OK ya que es cerrado manualmente luego de la carrera, brindando una certeza y buen funcionamiento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        { 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
