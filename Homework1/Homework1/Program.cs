using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя.");
            string name = Console.ReadLine();
            DateTime date = DateTime.Now;
            Console.WriteLine($"Привет, {name}, сегодня {date.ToString("dd.MM.yyyy")}.");
            Console.ReadLine();
        }
    }
}
