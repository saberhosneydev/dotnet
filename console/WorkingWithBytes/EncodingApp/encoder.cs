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
            int key = random.Next(10);
            string computedString = "";
            for (int loop = 0; loop < encodedText.Length; loop++)
            {
                computedString += encodedText[loop];
            }
            long computedInt = Convert.ToInt64(computedString)*key;
            computedString = computedInt.ToString();
            char[] computedCharArr = computedString.ToCharArray();
            byte[] computedByteArr = new byte[computedCharArr.Length];
            for (int loop = 0; loop < computedCharArr.Length; loop++)
            {
                computedByteArr[loop] = Convert.ToByte(computedCharArr[loop]);
            }
            Console.WriteLine("Your key is : " + key);
            System.IO.File.WriteAllBytes("./encrypted.txt", computedByteArr);
        }
    }
}
