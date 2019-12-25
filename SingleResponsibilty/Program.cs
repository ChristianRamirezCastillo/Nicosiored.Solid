using System;

namespace SingleResponsibilty
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Christian", 4500.50, "Programador", 34);
            Console.WriteLine(empleado);
            Console.WriteLine(Hacienda.CalcularImpuesto(empleado));
            Hacienda.PagarImpuesto(empleado);

        }
    }
}
