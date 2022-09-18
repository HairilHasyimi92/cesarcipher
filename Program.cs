using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Write your secret message: ");
            string secretMsg = Console.ReadLine();
            char[] secretMessage = secretMsg.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int nLetter = Array.IndexOf(alphabet, letter);
                int InELetter = (nLetter + 3) % alphabet.Length;
                char nELetter = alphabet[InELetter];
                encryptedMessage[i] = nELetter;
            }
            string fEncryptedMessage = String.Join("", encryptedMessage);
            Console.WriteLine(fEncryptedMessage);
        }
    }
}