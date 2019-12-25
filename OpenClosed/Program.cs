using System;
using System.Collections.Generic;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseInventario> listaProductos = new List<BaseInventario>
            {
                new InventarioAlimento(
                    new Producto("papas", 1, 12.5)
                ),
                new InventarioMedicamento(
                    new Producto("Analgesico", 2, 23.40)
                ),
                new InventarioAlimento(
                    new Producto("tomate", 1, 1.30)
                )
            };

            Tienda tienda = new Tienda(listaProductos);
            tienda.CalcularInventario();
        }
    }
}
