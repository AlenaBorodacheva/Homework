using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Phone_number
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string[,] catalog = new string[5, 2];
            string[] name =
            {
                "Иванов",
                "Петров",
                "Сидоров",
                "Борисов",
                "Пугачев",
            };
            string[] number =
            {
                "8-910-991-66-61",
                "8-800-555-35-35",
                "8-901-234-56-78",
                "8-495-333-33-33",
                "8-915-155-15-15",
            };

            //Записываем два одномерных массива в один двумерный
            for (int i = 0; i < name.Length; i++)
                catalog[i, 0] = name[i];

            for (int j = 0; j < number.Length; j++)
                catalog[j, 1] = number[j];


            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();
            
            bool isFound = false;

            for (int i = 0; i < catalog.Length; i++)
            {
                if (catalog[i,0] == lastName)
                {
                    Console.WriteLine($"{lastName}: {catalog[i, 1]}");
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("Такой фамилии нет в справочнике.");
            }

            Console.ReadLine();
        }
    }
}
