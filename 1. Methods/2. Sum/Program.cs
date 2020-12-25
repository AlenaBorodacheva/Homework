using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые числа, разделяя их пробелом: ");
            string values = Console.ReadLine();
            string[] numbers = values.Split(' ');
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int x = int.Parse(numbers[i]);
                sum += x;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
