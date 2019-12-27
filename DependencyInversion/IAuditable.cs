using System.Collections.Generic;

namespace DependencyInversion
{
    public interface IAuditable
    {
        IEnumerable<Producto> ObtenerProductos(int tipo);
    }
}