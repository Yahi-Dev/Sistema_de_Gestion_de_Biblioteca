namespace asignacionDos.ValoresDatos
{
    internal class VerLibroReservado
    {
        public void OjearLibroReservado(int opcionLibro)
        {
            System.Console.WriteLine("El libro que usted tiene prestado es: ");
            Catalogo catalogo = new Catalogo();
            catalogo.opcionLibro(opcionLibro);
        }
    }
}