using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private int nota1;
        private int nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public void CalcularFinal()
        {
            Random notaF = new Random();

            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = notaF.Next(1, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(int notaUno, int notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void Mostrar()
        {
            
            if(notaFinal != -1)
            {
                Console.WriteLine("{0,1}      {1,1}       {2,-1}         {3,-1}        {4,-1}        {5,-1}", this.legajo, this.nombre, this.apellido, this.nota1, this.nota2, this.notaFinal);
            }
            else
            {
                Console.WriteLine("{0}      {1,1}       {2,-1}         {3,-1}        {4,-1}        {5,-1}", this.legajo, this.nombre, this.apellido, this.nota1, this.nota2, "Alumno desaprobado");
            }  
        }
    }
}
