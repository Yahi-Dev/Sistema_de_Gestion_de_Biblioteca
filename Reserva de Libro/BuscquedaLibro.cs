namespace asignacionDos.ValoresDatos
{
    internal class BusquedaLibro
    {
        public void Busqueda(int opcionLibro)
        {
            Catalogo cat = new Catalogo();
            cat.InicializarListas();
            cat.opcionLibro(opcionLibro);
        }


    }
}