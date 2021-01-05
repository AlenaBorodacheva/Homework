using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rainy_winter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите месяц: ");
            string month = Console.ReadLine();
            month = month.ToLower();
            Console.Write("Введите минимальную суточную температуру: ");
            int tempMin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальную суточную температуру: ");
            int tempMax = Convert.ToInt32(Console.ReadLine());
            int averageTemp = (tempMin + tempMax) / 2;
            if (month == "декабрь" || month == "январь" || month == "февраль" && averageTemp > 0)
            Console.Write("Дождливая зима.");
            Console.ReadLine();
        }
    }
}
