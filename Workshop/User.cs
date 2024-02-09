using System;
using Workshop;

public class User
{
    // Propiedades
    public string Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Mail { get; set; }
    public string Mobile { get; set; }
    public DateTime Edad { get; set; }

    // Propiedades para la contraseña
    public string Salt { get; set; }
    public string PasswordHash { get; set; }

    public User(string ID, string name, string surname, string mail, string mobile, DateTime edad)
    {
        // Asignar valores a las propiedades
        Id = ID;
        Name = name;
        Surname = surname;
        Mail = mail;
        Mobile = mobile;
        Edad = edad;

        // Generar salt y calcular hash al crear el usuario
        Salt = SecurityHash.GenerateSalt();
        PasswordHash = SecurityHash.CalculateHash("default-password", Salt);
    }
}
