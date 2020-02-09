using System;

namespace EncodingApp
{
    class Encoder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inter your data");
            string text = Console.ReadLine();
            Encoding(text);
            Console.ReadKey();
        }
        static void Encoding(string text)
        {
            byte[] encodedText = System.Text.Encoding.UTF8.GetBytes(text);
            var random = new Random();
            int key = random.Next(50000);
            for (int loop = 0; loop < encodedText.Length; loop++)
            {
                encodedText[loop] *= Convert.ToByte(key);
            }
            Console.WriteLine("Your key is : " + key);
            System.IO.File.WriteAllBytes("./encrypted.txt", encodedText);
        }
    }
}
