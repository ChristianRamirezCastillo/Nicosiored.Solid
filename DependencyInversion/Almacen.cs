using System;
using System.Collections.Generic;

namespace DependencyInversion
{
    public class Almacen: IAuditable
    {
        private List<Producto> inventario;
        public Almacen() => inventario = new List<Producto>();

        public void AdicionaProducto(Producto producto)
        {
            inventario.Add(producto);
            Console.WriteLine($"Adicionamos {producto}");
        }

        public IEnumerable<Producto> ObtenerProductos(int tipo)
        {
            List<Producto> lista = new List<Producto>();

            foreach (Producto p in inventario)
            {
                if (p.Tipo == tipo) lista.Add(p);
            }

            return lista;
        }
    }
}