namespace DependencyInversion
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int Tipo { get; set; }   
        public double Costo { get; set; }

        public Producto(string nombre, int tipo, double costo)
        {
            Nombre = nombre;
            Tipo = tipo;
            Costo = costo;
        }

        public override string ToString()
        {
            string tipo = "";
            
            if (Tipo == 0) tipo = "Alimento";
            else if (Tipo == 1) tipo = "Medicina";
            else if (Tipo == 2) tipo = "ropa";

            return $"{Nombre}, tipo {tipo}, costo ${Costo}";
        }
    }
}