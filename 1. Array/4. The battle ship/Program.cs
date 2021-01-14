using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.The_battle_ship
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 10;
            char[,] a = new char[size+2, size+2];

            //Вывод пустого поля
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    a[i,j] = '.';
            }

            //Вывод однопалубных
            int count1 = 4;
            for (int y = 0; y < count1; y++)
            {
                int mIndex = rnd.Next(1, size);
                int nIndex = rnd.Next(1, size);
                if (a[mIndex, nIndex] != 'X' && 
                    a[mIndex + 1, nIndex] != 'X' && 
                    a[mIndex, nIndex + 1] != 'X' && 
                    a[mIndex + 1, nIndex + 1] != 'X' && 
                    a[mIndex - 1, nIndex] != 'X' && 
                    a[mIndex, nIndex - 1] != 'X' && 
                    a[mIndex - 1, nIndex - 1] != 'X' && 
                    a[mIndex - 1, nIndex + 1] != 'X' && 
                    a[mIndex + 1, nIndex - 1] != 'X')
                {
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            a[mIndex, nIndex] = 'X';
                        }
                    }
                }
                else
                {
                    count1++;
                    continue;
                }
            }

            //Вывод четырехпалубника
            int count4 = 1;
            for (int y = 0; y < count4; y++)
            {
                int r = rnd.Next(2);
                if (r == 0)
                {
                    int mIndex = rnd.Next(1, size - 3);
                    int nIndex = rnd.Next(1, size);
                    if (a[mIndex, nIndex] != 'X' && 
                        a[mIndex + 1, nIndex] != 'X' && 
                        a[mIndex + 2, nIndex] != 'X' && 
                        a[mIndex + 3, nIndex] != 'X' && 
                        a[mIndex, nIndex - 1] != 'X' && 
                        a[mIndex + 1, nIndex - 1] != 'X' && 
                        a[mIndex + 2, nIndex - 1] != 'X' && 
                        a[mIndex + 3, nIndex - 1] != 'X' && 
                        a[mIndex, nIndex + 1] != 'X' && 
                        a[mIndex + 1, nIndex + 1] != 'X' && 
                        a[mIndex + 2, nIndex + 1] != 'X' && 
                        a[mIndex + 3, nIndex + 1] != 'X' && 
                        a[mIndex - 1, nIndex - 1] != 'X' && 
                        a[mIndex - 1, nIndex] != 'X' && 
                        a[mIndex - 1, nIndex + 1] != 'X' && 
                        a[mIndex + 4, nIndex - 1] != 'X' && 
                        a[mIndex + 4, nIndex] != 'X' && 
                        a[mIndex + 4, nIndex + 1] != 'X')
                    {
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                a[mIndex, nIndex] = 'X';
                                a[mIndex + 1, nIndex] = 'X';
                                a[mIndex + 2, nIndex] = 'X';
                                a[mIndex + 3, nIndex] = 'X';
                            }
                        }
                    }
                    else
                    {
                        count4++;
                    }
                }
                else
                {
                    int mIndex = rnd.Next(1, size);
                    int nIndex = rnd.Next(1, size - 3);
                    if (a[mIndex, nIndex] != 'X' && 
                        a[mIndex, nIndex + 1] != 'X' && 
                        a[mIndex, nIndex + 2] != 'X' && 
                        a[mIndex, nIndex + 3] != 'X' && 
                        a[mIndex + 1, nIndex] != 'X' && 
                        a[mIndex + 1, nIndex + 1] != 'X' && 
                        a[mIndex + 1, nIndex + 2] != 'X' && 
                        a[mIndex + 1, nIndex + 3] != 'X' && 
                        a[mIndex - 1, nIndex] != 'X' && 
                        a[mIndex - 1, nIndex + 1] != 'X' && 
                        a[mIndex - 1, nIndex + 2] != 'X' && 
                        a[mIndex - 1, nIndex + 3] != 'X' && 
                        a[mIndex - 1, nIndex - 1] != 'X' && 
                        a[mIndex, nIndex - 1] != 'X' && 
                        a[mIndex + 1, nIndex - 1] != 'X' && 
                        a[mIndex - 1, nIndex + 4] != 'X' && 
                        a[mIndex, nIndex + 4] != 'X' && 
                        a[mIndex + 1, nIndex + 4] != 'X')
                    {
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                a[mIndex, nIndex] = 'X';
                                a[mIndex, nIndex + 1] = 'X';
                                a[mIndex, nIndex + 2] = 'X';
                                a[mIndex, nIndex + 3] = 'X';
                            }
                        }
                    }
                    else
                    {
                        count4++;
                    }
                }
            }

            //Вывод трехпалубных
            int count3 = 2;
            for (int y = 0; y < count3; y++)
            {
                int r = rnd.Next(2);
                if (r == 0)
                {
                    int mIndex = rnd.Next(1, size - 2);
                    int nIndex = rnd.Next(1, size);
                    if (a[mIndex, nIndex] != 'X' && 
                        a[mIndex + 1, nIndex] != 'X' && 
                        a[mIndex + 2, nIndex] != 'X' && 
                        a[mIndex, nIndex - 1] != 'X' && 
                        a[mIndex + 1, nIndex - 1] != 'X' && 
                        a[mIndex + 2, nIndex - 1] != 'X' && 
                        a[mIndex, nIndex + 1] != 'X' && 
                        a[mIndex + 1, nIndex + 1] != 'X' && 
                        a[mIndex + 2, nIndex + 1] != 'X' && 
                        a[mIndex - 1, nIndex - 1] != 'X' && 
                        a[mIndex - 1, nIndex] != 'X' && 
                        a[mIndex - 1, nIndex + 1] != 'X' && 
                        a[mIndex + 3, nIndex - 1] != 'X' && 
                        a[mIndex + 3, nIndex] != 'X' && 
                        a[mIndex + 3, nIndex + 1] != 'X')
                    { 
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                a[mIndex, nIndex] = 'X';
                                a[mIndex + 1, nIndex] = 'X';
                                a[mIndex + 2, nIndex] = 'X';
                            }
                        }
                    }
                    else
                    {
                        count3++;
                    }
                }
                else
                {
                    int mIndex = rnd.Next(1, size);
                    int nIndex = rnd.Next(1, size - 2);
                    if (a[mIndex, nIndex] != 'X' && 
                        a[mIndex, nIndex + 1] != 'X' && 
                        a[mIndex, nIndex + 2] != 'X' && 
                        a[mIndex + 1, nIndex] != 'X' && 
                        a[mIndex + 1, nIndex + 1] != 'X' && 
                        a[mIndex + 1, nIndex + 2] != 'X' && 
                        a[mIndex - 1, nIndex] != 'X' && 
                        a[mIndex - 1, nIndex + 1] != 'X' && 
                        a[mIndex - 1, nIndex + 2] != 'X' && 
                        a[mIndex - 1, nIndex - 1] != 'X' && 
                        a[mIndex, nIndex - 1] != 'X' && 
                        a[mIndex + 1, nIndex - 1] != 'X' && 
                        a[mIndex - 1, nIndex + 3] != 'X' && 
                        a[mIndex, nIndex + 3] != 'X' && 
                        a[mIndex + 1, nIndex + 3] != 'X')
                    {
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                a[mIndex, nIndex] = 'X';
                                a[mIndex, nIndex + 1] = 'X';
                                a[mIndex, nIndex + 2] = 'X';
                            }
                        }
                    }
                    else
                    {
                        count3++;
                    }
                }
            }

            //Вывод двухпалубных
            int count2 = 3;
            for (int y = 0; y < count2; y++)
            {
                int r = rnd.Next(2);
                if (r == 0)
                {
                    int mIndex = rnd.Next(1, size - 1);
                    int nIndex = rnd.Next(1, size);
                    if (a[mIndex, nIndex] != 'X' && 
                        a[mIndex + 1, nIndex] != 'X' && 
                        a[mIndex, nIndex - 1] != 'X' && 
                        a[mIndex + 1, nIndex - 1] != 'X' && 
                        a[mIndex, nIndex + 1] != 'X' && 
                        a[mIndex + 1, nIndex + 1] != 'X' && 
                        a[mIndex - 1, nIndex - 1] != 'X' && 
                        a[mIndex - 1, nIndex] != 'X' && 
                        a[mIndex - 1, nIndex + 1] != 'X' && 
                        a[mIndex + 2, nIndex - 1] != 'X' && 
                        a[mIndex + 2, nIndex] != 'X' && 
                        a[mIndex + 2, nIndex + 1] != 'X')
                    {
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                a[mIndex, nIndex] = 'X';
                                a[mIndex + 1, nIndex] = 'X';
                            }
                        }
                    }
                    else
                    {
                        count2++;
                    }
                }
                else
                {
                    int mIndex = rnd.Next(1, size);
                    int nIndex = rnd.Next(1, size - 1);
                    if (a[mIndex, nIndex] != 'X' && 
                        a[mIndex, nIndex + 1] != 'X' && 
                        a[mIndex + 1, nIndex] != 'X' && 
                        a[mIndex + 1, nIndex + 1] != 'X' && 
                        a[mIndex - 1, nIndex] != 'X' && 
                        a[mIndex - 1, nIndex + 1] != 'X' && 
                        a[mIndex - 1, nIndex - 1] != 'X' && 
                        a[mIndex, nIndex - 1] != 'X' && 
                        a[mIndex + 1, nIndex - 1] != 'X' && 
                        a[mIndex - 1, nIndex + 2] != 'X' && 
                        a[mIndex, nIndex + 2] != 'X' && 
                        a[mIndex + 1, nIndex + 2] != 'X')
                    {
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                a[mIndex, nIndex] = 'X';
                                a[mIndex, nIndex + 1] = 'X';
                            }
                        }
                    }
                    else
                    {
                        count2++;
                    }
                }
            }
            
            //Вывод результата
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
