using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1.File_txt
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "text.txt";
            Console.WriteLine("Введите данные:");
            while (true)
            {
                string data = Console.ReadLine();
                File.AppendAllText(filename, data);
                File.AppendAllText(filename, Environment.NewLine);
                Console.WriteLine("Для продолжения нажмите любую клавишу. Для выхода нажмите Esc.");
                if (Console.ReadKey(true).Key != ConsoleKey.Escape)
                    Console.WriteLine("Введите следующее значение:");
                else
                    break;
            }
        }
    }
}
