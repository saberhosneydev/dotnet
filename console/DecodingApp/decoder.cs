using System;

namespace textinimg
{
    class Decoder
    {
        static void Main(string[] args)
        {
            if (args[0] == "love")
            {
                Console.WriteLine("Let's start with your key !");
                int key = Int32.Parse(Console.ReadLine());
                byte[] encodedText = System.IO.File.ReadAllBytes("./encrypted.txt");
                Decoding(encodedText, key);
            }

        }
        static void Decoding(byte[] encodedText, int key)
        {
            int printed = 0;
            for (int loop = 0; loop < encodedText.Length; loop++)
            {
                printed += encodedText[loop];
            }
            printed = printed / key;
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(encodedText));
        }
    }
}