using System;
namespace PatronesGofEstrategiaEstado.Estrategia
{
    public interface ITipoConduccion
    {
        string ObtenerDescripcion();
        int ObtenerPotencia(float decilitrosCombustible);
        int ObtenerIncrementoVelocidad(float decilitrosCombustible);
    }
}
