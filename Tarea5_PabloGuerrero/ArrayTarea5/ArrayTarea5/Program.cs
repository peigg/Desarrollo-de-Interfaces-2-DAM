using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Este programa crea y elimina números duplicados" +
            " de un array de números enteros.");
        Console.Write("Introduce la longitud del array: ");
        if (int.TryParse(Console.ReadLine(), out int arrayTamaño) && arrayTamaño > 0){
            // Creamos un array del tamaño que hemos especificado
            int[] nums = new int[arrayTamaño];
            //Ahora llenamos el array con números aleatorios usando el método random
            Random rand = new Random();
            for (int i = 0; i < arrayTamaño; i++){
                nums[i] = rand.Next(1, 21); // ´Generamos números aleatorios entre 1 y 20
            }
            //Imprimimos la lista original
            Console.WriteLine("La lista de números es la siguiente:");
            Print(nums);
            // Eliminamos números duplicados con distinct, gracias Cosi
            int[] sinDups = nums.Distinct().ToArray();
            //Imprimimos la lista sin duplicdos
            Console.WriteLine("\nLista sin duplicados:");
            Print(sinDups);
        }
        else {
            Console.WriteLine("Hay que introducir un número entero positivo como tamaño del array");
        }
    }

    static void Print(int[] array){
        foreach (int num in array){
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
