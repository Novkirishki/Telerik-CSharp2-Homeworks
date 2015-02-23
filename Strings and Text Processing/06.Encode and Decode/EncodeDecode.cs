using System;

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter 
//of the string with the first of the key, the second – with the second, etc. When the last key 
//character is reached, the next is the first.

namespace _06.Encode_and_Decode
{
    class EncodeDecode
    {
        static string EncriptDecript(string text, string key)
        {
            string result = string.Empty;
            int keyIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (keyIndex >= key.Length)
                {
                    keyIndex = 0;
                }

                result += (char)(text[i] ^ key[keyIndex]);
                keyIndex++;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string: ");
            string text = Console.ReadLine();
            Console.WriteLine("Input a key: ");
            string key = Console.ReadLine();

            string encoded = EncriptDecript(text, key);

            Console.WriteLine("After encription: {0}", encoded);

            string decoded = EncriptDecript(encoded, key);

            Console.WriteLine("After decription: {0}", decoded);
        }
    }
}
