using System.Runtime.CompilerServices;

namespace asignacionDos.ValoresDatos
{
    internal class Catalogo
    {

        public List<string> NombreLibro;
        public List<string> AutorLibro;
        public List<int> AñoPublicacionLibro;
        public List<int> NumeroDePagina;
        public List<bool> Disponibilidad;
        public List<string> LugarDeCreacion;
        public List<string> Resumen;

        public void InicializarListas()
        {
            NombreLibro = new List<string>(new string[]
      {
            "Don Quijote de la Mancha", "Historias de dos ciudades","El Señor de los Anillos",
            "El principito","El Hobbit","Sueño en el pabellon rojo","Las aventuras de alicia en el pais de las maravillas",
            "Triple representatividad","Y no quedó Ninguno","El león, la bruja y el armario",
            "Ella", "El codigo Da Vinci", "El guardián entre centano", "El alquimista",
            "El camino a Cristo", "Heidi"
      });

            AutorLibro = new List<string>(new string[]
              {
            "Miguel de cervantes","De Charles Dickens","J. R. R. Tolkien",
            "Antoine de Saint-Exupéry","J. R. R. Tolkien",
            "Cao Xueqin","Lewis Carroll ","Jiang Zemin", "Agatha Christie",
            "C. S. Lewis","Henry Rider Haggard","Dan Brown","J. D. Salinger",
            "Paulo Coelho","Ellen G. White","Johanna Spyri"
              });


            AñoPublicacionLibro = new List<int>(new int[]
            {
            1605, 1800, 1837, 1902, 1930, 1900, 1865,1920, 1939,
            1950, 1800, 2003, 1946, 1988, 1971, 1880
            });

            NumeroDePagina = new List<int>(new int[]
            {
            300,400,282,231,411,655,231,
            578,686,876,671,200,121,367,232,
            278,573,
            });

            Disponibilidad = new List<bool>(new bool[]
            {
             true, true, true, true, true,
             true, true, true, true, true,
             true, true, true, true, true,
             true, true, true, true, true

            });

            LugarDeCreacion = new List<string>(new string[]
            {
                "Mexico", "Colombia", "Colombia", "Mexico", "Colombia",
              "GUatemala", "Argentina", "Brasil", "Luxemburgo", "Italia",
              "China", "Japon", "Republica Dominicana", "Panama", "Haiti",
                "España"
            });

            Resumen = new List<string>(new string[]
            {
                "Don Quijote de la Mancha es una novela escrita por Miguel de Cervantes que narra las aventuras de un caballero enloquecido que lucha contra molinos de viento, explorando temas de idealismo y locura en la España del siglo XVII.",
                "Hisotira de dos ciudades, es una novela de Charles Dickens que se desarrolla en Londres y París durante la Revolución Francesa, explorando temas de amor, sacrificio y redención a través de sus personajes.",
                "El señor de los anillos, es una épica obra de J.R.R. Tolkien que sigue la odisea de Frodo Baggins para destruir un poderoso anillo y derrotar al Señor Oscuro Sauron, explorando el bien contra el mal en un mundo de fantasía.",
                "el principito, es un cuento de Antoine de Saint-Exupéry que sigue las aventuras de un pequeño príncipe que viaja por diferentes planetas, enseñando lecciones sobre la amistad y la importancia de ver el mundo con los ojos del corazón.",
                "El Hobbit,de J.R.R. Tolkien narra la inesperada aventura de Bilbo Bolsón, un hobbit, quien se une a un grupo de enanos en una búsqueda para recuperar su reino de manos de un dragón, enfrentando peligros y descubriendo su valentía en un mundo de fantasía.",
                "Sueño en el pabellon rojo, una novela china clásica escrita por Cao Xueqin, relata las vidas y amores de la alta sociedad china en el siglo XVIII, destacando las complejidades de las relaciones humanas y la inevitabilidad del cambio.",
                "Las aventuras de alicia en el pais de las maravillas, de Lewis Carroll es una historia que sigue las aventuras de una niña llamada Alicia cuando cae por un agujero de conejo y entra en un mundo surrealista y absurdo, donde se encuentra con personajes extraños y vive experiencias fantásticas mientras busca el camino de regreso a casa.",
                "Triple Representatividad, es un concepto político en China que aboga por la inclusión de representantes del Partido Comunista Chino en todas las esferas de la sociedad, como empresas y organizaciones no gubernamentales, para mantener su influencia y control. Este término se originó en el discurso político chino y no corresponde a un libro específico.",
                "Y no quedo ninguno,es una novela de misterio escrita por Agatha Christie en la que un grupo de personas es invitado a una isla remota y misteriosamente comienzan a morir una tras otra, desatando una intrincada trama de asesinato y suspense.",
                "El leon,es una novela de fantasía escrita por C.S. Lewis. Narra la historia de cuatro hermanos que descubren un mundo mágico llamado Narnia a través de un armario, donde se unen a la lucha para derrotar a la malvada Reina Blanca con la ayuda del león Aslan.",
                "Ella, es una novela de aventuras escrita por H. Rider Haggard. La historia sigue las peripecias de un grupo de exploradores británicos en África, donde descubren una civilización perdida y se enfrentan a peligros y misterios mientras buscan la inmortalidad y el amor.",
                "El Codigo Da Vinci, es una novela de misterio y conspiración escrita por Dan Brown. La trama sigue al profesor Robert Langdon y una criptóloga mientras investigan una serie de pistas en busca del Santo Grial, enfrentándose a secretos religiosos y desentrañando un antiguo enigma.",
                "El guardian entre centano,es una novela de J.D. Salinger que narra la historia de un adolescente llamado Holden Caulfield mientras lidia con la alienación y la búsqueda de autenticidad en la sociedad adulta tras su expulsión de la escuela.",
                "El alquimista, de Paulo Coelho es una novela que sigue el viaje de Santiago, un joven pastor, en busca de su Leyenda Personal. A través de aventuras y encuentros en el desierto, descubre lecciones sobre el destino, el amor y la realización personal.",
                "El camino de cristo,de Ellen G. White es un libro de inspiración religiosa que ofrece consejos sobre cómo llevar una vida cristiana más plena y cercana a Jesucristo, abordando temas como la fe, la oración y la moralidad.",
                "Heidi,de Johanna Spyri es una novela que narra la vida de una niña huérfana llamada Heidi, quien es llevada a vivir con su abuelo en los Alpes suizos. La historia se centra en su amor por la naturaleza y su capacidad para traer felicidad a quienes la rodean."
            });

        }

