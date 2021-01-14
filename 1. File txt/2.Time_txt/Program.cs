using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2.Time_txt
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";
            File.AppendAllText(filename, DateTime.Now.ToLongTimeString());
            File.AppendAllText(filename, Environment.NewLine);
        }
    }
}
