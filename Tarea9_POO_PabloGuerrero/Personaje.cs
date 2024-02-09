namespace Tarea9_POO_PabloGuerrero
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }

        public Personaje(string nombre, string imagenExplorador)
        {
            Nombre = nombre;
            Imagen = imagenExplorador;
        }
    }

    public class Mago : Personaje
    {
        public int PoderMagico { get; set; }

        public Mago(string nombre, int poderMagico)
            : base(nombre, "ImagenMago.png")
        {
            PoderMagico = poderMagico;
        }
    }

    public class Guerrero : Personaje
    {
        public int Fuerza { get; set; }

        public Guerrero(string nombre, int fuerza)
            : base(nombre, "ImagenGuerrero.png")
        {
            Fuerza = fuerza;
        }
    }

    public class Arquero : Personaje
    {
        public int Precision { get; set; }

        public Arquero(string nombre, int precision)
            : base(nombre, "ImagenArquero.png")
        {
            Precision = precision;
        }
    }
}
