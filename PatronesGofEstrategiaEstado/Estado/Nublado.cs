using System;
namespace PatronesGofEstrategiaEstado.Estado
{
    public class Nublado: ITipoTiempo
    {
        public void EjecutarAccion()
        {
            Console.WriteLine("Parece que hoy no se ve el sol");
        }
    }
}
