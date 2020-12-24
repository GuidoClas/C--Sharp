using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace SQL
{
    public class CarreraDao
    {
        private SqlConnection sqlConnection;
        private string connectionString = "Database=BaseCarreras;".DevolverConnectionString();

        public CarreraDao()
        {
            this.sqlConnection = new SqlConnection(connectionString);
        }

        public void AgregarCarrera(Carrera carrera)
        {
            try
            {
                string command = "INSERT INTO Carreras(ganador, corredorElegido, apuestaJugador) " + $"VALUES(@ganador, @corredorElegido, @apuestaJugador)";

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("ganador", carrera.Ganador);
                sqlCommand.Parameters.AddWithValue("corredorElegido", carrera.CorredorElegido);
                sqlCommand.Parameters.AddWithValue("apuestaJugador", carrera.TotalApuestasPorPicada);

                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public void AgregarCarreras(List<Carrera> carreras)
        {
            foreach (Carrera c in carreras)
            {
                this.AgregarCarrera(c);
            }
        }

        public List<Carrera> ListarCarreras()
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                List<Carrera> listaAux = new List<Carrera>();


                string command = "SELECT * FROM Carreras";
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    string ganador = (string)reader["ganador"];
                    string corredorElegido = (string)reader["corredorElegido"];
                    int apuestaJugador = (int)reader["apuestaJugador"];

                    Carrera carrera = new Carrera(ganador, corredorElegido, apuestaJugador);

                    listaAux.Add(carrera);
                }

                return listaAux;
            }
        }
    }
}
