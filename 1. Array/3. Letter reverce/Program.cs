using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Letter_reverce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string word = Console.ReadLine();

            for (int i = word.Length; i > 0; i--)
            {
                Console.Write(word[i-1]);
            }

            Console.ReadLine();
        }
    }
}
