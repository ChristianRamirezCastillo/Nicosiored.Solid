using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Almacen almacen = new Almacen();
            double total = 0;

            almacen.AdicionaProducto(new Producto("tomate", 0, 15.50));
            almacen.AdicionaProducto(new Producto("banana", 0, 30));
            almacen.AdicionaProducto(new Producto("analgesico", 1, 23.80));
            almacen.AdicionaProducto(new Producto("jeans", 2, 98.50));
            almacen.AdicionaProducto(new Producto("manzana", 0, 12.50));
            
            Console.WriteLine("-------------------------------------");

            Auditor auditor = new Auditor(almacen);
            total = auditor.TotalAlimentos();

            Console.WriteLine($"El total de alimentos es {total}");
        }
    }
}
