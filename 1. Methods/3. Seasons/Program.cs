using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Seasons
{
    class Program
    {
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetSeasonRus(GetSeason()));
            Console.ReadLine();
        }
        static object GetSeason()
        {
            Console.Write("Введите порядковый номер месяца: ");
            int number = int.Parse(Console.ReadLine());
            object seasonEng = "";
            switch (number)
            {
                case 1:
                case 2:
                case 12:
                    seasonEng = (Season)0;
                    break;
                case 3:
                case 4:
                case 5:
                    seasonEng = (Season)1;
                    break;
                case 6:
                case 7:
                case 8:
                    seasonEng = (Season)2;
                    break;
                case 9:
                case 10:
                case 11:
                    seasonEng = (Season)3;
                    break;
                default:
                    seasonEng = "anotherNumber";
                    break;
            }
            return seasonEng;
        }
        static string GetSeasonRus(object seasonEng)
        {
            string[] seasons = { "Зима", "Весна", "Лето", "Осень" };
            string strSeasonEng = seasonEng.ToString();
            if (strSeasonEng != "anotherNumber")
            {
                int seasonNum = (int)seasonEng;
                return seasons[seasonNum];
            }
            else
                return "Ошибка: введите число от 1 до 12.";
        }
    }
}
