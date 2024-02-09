using ActividadesRepaso;
using System;
public class Program
{
    public static void Main(string[] args)
    {
        int num = 3;
        Persona[] persona = new Persona[num];

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Introduce un nombre: ");
            persona[i] = new Persona()
            {
                Nombre = Console.ReadLine()
            };
        }
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(persona[i].ToString());
        }
    }
}