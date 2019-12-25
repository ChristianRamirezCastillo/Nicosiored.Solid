using System;

namespace Liskov
{
    public class Radio : Principal
    {
        public Radio(string mensaje): base(mensaje)
        {
        }

        public override void Muestra()
        {
            Console.WriteLine($"Desde la radio: {mensaje}"); 
        }
          
    } 
}