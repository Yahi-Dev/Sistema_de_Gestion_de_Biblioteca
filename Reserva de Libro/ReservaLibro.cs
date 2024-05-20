using asignacionDos.Clases_Principales;
using asignacionDos.ValoresDatos;

namespace asignacionDos.Menu.Registro
{
    internal class ReservaLibro
    {
        public void Reserva(Usuario usuario)
        {
            Console.Clear();
            System.Console.Write("Digite su nombre:");
            string nombreIngresa = Console.ReadLine()!;
            System.Console.Write("Ingrese su gmail:");
            string gmailIngresado = Console.ReadLine()!;
            
            ValidacionUsuario validar = new ValidacionUsuario();
            validar.Validar(nombreIngresa,gmailIngresado, usuario);

        }
    }
}