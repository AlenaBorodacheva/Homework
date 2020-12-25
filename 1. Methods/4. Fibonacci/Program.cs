using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите положительный индекс члена числа Фибоначчи: \t");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(number));
            Console.ReadLine();
        }
        static int Fibonacci(int number)
        {
            int num1 = 0;
            int num2 = 1;
            if (number == 1) 
                return num1;
            else if (number == 2)
                return num2;
            else 
            return Fibonacci(number - 1) + Fibonacci(number - 2); 
        }
    }
}
