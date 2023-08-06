using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


            //Preparation for encryption
            Console.WriteLine("Input a secret message.");
            string input = Console.ReadLine();
            char[] secretMessage = input.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];



            //Encryption
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char secretCharPos = secretMessage[i];


                int alphaCharIndex = Array.IndexOf(alphabet, secretCharPos);
                int alphaCharIndexMod = (alphaCharIndex + 3) % alphabet.Length;


                char encryptedCharPos = alphabet[alphaCharIndexMod];
                encryptedMessage[i] = encryptedCharPos;
            }



            string finalMessage = String.Join("", encryptedMessage);
            Console.WriteLine(finalMessage);



        }
    }
}