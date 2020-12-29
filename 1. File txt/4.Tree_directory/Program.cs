using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4.Tree_directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Without_Recursion();
            //With_Recursion();
        }
        static void Without_Recursion()
        {
            string dirName = "E:\\Заставки\\";
            string filename = "text.txt";

            if (Directory.Exists(dirName))
            {
                File.AppendAllText(filename, "Подкаталоги:");
                File.AppendAllText(filename, Environment.NewLine);
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    File.AppendAllText(filename, s);
                    File.AppendAllText(filename, Environment.NewLine);
                }

                File.AppendAllText(filename, "Файлы:");
                File.AppendAllText(filename, Environment.NewLine);
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    File.AppendAllText(filename, s);
                    File.AppendAllText(filename, Environment.NewLine);
                }
            }

        }
        static void With_Recursion()
        {
            string dirName = "E:\\Заставки\\";
            string filename = "text.txt";
            foreach (string s in Recursion(dirName, filename))
            {
                File.AppendAllText(filename, s);
                File.AppendAllText(filename, Environment.NewLine);
            }
        }
        static string[] Recursion(string dirName, string filename)
        {
            if (Directory.Exists(dirName))
            {
                File.AppendAllText(filename, "Подкаталоги:");
                File.AppendAllText(filename, Environment.NewLine);
                string[] dirs = Directory.GetDirectories(dirName);
                return dirs;
            }
            else
            {
                return Recursion(dirName, filename);
            }
        }
    }
}
