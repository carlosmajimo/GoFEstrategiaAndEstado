using System;
namespace PatronesGofEstrategiaEstado.Estrategia
{
    public class Vehiculo
    {
        private ContextoConduccion Contexto;

        public Vehiculo()
        {
            this.Contexto = new ContextoConduccion();
        }

        public void ConduccionDeportiva()
        {
            ITipoConduccion conduccionDeportiva = new ConduccionDeportiva();
            Contexto.TipoConduccion = conduccionDeportiva;
        }

        public void ConduccionNormal()
        {
            ITipoConduccion conduccionNormal = new ConduccionNormal();
            Contexto.TipoConduccion = conduccionNormal;
        }

        // Métodos que invocan la funcionalidad implementada por la interfaz
        public void Acelerar(float combustible)
        {
            string descripcion = Contexto.ObtenerDescripcion();
            int incrementoVelocidad = Contexto.IncrementarVelocidad(combustible);
            int potencia = Contexto.IncrementarPotencia(combustible);

            Console.WriteLine("Tipo de conducción " + descripcion);
            Console.WriteLine("Combustible inyectado: " + combustible);
            Console.WriteLine("Potencia proporcionada: " + potencia);
            Console.WriteLine("Incremento de velocidad: " + incrementoVelocidad);
        }
    }
}
