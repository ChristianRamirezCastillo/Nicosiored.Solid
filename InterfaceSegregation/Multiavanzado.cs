using System;

namespace InterfaceSegregation
{
    public class Multiavanzado: IMulticompleto
    {
        public void Imprimir()
        {
            Console.WriteLine("imrpimir Multifuncional");
        }

        public void Escanear()
        {
            Console.WriteLine("escanear Multifuncional");
        }

        public void Telefono()
        {
            Console.WriteLine("telefono Multifuncional");
        }

        public void Faxear()
        {
            Console.WriteLine("faxear Multifuncional");
        }

    }
}