using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ProductosDAO
    {
        private SqlConnection sqlConnection;
        private string connectionString = "Server=.;Database=Productos;Trusted_Connection=True;";


        public ProductosDAO()
        {
            this.sqlConnection = new SqlConnection(connectionString);
        }

        public void InsertarProducto(Producto producto)
        {
            try
            {
                string command = "INSERT INTO Productos(nombre, precio, codigo) " + $"VALUES(@nombre, @precio, @codigo)";

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("nombre", producto.Nombre);
                sqlCommand.Parameters.AddWithValue("precio", producto.Precio);
                sqlCommand.Parameters.AddWithValue("codigo", producto.Codigo);


                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if(this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public void ModificarProducto(Producto producto)
        {
            
            try
            {
                string command = "UPDATE Productos " + "SET nombre = @nombre" + " WHERE id = @id";


                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", producto.ID);
                sqlCommand.Parameters.AddWithValue("nombre", producto.Nombre);


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

        public void BorrarProducto(Producto producto)
        {
            try
            {
                string command = "DELETE FROM Productos " + "WHERE id = @id";

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", producto.ID);

                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if(this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public List<Producto> ListarProductos()
        {
            using(SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                List<Producto> productos = new List<Producto>();

            
                string command = "SELECT * FROM Productos";
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();


                while(reader.Read())
                {
                    int id = (int)reader["id"];
                    string nombre = (string)reader["nombre"];
                    string codigo = (string)reader["codigo"];
                    string descripcion = null;

                    if (reader["descripcion"] != DBNull.Value)
                    {
                        descripcion = (string)reader["descripcion"];
                    }

                    float precio = (float) Convert.ToDouble(reader["precio"]);

                    Producto producto = new Producto(id, codigo, nombre, precio, descripcion);

                    productos.Add(producto);
                }
             
                return productos;
            }
        }
        public Producto ListarProductosPorId(int idBuscar)
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                List<Producto> productos = new List<Producto>();
                string command = "SELECT * FROM Productos WHERE id=@id";

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("id", idBuscar);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                Producto producto = null;
                if (reader.Read())
                {
                    int id = (int)reader["id"];
                    string nombre = (string)reader["nombre"];
                    string codigo = (string)reader["codigo"];
                    string descripcion = null;

                    if (reader["descripcion"] != DBNull.Value)
                    {
                        descripcion = (string)reader["descripcion"];
                    }

                    float precio = (float)Convert.ToDouble(reader["precio"]);

                    producto = new Producto(id, codigo, nombre, precio, descripcion);
                }
                

                return producto;
            }
        }
    }
}
