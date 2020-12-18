using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string StrNum = Console.ReadLine();
            int num = Convert.ToInt32(StrNum);
            if (num % 2 == 0)
                Console.Write("Число четное.");
            else
                Console.Write("Число нечетное.");
            Console.ReadLine();

        }
    }
}
