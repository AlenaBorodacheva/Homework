using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}");
            }
            Console.WriteLine("Если хотите выбрать процесс по ID, введите 0. Если хотите выбрать процесс по имени, введите 1.");

            try
            {
                int change = int.Parse(Console.ReadLine());
                if (change == 0)
                {
                    Console.WriteLine("Введите ID процесса.");
                    int ID = int.Parse(Console.ReadLine());
                    Process PrID = Process.GetProcessById(ID);
                    PrID.Kill();
                }
                else if (change == 1)
                { 
                    Console.WriteLine("Введите имя процесса.");
                    string name = Console.ReadLine();
                    Process[] PrName = Process.GetProcessesByName(name);
                    foreach (Process s in PrName)
                    {
                        s.Kill(); 
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели другое число.");
                }
            }
        
            catch
            {
                Console.WriteLine("Вы ввели несуществующее значение.");
            }
            
            Console.WriteLine("Процесс завершен.");
            Console.ReadLine();
        }
    }
}
