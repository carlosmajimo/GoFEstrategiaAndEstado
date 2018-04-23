using System;
namespace PatronesGofEstrategiaEstado.Estado
{
    public class ContextoTiempo
    {
        private DateTime date;
        private String province;
        private ITipoTiempo TipoTiempo;

        public void SetTypeWeather(ITipoTiempo typeWeather)
        {
            this.TipoTiempo = typeWeather;
        }

        public void Request()
        {
            if (TipoTiempo != null)
                TipoTiempo.EjecutarAccion();
        }

    }
}
