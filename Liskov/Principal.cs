namespace Liskov
{
    public abstract class Principal
    {
        protected string mensaje;

        public Principal(string pMensaje)
        {
            mensaje = pMensaje;
        }

        //metodo abstracto para que cada version lo implemente.
        public abstract void Muestra();
    }
}