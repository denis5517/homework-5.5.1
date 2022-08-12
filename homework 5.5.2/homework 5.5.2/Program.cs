using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_5._5._2
{
    internal class Program
    {
        static string[] WordSplitter(string text)
        {
            string[] WordsSplit = text.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            return WordsSplit;
        }

        private static void PrintArray(string[] array)
        {
            {
                foreach (var item in array)
                {
                    Console.WriteLine((item));
                }
            }
        }

        static string[] WordsSplit2(string text)
        {

            string[] WordsSplit2 = text.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            string[] newText = ReversWords(WordsSplit2);
            return newText;
        }

        static string[] ReversWords(string[] text)
        {
            Array.Reverse(text);
            return text;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите предложение, каждое слово отделите пробелом.");
            string text = Console.ReadLine();
            string[] result = WordsSplit2(text);
            PrintArray(result);
            Console.ReadLine();
        }
    }   
}

