using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _3.Binary_file
{
    [Serializable]
    class Number
    {
        public byte Byte { get; set; }
        public Number(byte name)
        {
            Byte = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Write();
            //Read();
        }
        static void Write()
        {
            Console.WriteLine("Введите количество элементов массива:");
            int count = int.Parse(Console.ReadLine());
            Number[] b = new Number[count];

            Console.WriteLine("Введите числа от 0 до 255.");
            for (int i = 0; i < count; i++)

                b[i] = new Number(byte.Parse(Console.ReadLine()));

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("number.bin", FileMode.OpenOrCreate), b);
        }

        static void Read()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Number[] b = (Number[])formatter.Deserialize(new FileStream("number.bin", FileMode.Open));

            foreach (Number i in b)

                Console.WriteLine(i.Byte);

            Console.ReadLine();
        }
    }
}
