using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 07";

            DateTime fecha = DateTime.Now;
            int aniosVivo;
            int diasVivo;
            int contadorDiasDespuesDelCumple = 0;
            int contadorDiasPorMes = 0;
            int contadorDiasPorMes2 = 0;
            int[] meses = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

            // Pido la fecha de cumpleaños del usuario
            Console.WriteLine("Ingresa el año de tu nacimiento: ");
            int anioC = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el mes de tu nacimiento: ");
            int mesC = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el dia de tu nacimiento: ");
            int diaC = int.Parse(Console.ReadLine());


            aniosVivo = (fecha.Year) - anioC; //calculo edad


            if((mesC == fecha.Month && fecha.Day < diaC) || mesC > fecha.Month) //Verifico si cumplio o no
            {
                aniosVivo = aniosVivo-1; //Si no cumplió todavia, le resto un año a la cuenta

                diasVivo = aniosVivo * 365;
                diasVivo += aniosVivo / 4;

                contadorDiasDespuesDelCumple = meses[mesC - 1] - diaC + 1;

                for (int i=mesC; i < 12; i++) 
                {
                    contadorDiasPorMes += meses[i];
                }
                ///////////////////////////////////////////
                for (int i=0; i < fecha.Month-1; i++)
                {
                    contadorDiasPorMes2 += meses[i];
                }

                diasVivo += contadorDiasDespuesDelCumple;
                diasVivo += contadorDiasPorMes;
                diasVivo += contadorDiasPorMes2;
                diasVivo += fecha.Day;

                if (esBisiesto(fecha.Year))
                {
                    diasVivo += 1;
                }
            }
            else //Si ya cumplio
            {
                diasVivo = aniosVivo * 365;
                diasVivo += aniosVivo / 4; //calculo los dias de los años bisiestos y se los sumo

                contadorDiasDespuesDelCumple = meses[mesC - 1] - diaC + 1; //saco la diferencia de los dias que faltan desde que cumple hasta que termina ese mes

                for(int i=mesC; i<fecha.Month-1; i++) //recorro desde el mesCumple hasta un mes menos que el actual, y cuento los dias que hay
                {
                    contadorDiasPorMes += meses[i];
                }

                contadorDiasPorMes += contadorDiasDespuesDelCumple; //le sumo el calculo anterior de la diferencia de dias del mesCumple
                contadorDiasPorMes += fecha.Day; //le sumo los dias del mes actual en el que estamos
                diasVivo += contadorDiasPorMes; //los dejo en esta variable que es la que ya calcule anteriormente los años*365
            
                if(mesC <= 2 && esBisiesto(fecha.Year))//Si este año actual es bisiesto, y cumple antes de marzo, le sumo 1 dia
                {
                    diasVivo += 1;
                }       
            }
            Console.WriteLine(diasVivo);
        }

        static bool esBisiesto(int anio)
        {
            bool esBisiesto = false;
            if(anio % 4 == 0 && (anio % 100 != 0 || anio % 400 == 0))
            {
                esBisiesto = true;
            }

            return esBisiesto;
        }
    }
}
