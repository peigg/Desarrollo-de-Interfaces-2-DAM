internal class Program{
    private static void Main(string[] args){

        double[] nums = new double[10];
        for (int i = 0; i < nums.Length; i++){
            { while(true) {
                    Console.Write($"Ingresa el número {i + 1}: ");
                    if (double.TryParse(Console.ReadLine(), out double numero)){
                        nums[i] = numero;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ingresa un número, cualquier otro tipo de caracter no " +
                            "será aceptado");
                    }

                }
            }

            }
            Console.WriteLine("Imprimimos las tablas de multiplicar");
            foreach (double numero in nums)
            {
                Console.WriteLine("Tabla de multiplicar de " + numero);
                for (int multi = 1; multi <= 10; multi++)
                {
                    double result = numero * multi;
                    Console.WriteLine($"{numero} x {multi} = {result}");
                }

                Console.WriteLine();
            }
        }
    
}
    

