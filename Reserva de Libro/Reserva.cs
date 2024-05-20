using System.Runtime.CompilerServices;

namespace asignacionDos.Clases_Principales.Menu.Registro
{
    internal class Reserva
    {
        public string nombreL {get; private set;}
        public string gmailL {get; private set;}

        public Reserva(string nombre, string gmail)
        {
            this.nombreL = nombre;
            this.gmailL = gmail;
        }
    }
}