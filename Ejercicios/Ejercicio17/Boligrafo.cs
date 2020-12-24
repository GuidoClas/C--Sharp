using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            this.tinta += tinta;

            if(this.tinta < 0)
            {
                this.tinta = 0;
            }
            else if(this.tinta > 100)
            {
                this.Recargar();
            }
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool sePudoPintar = false;
            dibujo = "";
            this.SetTinta(gasto);

            if(this.GetTinta() > 0)
            {
                sePudoPintar = true;
                Console.ForegroundColor = this.GetColor();
                Console.WriteLine("Se pudo pintar!");
                dibujo = String.Concat((Enumerable.Repeat("*", gasto)));
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
           
            return sePudoPintar;
        }

    }
}
