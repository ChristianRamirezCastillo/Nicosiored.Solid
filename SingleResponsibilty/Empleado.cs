
namespace SingleResponsibilty
{
    public class Empleado
    {
        public string Nombre{get;set;}
        public double Sueldo { get; set; }
        public string Puesto { get; set; }
        public int Edad { get; set; }

        public Empleado(string nombre, double sueldo, string puesto, int edad)
        {
            Nombre = nombre;
            Sueldo = sueldo;
            Puesto = puesto;
            Edad = edad;
        }

        public override string ToString() => $"{Nombre}, {Puesto}, {Edad}, {Sueldo}";

    }
}
