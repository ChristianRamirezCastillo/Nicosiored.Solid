namespace OpenClosed
{
    public class InventarioAlimento: BaseInventario
    {
        public InventarioAlimento(Producto producto) : 
            base(producto) { }

        public override double CalcularProducto() => 
            Producto.Precio *= 1.2;
    }
}