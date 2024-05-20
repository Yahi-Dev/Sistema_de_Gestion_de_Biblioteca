using asignacionDos.Menu;
//using asignacionDos.Registro;
using asignacionDos.ValoresDatos;

namespace asignacionDos.Menu.Registro
{
    internal class Program
    {
        static void Main(string[] args)
        {
             RegistroUsuario datosUsuario = new RegistroUsuario();
             datosUsuario.Login();
        }
    }
}