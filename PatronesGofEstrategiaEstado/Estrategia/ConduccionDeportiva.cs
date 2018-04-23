using System;
namespace PatronesGofEstrategiaEstado.Estrategia
{
    public class ConduccionDeportiva: ITipoConduccion
    {
        public string ObtenerDescripcion()
        {
            return "Conduccion Deportiva";
        }

        public int ObtenerPotencia(float decilitrosCombustible)
        {
            return (int)(decilitrosCombustible * 0.987) + 5;
        }

        public int ObtenerIncrementoVelocidad(float decilitrosCombustible)
        {
            return (int)(decilitrosCombustible * 0.618) + 3;
        }
    }
}
