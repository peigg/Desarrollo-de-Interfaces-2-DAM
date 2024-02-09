using ActividadesRepaso;
using System;
public class EstudianteProfesorTest
{
    public static void Main(string[] args)
    {
        
        Persona persona = new Persona();
        persona.Saludar();

        Estudiante estudiante = new Estudiante();
        int edad = estudiante.setEdad();
        Console.WriteLine(estudiante.Saludar());
        Console.WriteLine(estudiante.verEdad(edad));
        estudiante.estudiar();

        Profesor profesor = new Profesor();
        profesor.setEdad();
        Console.WriteLine(profesor.Saludar());
        profesor.explicar();
    }
}