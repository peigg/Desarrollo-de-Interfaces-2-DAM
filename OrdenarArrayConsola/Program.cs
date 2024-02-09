internal class Program
{
    /* Este ejercicio consiste en implementar un método recursivo para ordenar los elementos
    de un vector. */
    private static void Main(string[] args)
    {
        // Pedimos al usuario la longitud del array, capada en 15 por usabilidad
        Console.Write("Introduce la longitud del array (vector). Debe ser un entero no mayor que 15: ");
        string lengthArray = Console.ReadLine();


        /* Comprobamos si hace bien la conversión de string a entero y si el número introducido
        es igual o menor que 0 */
        if (!int.TryParse(lengthArray, out int n) || n <= 0 || n>=15)
        {
            // Si no hace bien la conversión, imprime un mensaje de error y sale del programa.
            Console.WriteLine("Por favor, introduce un número entero positivo y menor o igual a 15.");
            return;
        }

        int[] array = new int[n];

        // Pedimos al usuario que ingrese los valores del array recorriendo el array con un bucle for
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Introduce el elemento {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out array[i]))
            {
                // Si no introduce un entero, finaliza el programa
                Console.WriteLine("Por favor, introduce un número entero.");
                return;
            }
        }

        Console.Write("Imprimimos el vector original: ");
        PrintArray(array);

        // Llamamos al método Quicksort para ordenar el array
        Quicksort(array, 0, array.Length - 1);

        Console.Write("Imprimimos el vector ordenado: ");
        PrintArray(array);
    }

    // Método para imprimir el array
    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    // Método para ordenar el array 
    static void Quicksort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            Quicksort(array, low, pivotIndex - 1);
            Quicksort(array, pivotIndex + 1, high);
        }
    }

    /* Este método elige el elemento del array con más valor y recorre el 
     array organizándolo en función de ese valor usando el método swap */
    static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(ref array[i], ref array[j]);
            }
        }

        Swap(ref array[i + 1], ref array[high]);
        return i + 1;
    }

    // Método para intercambiar el valor de dos variables
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
