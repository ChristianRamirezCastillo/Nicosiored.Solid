using System;

namespace InterfaceSegregation
{
    public class Multisencillo: IMultibasico
    {
        public void Imprimir()
        {
            Console.WriteLine("imrpimir Multisencillo");
        }

        public void Escanear()
        {
            Console.WriteLine("escanear Multisencillo");
        }
    }
}