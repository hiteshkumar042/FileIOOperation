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
            Console.WriteLine("\n1. Binary Serialization. \n2. Binary DeSerialization");
            Console.WriteLine("3. JSON Serialization. \n4. JSON DeSerialization");
            Console.WriteLine("5. XML Serialization. \n6. XML DeSerialization");
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
                case 3:
                    //JSON Serialization Operation
                    SerializatioOpearion.JSONSerializationFn();
                break;
                case 4:
                    //JSON DeSerialization Operation
                    SerializatioOpearion.JSONDeSerializationFn();
                    break;
                case 5:
                    //XML Serialization Operation
                    SerializatioOpearion.XMLSerializationFn();
                    break;
                case 6:
                    //XML DeSerialization Operation
                    SerializatioOpearion.XMLDeSerializationFn();
                    break;
                default:
                    Console.WriteLine("Choose from given option Only");
                break;
            }
            Console.ReadLine();
        }
    }
}
