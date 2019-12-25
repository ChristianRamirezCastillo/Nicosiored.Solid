namespace OpenClosed
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int Categoria { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, int categoria, double precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }

        public override string ToString() => 
            $"El producto {Nombre} cuesta {Precio}";
        
    }
}