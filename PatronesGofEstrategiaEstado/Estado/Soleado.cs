using System;
namespace PatronesGofEstrategiaEstado.Estado
{
    public class Soleado : ITipoTiempo
    {
        public void EjecutarAccion()
        {
            Console.WriteLine("Hace mucho calor");
        }
    }
}
