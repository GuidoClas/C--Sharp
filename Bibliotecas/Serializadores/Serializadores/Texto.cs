﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Serializadores
{
    public class Texto : IArchivos<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(archivo, true))
                {
                    file.WriteLine(datos);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader file = new StreamReader(archivo))
                {
                    datos = file.ReadToEnd();
                }
                return true;
            }
            catch (Exception)
            {
                datos = "";
                return false;
            }
        }
    }
}
