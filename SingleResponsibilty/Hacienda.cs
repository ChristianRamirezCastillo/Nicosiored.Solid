using System;

namespace SingleResponsibilty
{
    public class Hacienda
    {
        public static double CalcularImpuesto(Empleado empleado) => empleado.Sueldo * 0.35; 
        
        public static void PagarImpuesto(Empleado empleado)
        {
            double imp = CalcularImpuesto(empleado);
            Console.WriteLine($"Se pago {imp} en impuestos por parte de {empleado.Nombre}");
        }  

    }
}