using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Data.SqlClient;

namespace Entidades
{
    public delegate void FinDeSalida(int bomberoIndex);

    [Serializable]
    public class Bombero : IArchivos<string>, IArchivos<Bombero>
    {
        [NonSerialized]
        private string connectionString = "Server=.\\SQLEXPRESS;Database=20201119-sp;Trusted_Connection=True;";

        private string nombre;
        private List<Salidas> salidas;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Salidas> Salidas { get => salidas; set => salidas = value; }

        public event FinDeSalida MarcarFin;
        public Bombero()
        {

        }
        public Bombero(string nombre)
        {
            this.Nombre = nombre;
            this.salidas = new List<Salidas>();
        }
        public void AtenderSalida(object bomberoIndex)
        {
            Salidas salida = new Salidas();
            Random random = new Random();
         
            this.Salidas.Add(salida);
            Thread.Sleep(random.Next(2000, 4000));
            salida.FinalizarSalida();

            IArchivos<string> guardar = this;
            guardar.Guardar("El bombero" + this.Nombre +  "concretó una salida");

            if (this.MarcarFin != null)
            {
                this.MarcarFin.Invoke((int)bomberoIndex);
            }
        }


        void IArchivos<string>.Guardar(string info)
        {
            SqlConnection sqlConnection = new SqlConnection(this.connectionString);

            try
            {
                string command = "INSERT INTO dbo.log(entrada, alumno) VALUES(@entrada, @alumno)";

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("entrada", info);
                sqlCommand.Parameters.AddWithValue("alumno", "Clas Guido");

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

        }
        
        public void Guardar(Bombero info)
        {
            Stream stream = null;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                stream = new FileStream("Bombero.bin", FileMode.Create, FileAccess.Write, FileShare.None);

                formatter.Serialize(stream, info);

            }
            catch (Exception)
            {
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
        
        public Bombero Leer()
        {
            Stream stream = null;
            Bombero bombero = null;
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                stream = new FileStream("Bombero.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

                bombero = (Bombero)formatter.Deserialize(stream);

                return bombero;

            }
            catch (Exception)
            {
                bombero = default(Bombero);
                return bombero;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        string IArchivos<string>.Leer()
        {
            int id = 1;

            using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "SELECT entrada FROM dbo.log WHERE id=@id";

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", id);


                SqlDataReader reader = sqlCommand.ExecuteReader();

                string entrada = null;

                if (reader.Read())
                {
                    if (reader["entrada"] != DBNull.Value)
                    {
                        entrada = (string)reader["entrada"];
                    }
                }
                return entrada;
            }    
        }
    }
} 

