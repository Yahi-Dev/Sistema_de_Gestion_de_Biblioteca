public class LibroPrestado
{
    public string Nombre {get; set;}
    public string Autor {get; set;}
    public int AñoPublicacion {get; set;}
    public int NumeroPag {get; set;}
    public bool Dispo {get; set;}
    public string LugarCreacion {get; set;}
    public string ResumenLibro {get; set;}

    public LibroPrestado(string nombre, string autor, int año, int numeropag, bool free, string lugar, string resu )
    {
        this.Nombre = nombre;
        this.Autor = autor;
        this.AñoPublicacion = año;
        this.NumeroPag = numeropag;
        this.Dispo = free;
        this.LugarCreacion = lugar;
        this.ResumenLibro = resu;
    }

}