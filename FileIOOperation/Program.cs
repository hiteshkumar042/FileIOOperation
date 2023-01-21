using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Serialization and DeSerialazation..!");
            Console.WriteLine("\n1. Binary Serialization. \t2. Binary DeSerialization");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                //Binary Serialization Operation
                case 1:
                    SerializatioOpearion.BinarySerializationFn();
                    break;
                //Binary DeSerialization Operation
                case 2:
                    SerializatioOpearion.BinaryDeSerializationFn();
                    break;
                default:
                    Console.WriteLine("Choose from given option Only");
                break;
            }
            Console.ReadLine();
        }
    }
}
