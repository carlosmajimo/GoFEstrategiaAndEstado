using System;
namespace PatronesGofEstrategiaEstado.Estado
{
    public class Nevado: ITipoTiempo
    {
        public void EjecutarAccion()
        {
            Console.WriteLine("Esta nevando que frio!");
        }
    }
}
