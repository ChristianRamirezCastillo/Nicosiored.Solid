using System.Collections.Generic;
using System;
namespace DependencyInversion
{
    public class Auditor
    {
        private IAuditable miAuditor;

        public Auditor(IAuditable auditor) => miAuditor = auditor;


        public double TotalAlimentos()
        {
            double total = 0;
            IEnumerable<Producto> lista = miAuditor.ObtenerProductos(0);

            foreach (Producto p in lista)
            {
                Console.WriteLine(p);
                total += p.Costo;
            }

            return total;
        }
    }
}