using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                (string firstName, string lastName, string patronymic) = GetFullName();
                Console.WriteLine($"Вы ввели: {lastName} {firstName} {patronymic}");
            }
            Console.ReadLine();
        }
        static (string firstName, string lastName, string patronymic) GetFullName()
        {
            Console.Write("Введите фамилию:\t");
            string lastName = Console.ReadLine();
            Console.Write("Введите имя:\t \t");
            string firstName = Console.ReadLine();
            Console.Write("Введите отчество:\t");
            string patronymic = Console.ReadLine();
            return (firstName, lastName, patronymic);
        }
    }
}
