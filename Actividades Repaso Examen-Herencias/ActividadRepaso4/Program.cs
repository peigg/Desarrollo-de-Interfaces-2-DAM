using ActividadRepaso4;

internal class Program
{
        public static void Main(string[] args)
        {
            int total = 3;
            Persona[] personas = new Persona[total];
            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                Console.WriteLine("Escribe el nombre del profesor: ");
                    personas[i] = new Profesor(Console.ReadLine());
                }
                else
                {
                Console.WriteLine("Escribe el nombre del alumno: ");
                    personas[i] = new Estudiante(Console.ReadLine());
                }
            }
            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine((Profesor)personas[i] + " y:");
                    ((Profesor)personas[i]).explicar();
                  
                }
                else
                {
                Console.WriteLine((Estudiante)personas[i] + " y:");
                ((Estudiante)personas[i]).estudiar();
                }
            }

        }
    }