using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите Ваше имя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Console.WriteLine("Введите Ваш возраст:");
                Properties.Settings.Default.UserAge = Console.ReadLine();
                Console.WriteLine("Введите Ваш род деятельности:");
                Properties.Settings.Default.UserCareer = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string userName = Properties.Settings.Default.UserName;
            string userAge = Properties.Settings.Default.UserAge;
            string userCareer = Properties.Settings.Default.UserCareer;
            string greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine($"{greeting}, {userName}!");
            Console.WriteLine($"Возраст: {userAge}, род деятельности: {userCareer}.");
            Console.ReadLine();
            
        }
    }
}
