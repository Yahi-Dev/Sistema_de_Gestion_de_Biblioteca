using asignacionDos.ValoresDatos;

namespace asignacionDos.Menu
{
   internal class MenuLibro
    {
        public void DespeglarMemuLibro()
        {
            System.Console.WriteLine("\r                       = = = = BIBLIOTECA = = = = \n \n");
            Catalogo cat = new Catalogo();
             cat.InicializarListas();
             cat.catalogo();
            
        }
    }
}