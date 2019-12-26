using System;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiavanzado avanzado = new Multiavanzado();
            avanzado.Escanear();
            avanzado.Faxear();
            avanzado.Imprimir();
            avanzado.Telefono();

            Console.WriteLine("----------------------");

            Fax fax = new Fax();
            fax.Telefono();
            fax.Faxear();

            Console.WriteLine("----------------------");

            Multisencillo sencillo = new Multisencillo();
            sencillo.Escanear();
            sencillo.Imprimir();
        }
    }
}
