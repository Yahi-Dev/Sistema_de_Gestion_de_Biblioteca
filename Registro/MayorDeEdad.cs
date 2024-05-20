using System.Reflection.Metadata;

namespace asignacionDos.Menu.Registro
{
    internal class MayorDeEdad
    {
        public bool EdadVerificacion(int edad)
        {
            int EdadMinima = 18;
            return edad >= EdadMinima;
        }
    }
}