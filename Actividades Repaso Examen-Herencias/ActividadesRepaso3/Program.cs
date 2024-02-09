using ActividadesRepaso3;

using System;
public class AlbumFotosTest
{
    public static void Main()
    {
        AlbumFotos miAlbum1 = new AlbumFotos();
        Console.WriteLine(miAlbum1.GetNumberPages());
        AlbumFotos miAlbum2 = new AlbumFotos(24);
        Console.WriteLine(miAlbum2.GetNumberPages());
        SuperAlbumFotos miGranAlbum1 = new SuperAlbumFotos();
        Console.WriteLine(miGranAlbum1.GetNumberPages());
    }
}