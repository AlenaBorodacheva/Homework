using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_of_month
{
    class Program
    {
        enum Month
        {
            январь,
            февраль,
            март,
            апрель,
            май,
            июнь,
            июль,
            август,
            сентябрь,
            октябрь,
            ноябрь,
            декабрь
        }
        static void Main(string[] args)
        {
           
            Console.Write("Введите порядковый номер месяца: ");
            while (true)
            {
                //string StrNum = Console.ReadLine();
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 12 || num < 1) 
                    Console.Write("Введите число от 1 до 12: ");
                else
                    Console.Write($"Месяц: {(Month)num-1}. Введите порядковый номер месяца:  ");
            }
        
        }
          
    }
}

