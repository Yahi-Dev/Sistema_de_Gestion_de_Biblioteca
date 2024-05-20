using System.ComponentModel.DataAnnotations;
using asignacionDos.Clases_Principales;
using asignacionDos.ValoresDatos;

namespace asignacionDos.Menu.Registro
{
    internal class MenuPrincipal
    {
        private ValidacionUsuario validacion = new ValidacionUsuario();
        public void MPrincipal(Usuario datosUsuario)
        {
            bool Salir = false;

            while (!Salir)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                System.Console.WriteLine("                  B I B L I O T E C A \n \n");

                System.Console.WriteLine("1- Ojear Libros \n2- Reservar Libros \n3- Ver Libro Prestado \n4- Devolver Libro \n5- Salir");
                int opcion = int.Parse(Console.ReadLine()!);

                switch (opcion)
                {
                    case 1:
                        MenuLibro men = new MenuLibro();
                        men.DespeglarMemuLibro();
                        System.Console.WriteLine("\n Pulse cualquier tecla para salir al menu Principal");
                        Console.ReadKey();
                        break;

                    case 2:
                        ReservaLibro reserva = new ReservaLibro();
                        reserva.Reserva(datosUsuario);
                        Console.ReadKey();
                        break;

                    case 3:
                        string nombre = datosUsuario.NombreUsuario;
                        string gmail = datosUsuario.GmailUsuario;
                        int opcionLibroSeleccionado = validacion.Validar(nombre, gmail, datosUsuario);

                        if (datosUsuario.LibroReservado != null)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            System.Console.WriteLine($"{datosUsuario.NombreUsuario}, tu libro es: \n");
                            Console.WriteLine("Título: " + datosUsuario.LibroReservado.Nombre);
                            Console.WriteLine("Autor: " + datosUsuario.LibroReservado.Autor);
                            Console.WriteLine("Año de publicacion: " + datosUsuario.LibroReservado.AñoPublicacion);
                            Console.WriteLine("Disponibilidad: " + datosUsuario.LibroReservado.Dispo);
                            Console.WriteLine("Numero de Pagina:: " + datosUsuario.LibroReservado.NumeroPag);
                            System.Console.WriteLine("Resumen: " + datosUsuario.LibroReservado.ResumenLibro);

                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("No tienes ningún libro reservado o prestado en este momento.");
                        }

                        Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 4:
                        Catalogo catalog = new Catalogo();
                        validacion.DevolverLibro(datosUsuario, catalog);
                        Console.ReadKey();
                        break;

                    case 5:
                        System.Console.WriteLine($"Adios {datosUsuario.NombreUsuario}:) ");
                        Salir = true;
                        break;
                }

                Console.ResetColor();
            }

        }
    }
}