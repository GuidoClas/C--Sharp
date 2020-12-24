using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected Fabricante fabricante;
        protected static Random generadorDeVelocidades;
        protected string modelo;
        protected float precio;
        protected int velocidadMaxima;

        public int VelocidadMaxima
        {
            get 
            {
                if(this.velocidadMaxima == 0)
                {
                    Vehiculo.generadorDeVelocidades = new Random();
                    this.velocidadMaxima = Vehiculo.generadorDeVelocidades.Next(100, 280);

                }
                return this.velocidadMaxima;
            }         
        }

        static Vehiculo()
        {

        }

        public Vehiculo(float precio, string modelo, Fabricante fabri)
        {
            this.precio = precio;
            this.modelo = modelo;
            this.fabricante = fabri;
        }

        public Vehiculo(string marca, EPais pais, string modelo, float precio) : this(precio, modelo, new Fabricante(marca, pais))
        {
        }

        private static string Mostrar(Vehiculo v)
        {
            StringBuilder sb = new StringBuilder();
            string fabri = v.fabricante; 
            sb.AppendFormat("Fabricante: {0}\n", fabri);
            sb.AppendFormat("Modelo: {0}\n", v.modelo);
            sb.AppendFormat("Precio: {0}\n", v.precio);
            sb.AppendFormat("Vel Maxima: {0}\n", v.VelocidadMaxima);

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo a, Vehiculo b)
        {
            bool retorno = false;

            if (((object)a) == null && ((object)b) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)a) != null && ((object)b) != null)
                {
                    if (a.modelo == b.modelo && a.fabricante == b.fabricante)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }

        public static explicit operator string(Vehiculo f)
        {
            return Vehiculo.Mostrar(f);
        }
    }
}
