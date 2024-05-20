using System.Runtime.CompilerServices;

namespace asignacionDos.Clases_Principales
{
    class Libro
    {
        public static int Contadorlibro { get; set; } = 0;
        public int Id { get; set; }
        public string NombreLibro { get; }
        public string AutorLibro { get; }
        public int AñoPublicacionLibro { get; }
        public int NumeroDePagina { get; }
        public bool Disponibilidad { get; }
        public string LugarDeCreacion { get; }

        public Libro(string Nombre, string Autor, int AñoPublicacion, int NumeroDePag)
        {
            this.NombreLibro = Nombre;
            this.AutorLibro = Autor;
            this.AñoPublicacionLibro = AñoPublicacion;
            this.NumeroDePagina = NumeroDePag;
            this.Disponibilidad = Disponibilidad;
            this.LugarDeCreacion = LugarDeCreacion;
            Contadorlibro++;
            this.Id = Contadorlibro;
        }

        public Libro(string Nombre, int AñoPublicacion, int NumeroDePag)
        {
            this.NombreLibro = Nombre;
            this.AutorLibro = "Anonimo";
            this.AñoPublicacionLibro = AñoPublicacion;
            this.NumeroDePagina = NumeroDePag;
            this.Disponibilidad = Disponibilidad;
            this.LugarDeCreacion = LugarDeCreacion;
            Contadorlibro++;
            this.Id = Contadorlibro;
            
        }
    }
}
