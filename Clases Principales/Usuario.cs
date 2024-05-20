namespace asignacionDos.Clases_Principales
{
    internal class Usuario
    {
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public int EdadUsuario { get; set; }

        public string GmailUsuario { get; set; }

        public LibroPrestado LibroReservado {get; set;} = null;
         public Libro LibroPrestado { get; set; }

        public Usuario(string nombre, string gmail)
        {
            this.NombreUsuario = nombre;
            this.GmailUsuario = gmail;
        }

        public Usuario(string nombre, string apellido, int edad, string gmail)
        {
            this.NombreUsuario = nombre;
            this.ApellidoUsuario = apellido;
            this.EdadUsuario = edad;
            this.GmailUsuario = gmail;
        }
    }
}