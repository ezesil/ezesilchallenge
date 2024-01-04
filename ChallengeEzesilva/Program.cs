using ChallengeEzesilva.Services;
using ChallengeEzesilva.Strategy;

namespace ChallengeEzesilva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algoritmos ordenados, aparentemente independientes
            // Deben poder ser reversibles
            // Strategy

            // entrada: texto plano -> string encriptado por cada operacion.
            // 1- Revertir orden de caracteres.
            // 2- Encriptación y desencriptación reversibles con 2 estrategias de matematica basica.
            // 3- Añadir una tercer estrategia que use LINQ y recursividad.

            string input = "prueba";

            Console.WriteLine($"Input: {input}\n");

            CryptographicService service = new CryptographicService();

            service.Add(new StringReverseStrategy());       
            service.Add(new BasicMathStrategy(x => x + 2, y => y - 2));
            service.Add(new ShuffleAlgorithmStrategy());

            var encryptedText = service.Encrypt(input);
            Console.WriteLine($"EncryptedText: {encryptedText}\n");

            var decryptedText = service.Decrypt(encryptedText);

            Console.WriteLine($"DecryptedText: {decryptedText}");

            Console.ReadKey();
        }
    }
}
