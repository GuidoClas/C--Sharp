using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        static int cantRuedas = 4;
        private string nombreCorredor;
        public string NombreCorredor { get => nombreCorredor; set => nombreCorredor = value; }

        public Auto(string nombreCorredor, int velocidadPunta, int carril)
            :base(carril, Auto.cantRuedas, velocidadPunta)
        {
            this.NombreCorredor = nombreCorredor;
        }
        
        /// <summary>
        /// El metodo comenzar, dentro del bucle, solo invocará al metodo que a su vez invoca al evento Trayecto, y luego "pondra a dormir" el hilo actual.
        /// </summary>
        public void Comenzar()
        {
            while (true)
            {
                base.CaptarTrayecto(this.NombreCorredor);
                Thread.Sleep(75);
            } 
        }
        
    }
}
