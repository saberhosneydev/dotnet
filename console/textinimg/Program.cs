using System;

namespace textinimg
{
    class Program 
    {
        static void Main(string[] args)
        {
            byte[] bytearr = Encoder("Love");
            Decoder(bytearr);
            //EncodeImg("./img.jpg", "Loves");
            //DecodeImg("./file.jpg");
        }
        static void EncodeImg(string path, string text)
        {
            byte[] imgbytes = System.IO.File.ReadAllBytes(path);
            byte[] textbytes = System.Text.Encoding.UTF8.GetBytes(text);
            Console.WriteLine(textbytes.Length);
            int imgbyteslength = imgbytes.Length;
            Array.Resize(ref imgbytes, imgbytes.Length + textbytes.Length);
            for (int loop = imgbytes.Length; loop < (imgbyteslength + textbytes.Length); loop++)
            {
                for (int i = 0; i < textbytes.Length; i++)
                {
                    imgbytes[loop] = textbytes[i];
                }
            }
            System.IO.File.WriteAllBytes("./file.jpg", imgbytes);
        }
        static void DecodeImg(string path)
        {
            byte[] imgbytes = System.IO.File.ReadAllBytes(path);
            byte[] strings = new byte[4];
            for (int loop = imgbytes.Length; loop < (imgbytes.Length - 4); loop--)
            {
                for (int i = 0; i < strings.Length; i++)
                {
                    strings[i] = imgbytes[loop];
                }
            }
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(strings));
        }
        static byte[] Encoder(string text)
        {
            byte[] encodedText = System.Text.Encoding.UTF8.GetBytes(text);
            string printed = "";
            for(int loop = 0; loop < encodedText.Length; loop++)
            {
                printed += encodedText[loop];
            }
            Console.WriteLine(printed);
            return encodedText;
        }
        static void Decoder(byte[] encodedText) {
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(encodedText));
        }
    }
}
