namespace OpenClosed
{
    public class InventarioMedicamento: BaseInventario
    {
        public InventarioMedicamento(Producto producto) : 
            base (producto) { }

        public override double CalcularProducto() => 
            Producto.Precio *= 0.8;
    }
}