using System;

namespace DecodingApp
{
    class Decoder
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Let's start with your key !");
                int key =  Convert.ToInt32(Console.ReadLine());
                byte[] encodedText = System.IO.File.ReadAllBytes("./encrypted.txt");
                Decoding(encodedText, key);
                //Console.ReadKey();

        }
        static void Decoding(byte[] encodedText, int key)
        {
            string computedString = "";
            for (int loop = 0; loop < encodedText.Length; loop++)
            {
                computedString += encodedText[loop];
            }
            Console.WriteLine(computedString);
            long computedInt = Convert.ToInt64(computedString)/key;
            computedString = computedInt.ToString();
            char[] computedCharArr = computedString.ToCharArray();
            byte[] computedByteArr = new byte[computedCharArr.Length];
            for (int loop = 0; loop < computedCharArr.Length; loop++)
            {
                computedByteArr[loop] = Convert.ToByte(computedCharArr[loop]);
            }
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(computedByteArr));
        }
    }
}