using System;
using System.Collections.Generic;

class Persona
{
    public string Name { get; set; }
    public int Edad { get; set; }
}

class Program
{
    static void Main()
    {
        List<Persona> listaPersonas = new List<Persona>
        {
            new Persona { Name = "Juan", Edad = 25 },
            new Persona { Name = "Maria", Edad = 30 },
            new Persona { Name = "Pedro", Edad = 22 }
        };

        MostrarLista("Lista inicial:", listaPersonas);

        // Ordenar la lista por nombre
        OrdenarPorNombre(listaPersonas);
        MostrarLista("Lista ordenada por nombres:", listaPersonas);

        // Buscar una persona por nombre
        string nombreBuscado = "Maria";
        BuscarPersonaPorNombre(listaPersonas, nombreBuscado);

        // Manipular la lista
        AgregarPersona(listaPersonas, new Persona { Name = "Laura", Edad = 28 });
        MostrarLista("Lista después de agregar una persona:", listaPersonas);

        EliminarPersonaPorNombre(listaPersonas, "Juan");
        MostrarLista("Lista después de eliminar a Juan:", listaPersonas);
    }           

    static void MostrarLista(string mensaje, List<Persona> lista)
    {
        Console.WriteLine(mensaje);
        foreach (Persona persona in lista)
        {
            Console.WriteLine($"Nombre = {persona.Name}, Edad = {persona.Edad}");
        }
        Console.WriteLine();
    }

    static void OrdenarPorNombre(List<Persona> lista)
    {
        lista.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
    }

    static void BuscarPersonaPorNombre(List<Persona> lista, string nombre)
    {
        Persona personaBuscada = lista.Find(p => p.Name == nombre);

        if (personaBuscada != null)
        {
            Console.WriteLine($"Persona encontrada: Nombre = {personaBuscada.Name}, Edad = {personaBuscada.Edad}");
        }
        else
        {
            Console.WriteLine($"Persona con nombre {nombre} no encontrada.");
        }
        Console.WriteLine();
    }

    static void AgregarPersona(List<Persona> lista, Persona nuevaPersona)
    {
        lista.Add(nuevaPersona);
    }

    static void EliminarPersonaPorNombre(List<Persona> lista, string nombre)
    {
        Persona personaAEliminar = lista.Find(p => p.Name == nombre);

        if (personaAEliminar != null)
        {
            lista.Remove(personaAEliminar);
            Console.WriteLine($"Persona con nombre {nombre} eliminada.");
        }
        else
        {
            Console.WriteLine($"Persona con nombre {nombre} no encontrada, no se puede eliminar.");
        }
        Console.WriteLine();
    }
}
