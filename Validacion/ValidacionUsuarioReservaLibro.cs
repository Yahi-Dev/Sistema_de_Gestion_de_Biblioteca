using System.Diagnostics.CodeAnalysis;
using asignacionDos.Clases_Principales;
using asignacionDos.ValoresDatos;

namespace asignacionDos.Menu.Registro
{

  internal class ValidacionUsuario
  {
    int opcionLibro;

    public int Validar(string nombre, string gmail, Usuario usuario)
    {
      if (usuario.NombreUsuario.Equals(nombre) && usuario.GmailUsuario.Equals(gmail))
      {
        Catalogo catalogo = new Catalogo();
        catalogo.InicializarListas();
        MenuLibro men = new MenuLibro();
        men.DespeglarMemuLibro();
        System.Console.WriteLine("\n elija un libro por el numero encima de cada título");
        opcionLibro = int.Parse(Console.ReadLine()!);
        if (usuario.LibroReservado != null)
        {
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.Red;
          System.Console.WriteLine($"Ya tienes un libro reservado: {usuario.LibroReservado.Nombre}");
          System.Console.WriteLine("Debes devolverlo antes de reservar otro");
          Console.ResetColor();
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Cyan;
          Console.Clear();
          System.Console.WriteLine($"{usuario.NombreUsuario}, tu libro es: \n");
          BusquedaLibro busqueda = new BusquedaLibro();
          busqueda.Busqueda(opcionLibro);
          Prestamo prestar = new Prestamo();
          prestar.Prestar(opcionLibro, usuario, catalogo);
          Console.ResetColor();
        }
      }
      else
      {
        System.Console.WriteLine("Los datos ingresados no coinciden con el registro. No se puede realizar la reserva.");

      }
      return opcionLibro;
    }

    public void DevolverLibro(Usuario usuario, Catalogo catalogo)
    {
      if (usuario.LibroPrestado != null)
      {
        int indiceLibroPrestado = catalogo.AutorLibro.IndexOf(usuario.LibroPrestado.NombreLibro);

        if (indiceLibroPrestado >= 0)
        {
          catalogo.Disponibilidad[indiceLibroPrestado] = true;

          usuario.LibroPrestado = null;

          Console.ForegroundColor = ConsoleColor.Cyan;
          System.Console.WriteLine("El libro ha sido devuelto exittosamente");
          Console.ResetColor();
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          System.Console.WriteLine("Error: No se encontró el libro prestado en el catálogo.");
          Console.ResetColor();
        }
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine("Error: No tienes ningún libro prestado.");
        Console.ResetColor();
      }
    }
  }
}