using System;

namespace Liskov
{
    public class Noticiero: Principal
    {
        public Noticiero(string mensaje): base(mensaje)
        {
        }

        public override void Muestra() 
        { 
            Console.WriteLine($"Desde el noticiero: {mensaje}");  
        }
    }
}