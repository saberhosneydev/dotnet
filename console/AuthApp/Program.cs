using System;
using System.Text.RegularExpressions;
namespace AuthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] key = {'8', '2', '5'};
            Encode("This Gonna Be FUn", key);
        }
        static void Encode(string text, char[] key)
        {
            char[] dictionary = " !@#$%&ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var regex = new Regex(@".{" + key.Length + "}");
            string result = regex.Replace(text, "$&" + "~");
            string[] strlist = result.Split('~');
            foreach (var str in strlist)
            {
                char[] charlist = str.ToCharArray();
                Console.WriteLine("It was :" + str);
                for (int i = 0; i < charlist.Length; i++)
                {
                    charlist[i] = dictionary[key[i]];
                }
                Console.WriteLine(charlist);
            }
        }   
    }
}
