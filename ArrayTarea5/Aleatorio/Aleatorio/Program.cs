internal class Program
{
    private static void Main(string[] args){
        Console.WriteLine("Este programa genera una clave aleatoria constituida por" +
            " letras mayúsculas y con una longitud de entre 6 y 8 letras");

        Random random = new Random();
        int length = random.Next(6,9);
        string key = GenerateKey(length);
        Console.WriteLine(key);

    }
    static string GenerateKey(int longitud) {
        const string mayus = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char[] key = new char[longitud];
        Random random = new Random();
        for (int i = 0; i < longitud; i++){
            int indice = random.Next(mayus.Length);
            key[i] = mayus[indice];
        }

        return new string(key);
    }
}