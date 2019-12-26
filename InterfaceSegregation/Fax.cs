using System;

namespace InterfaceSegregation
{
    public class Fax: IFax
    {
        public void Telefono()
        {
           Console.WriteLine("telefono Fax");
        }

        public void Faxear()
        {
            Console.WriteLine("faxear Fax");
        }
    }
}