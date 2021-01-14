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
            //Without_Recursion();
            With_Recursion();
        }
        static void Without_Recursion()
        {
            string dirName = "E:\\test\\";
            string filename = "text.txt";
            
            string[] dirs = Directory.GetDirectories(dirName);
            foreach (string s in dirs)
            {
                File.AppendAllText(filename, s);
                File.AppendAllText(filename, Environment.NewLine);
            }

            string[] files = Directory.GetFiles(dirName);
            foreach (string s in files)
            {
                File.AppendAllText(filename, s);
                File.AppendAllText(filename, Environment.NewLine);
            }

            string[] allDirs;
            allDirs = Directory.GetDirectories(dirName, "*", SearchOption.AllDirectories);
            string[] subFiles;
            string[] subDirs;

            for (int i = 0; i < allDirs.Length; i++)
            {
                subFiles = Directory.GetFiles(allDirs[i]);
                subDirs = Directory.GetDirectories(allDirs[i]);
                foreach (string s in subDirs)
                {
                    File.AppendAllText(filename, s);
                    File.AppendAllText(filename, Environment.NewLine);
                }
                foreach (string s in subFiles)
                {
                    File.AppendAllText(filename, s);
                    File.AppendAllText(filename, Environment.NewLine);
                }
            }
        }
        
        static void With_Recursion()
        {
            string dirName = "E:\\test\\";
            string filename = "text2.txt";

            List<string> ls1 = GetRecursFiles(dirName);
            foreach (string s in ls1)
            {
                File.AppendAllText(filename, s);
                File.AppendAllText(filename, Environment.NewLine);
            }
            
            List<string> GetRecursFiles(string start_path)
            {
                List<string> ls = new List<string>();
                try
                {
                    string[] folders = Directory.GetDirectories(start_path);
                    foreach (string s in folders)
                    {
                        ls.Add(s);
                        ls.AddRange(GetRecursFiles(s));
                    }
                    string[] files = Directory.GetFiles(start_path);
                    foreach (string s in files)
                    {
                        ls.Add(s);
                    }
                }
                catch (System.Exception e)
                {
                    File.AppendAllText(filename, e.Message);
                    File.AppendAllText(filename, Environment.NewLine);
                }
                return ls;
            }
        }
    }
}
