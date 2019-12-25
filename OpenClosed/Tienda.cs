using System.Collections.Generic;
using System; 

namespace OpenClosed
{
    public class Tienda
    {
        private List<BaseInventario> listaProducto;

        public Tienda(List<BaseInventario> lista) => 
            listaProducto = lista;

        public void CalcularInventario()
        {
            double total = 0;

            foreach (var p in listaProducto)
            {
                p.CalcularProducto();
                Console.WriteLine(p);
                total += p.Producto.Precio;
            }

            Console.WriteLine();
            Console.WriteLine($"El total en inventario es {total}");
        }
    }
}