//Este programa trata de una calculadora con algunas funcionalidades para ejecutar en la consola.


Console.WriteLine("Bienvenidos a la Calculadora. Esta calculadora realiza operaciones de" +
    " suma, resta, multiplicación, división, raíz cuadrada, porcentaje, resto, potenciación, " +
    "logaritmo, logaritmo neperiano, seno, coseno y tangente.");
Console.WriteLine("Elige la operación a realizar usando su operador");

char operador;
double num1, num2, result = 0;

//Solicitamos el operador por consola
Console.Write("Introduce el operador usando su símbolo habitual," +
    " para elegir la opción de resto usaremos R, " +
    "L para logaritmo, N para los logaritmos neperianos, S para el seno, C para el coseno" +
    "y T para la tangente: ");
operador = Console.ReadKey().KeyChar;

// Solicitamos los operandos por consola,el primero lo solicitamos fuera del if
// por que siempre va a ser necesario, el segundo se solicitará si la operación necesita de él.
Console.Write("\nIntroduce el primer número: ");
if (double.TryParse(Console.ReadLine(), out num1))
{
    // Utilizamos un switch con opciones para cada operación
    switch (operador)
    {
        //suma de dos números
        case '+':
            Console.Write("Introduce el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out num2)){
                result = num1 + num2;
            }
            else{
                Console.WriteLine("\nError: El segundo número introducido no es válido.");
                Environment.Exit(1);
            }
            break;
        //resta de dos números
        case '-':
            Console.Write("Introduce el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out num2)){
                result = num1 - num2;
            }
            else{
                Console.WriteLine("\nError: El segundo número introducido no es válido.");
                Environment.Exit(1);
            }
            break;
        //multiplicación
        case '*':
            Console.Write("Introduce el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out num2)) {
                result = num1 * num2;
            }
            else{
                Console.WriteLine("\nError: El segundo número introducido no es válido.");
                Environment.Exit(1);
            }
            break;
        //división, no se puede dividir entre 0
        case '/':
            Console.Write("Introduce el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out num2)){
                if (num2 != 0){
                    result = num1 / num2;
                }
                else{
                    Console.WriteLine("\nError: No se puede dividir entre cero");
                    Environment.Exit(1);
                }
            }
            else
            {
                Console.WriteLine("\nError: El segundo número introducido no es válido.");
                Environment.Exit(1);
            }
            break;
            //raiz cuadrada de un número
        case '√':
            if (num1 >= 0)
            {
                result = Math.Sqrt(num1);
            }
            else
            {
                Console.WriteLine("\nError: No se puede calcular la raíz cuadrada de un número negativo.");
                Environment.Exit(1);
            }
            break;
        //Calcula el resto de una división
        case 'R':
            Console.Write("Introduce el divisor para calcular el resto: ");
            if (double.TryParse(Console.ReadLine(), out num2)){
                if (num2 != 0)
                {
                    result = num1 % num2;
                }
                else{
                    Console.WriteLine("\nError: No se puede calcular el resto cuando el divisor es cero.");
                    Environment.Exit(1);
                }
            }
            else
            {
                Console.WriteLine("\nError: El divisor introducido no es válido.");
                Environment.Exit(1);
            }
            break;
            //Calcula la potencia 
        case '^':
            Console.Write("Introduce el exponente para calcular la potencia: ");
            if (double.TryParse(Console.ReadLine(), out num2)){
                result = Math.Pow(num1, num2);
            }
            else{
                Console.WriteLine("\nError: El exponente introducido no es válido.");
                Environment.Exit(1);
            }
            break;
            //Calcula el logaritmo decimal del número introducido
        case 'L':
            if (num1 > 0){
                result = Math.Log10(num1);
            }
            else{
                Console.WriteLine("\nError: No se puede calcular el logaritmo de un número no positivo.");
                Environment.Exit(1);
            }
            break;
            //Caslcula el logaritmo neperiano
        case 'N':
            if (num1 > 0){
                result = Math.Log(num1);
            }
            else{
                Console.WriteLine("\nError: No se puede calcular el logaritmo neperiano de un número no positivo.");
                Environment.Exit(1);
            }
            break;
            //Calcula el seno
        case 'S':
            result = Math.Sin(num1);
            break;
            //Calcula el coseno
        case 'C':
            result = Math.Cos(num1);
            break;
           // Calcula la tangente
        case 'T':
            result = Math.Tan(num1);
            break;
        default:
            Console.WriteLine("\nError: Operación no válida.");
            Environment.Exit(1);
            break;
    }

    Console.WriteLine($"\nEl resultado es: {result}");
}
else{
    Console.WriteLine("\nError: El número introducido no es válido.");
    Environment.Exit(1);
}
