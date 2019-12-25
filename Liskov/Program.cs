using System;

namespace Liskov
{
    class Program
    {
        static void Main(string[] args)
        {
            Principal noticiero = new Noticiero("hola noticiero");
            noticiero.Muestra();

            Principal radio = new Radio("hola radio");
            radio.Muestra();

            // Console.WriteLine("-------------------------------------");

            // Noticiero sustitucion = new Radio("hola sustitucion");
            // sustitucion.Muestra();
            
        }
    }
}
