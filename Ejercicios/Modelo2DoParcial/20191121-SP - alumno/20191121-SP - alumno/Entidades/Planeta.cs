using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void InformacionDeAvance(object sender, PlanetaEventArgs e);
    public class Planeta
    {
        private short velocidadTraslacion;
        private short posicionActual;
        private short radioRespectoSol;
        private object objetoAsociado;

        public Planeta()
        {

        }

        public Planeta(short velocidad, short posicion, short radioRespectoSol, object objetoVisual)
        {
            this.VelocidadTraslacion = velocidad;
            this.PosicionActual = posicion;
            this.objetoAsociado = objetoVisual;
            this.RadioRespectoSol = radioRespectoSol;
        }

        public short VelocidadTraslacion { get => velocidadTraslacion; set => velocidadTraslacion = value; }
        public short PosicionActual { get => posicionActual; set => posicionActual = value; }
        public short RadioRespectoSol { get => radioRespectoSol; set => radioRespectoSol = value; }

        public event InformacionDeAvance InformarAvance;

        /// <summary>
        /// PictureBox u objeto gráfico asociado al planeta.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public object ObjetoAsociado
        {
            get
            {
                return this.objetoAsociado;
            }
            set
            {
                this.objetoAsociado = value;
            }
        }


        /// <summary>
        /// Avance del planeta según su velocidad
        /// </summary>
        public short Avanzar()
        {
            this.PosicionActual += VelocidadTraslacion;
            return this.PosicionActual;
        }

        /// <summary>
        /// Simulación del movimiento del planeta
        /// </summary>
        public void AnimarSistemaSolar()
        {
            do
            {
                short avance = this.Avanzar();

                System.Threading.Thread.Sleep(60 + this.VelocidadTraslacion);

                if (!object.ReferenceEquals(this.InformarAvance, null))
                { 
                    this.InformarAvance.Invoke(this, new PlanetaEventArgs(avance, this.RadioRespectoSol));
                }

            } while (true);
        }
    }
}
