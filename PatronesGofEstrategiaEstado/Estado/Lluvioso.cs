using System;
namespace PatronesGofEstrategiaEstado.Estado
{
    public class Lluvioso: ITipoTiempo
    {
        public void EjecutarAccion()
        {
            Console.WriteLine("Esta lloviendo");
        }
    }
}
