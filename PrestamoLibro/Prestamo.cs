using asignacionDos.Clases_Principales;
using asignacionDos.ValoresDatos;
using asignacionDos.Menu;

namespace asignacionDos.Menu.Registro
{
    internal class Prestamo
    {
        private List<LibroPrestado> librosPrestados = new List<LibroPrestado>();

        public void Prestar(int opcionLibro, Usuario usuario, Catalogo catalogo)
        {
            if (usuario.LibroPrestado != null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"Ya tienes un libro prestado: {usuario.LibroPrestado.NombreLibro}");
                System.Console.WriteLine("Debes devolverlo antes de reservar otro.");
                Console.ResetColor();
                return;
            }

            System.Console.WriteLine("Desea tomar el libro prestado: (1- Si/ 2- No): ");
            int prestado = int.Parse(Console.ReadLine()!);

            switch (prestado)
            {
                case 1:
                    LibroPrestado libroPrestado = new LibroPrestado(
                        catalogo.NombreLibro[opcionLibro],
                         catalogo.AutorLibro[opcionLibro],
                         catalogo.AñoPublicacionLibro[opcionLibro],
                         catalogo.NumeroDePagina[opcionLibro],
                         catalogo.Disponibilidad[opcionLibro],
                         catalogo.LugarDeCreacion[opcionLibro],
                         catalogo.Resumen[opcionLibro]
                         );

                    librosPrestados.Add(libroPrestado);
                    usuario.LibroReservado = libroPrestado;
                    Console.Clear();
                    System.Console.WriteLine($"Has tomado prestado el libro: {libroPrestado.Nombre}");
                    System.Console.WriteLine("\n \n \n Pulse ENTER ");
                    break;

                case 2:
                    MenuPrincipal IrAlMenu = new MenuPrincipal();
                    ValidacionUsuario validacion = new ValidacionUsuario();
                    IrAlMenu.MPrincipal(usuario);
                    break;

                default:
                    System.Console.WriteLine("Elija una de las opciones dentro del rango de uno y dos");
                    break;
            }
        }
    }
}