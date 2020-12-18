using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average_daily_temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите минимальную температуру за сутки:  ");
            string StrValueMin = Console.ReadLine();
            int min = Convert.ToInt32(StrValueMin);
            Console.Write("Введите максимальную температуру за сутки: ");
            string StrValueMax = Console.ReadLine();
            int max = Convert.ToInt32(StrValueMax);
            Console.WriteLine((min+max)/2);
            Console.ReadLine();
        }
    }
}
