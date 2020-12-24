using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int count = int.Parse(Console.ReadLine());
            int[,] a = new int[count,count];
            for (int i = 0; i < count; i++) { 
                for (int j = 0; j < count; j++) {
                    Console.WriteLine($"Введите элемент массива с координатами {i},{j}.");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Введенный массив:");

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Элементы массива по диагонали:");

            for (int i = 0; i < count; i++)
            Console.WriteLine(a[i,i]);
            Console.ReadLine();
        }
    }
}
