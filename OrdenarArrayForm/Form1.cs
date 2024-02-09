using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace OrdenarArrayForm
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();

        private string length;
        private int[] array;
        private int currentIndex = 0;
        private string valor;
        public Form1()
        {
            InitializeComponent();
            Load += TuFormulario_Load;

        }
        private void TuFormulario_Load(object sender, EventArgs e)
        {
            // Abre la consola al cargar el formulario
            AllocConsole();

            // Puedes usar Console.WriteLine para imprimir mensajes en la consola
            Console.WriteLine("Abrimos consola y form");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Guarda el contenido del TextBox en la variable entradaTextBox
            length = txtLength.Text;

            if (!int.TryParse(length, out int n) || n <= 0 || n >= 15)
            {
                // Si no hace bien la conversión o está fuera del rango, imprime un mensaje de error.
                Console.WriteLine("Por favor, introduce un número entero positivo y menor o igual a 15.");
                return;
            }

            Console.WriteLine("La longitud del array es: " + n);

            // Inicializa el arreglo con el tamaño correcto
            array = new int[n];

            // Deshabilita el botón Guardar una vez guardada la longitud para evitar excepciones.
            btnGuardar.Enabled = false;

            btnValores_Click(sender, e);
        }

        private void btnValores_Click(object sender, EventArgs e)
        {
            valor = txtValor.Text;
            // Verifica si el usuario ha introducido un valor en txtValor
            if (string.IsNullOrWhiteSpace(valor))
            {
                // Muestra un mensaje de error en la consola si el valor está en blanco o es nulo.
                Console.WriteLine("Esperando a que se introduzca el valor");
                return;
            }

            // Pedimos al usuario que ingrese los valores del array
            // Guarda el contenido del TextBox en el array
            if (!int.TryParse(valor, out array[currentIndex]))
            {
                // Si no introduce un entero, muestra un mensaje de error en la consola.
                Console.WriteLine("El valor introducido debe ser un entero");
                return;
            }

            // Incrementa el índice para pasar al siguiente elemento del array
            currentIndex++;

            // Verifica si se ingresaron todos los valores
            if (currentIndex < array.Length)
            {
                // Si no se ingresaron todos los valores, solicita el siguiente valor
                SolicitarValor();
            }
            else
            {
                //Desactivamos el botón para evitar excepciones
                btnValores.Enabled = false;

                //Vamos a imprimir los vectores
                Console.WriteLine("");
                Console.WriteLine("Imprimimos el array introducido");
                Console.WriteLine("");
                //impresión del vector desordenado
                foreach (var value in array)
                {
                    txtDesordenado.Text += value + " ";
                }

                /*impresión en la consola
                foreach (var value in array)
                {
                    Console.Write(value + " ");
                }*/


                //impresión del vector ordenado
                Console.WriteLine("Ordenamos el array introducido");
                // Llamamos al método Quicksort para ordenar el array
                Quicksort(array, 0, array.Length - 1);
                //impresión en el form
                foreach (var value in array)
                {
                    txtOrdenado.Text += value + " ";
                }

                /*impresión en la consola
                foreach (var value in array)
                {
                    Console.Write(value + " ");
                }*/
            }
        }
        private void SolicitarValor()
        {
            // Cambia el texto de la etiqueta para solicitar el valor actual
            lblSolicita.Text = $"Introduce el elemento {currentIndex + 1}:";
            // Limpia el TextBox para permitir al usuario ingresar un nuevo valor
            txtValor.Text = "";
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
}