        public void catalogo()
        {
            for (int i = 0; i < NombreLibro.Count; i++)
            {
                System.Console.WriteLine("= = = = = = = = = = = = = " + (i) +" = = = = = = = = = = = = =");
                System.Console.WriteLine("Nombre: " + NombreLibro[i]);
                System.Console.WriteLine("Autor: " + AutorLibro[i]);
                System.Console.WriteLine("Año de publicacion: " + AñoPublicacionLibro[i]);
                System.Console.WriteLine("Disponibilidad: " + Disponibilidad[i]);
                System.Console.WriteLine("Lugar de Creacion:: " + LugarDeCreacion[i]);
                System.Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = \n ");
            }
        }

         public void opcionLibro(int opcionLibro)
        {
           
                Disponibilidad[opcionLibro] = false;
                System.Console.WriteLine("= = = = = = = = = = = = = " + (opcionLibro) +" = = = = = = = = = = = = =");
                System.Console.WriteLine("Nombre: " + NombreLibro[opcionLibro]);
                System.Console.WriteLine("Autor: " + AutorLibro[opcionLibro]);
                System.Console.WriteLine("Año de publicacion: " + AñoPublicacionLibro[opcionLibro]);
                System.Console.WriteLine("Disponibilidad: " + Disponibilidad[opcionLibro]);
                System.Console.WriteLine("Lugar de Creacion: " + LugarDeCreacion[opcionLibro]);
                System.Console.WriteLine("Numero de pagina: " + NumeroDePagina[opcionLibro]);
                System.Console.WriteLine("Resumen del libro: \n " + Resumen[opcionLibro]);
                System.Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = \n ");
            
        }
    }
}