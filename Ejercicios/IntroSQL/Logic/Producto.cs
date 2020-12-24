namespace Logic
{
    public class Producto
	{ 
		private int id;

		public int ID
		{
			get { return this.id; }
			set { this.id = value; }
		}

		private string  codigo;

		public string  Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}

		private float precio;

		public float Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		public Producto(int id, string codigo, string nombre, float precio, string descripcion)
		{
			this.ID = id;
			this.Codigo = codigo;
			this.Precio = precio;
			this.Nombre = nombre;
			this.Descripcion = descripcion;
		}

	}
}