namespace OpenClosed
{
    public abstract class BaseInventario
    {
        public Producto Producto { get; set; }

        public BaseInventario(Producto p) => Producto = p;

        public override string ToString() => Producto.ToString();

        public abstract double CalcularProducto();

    }
}