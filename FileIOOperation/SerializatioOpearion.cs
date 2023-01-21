using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperation
{
    public class SerializatioOpearion
    {
        public static string path = @"C:\Users\hksol\source\repos\FileIOOperation\FileIOOperation\Files\BinaryData.txt";
        //Binary Serialization Operation
        public static void BinarySerializationFn()
        {
            List<Contact> contact = new List<Contact>()
            {
                new Contact() {Id = 363, Name="Hitesh", Age= 26},
                new Contact() {Id = 364, Name="Dheeraj", Age= 24},
                new Contact() {Id = 365, Name="Surya", Age= 28},
            };
            FileStream stream = new FileStream(path,FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, contact);
            stream.Close();
            Console.WriteLine("Binary Serialization Completed Succesfully");
        }
        //Binary DeSerialization Operation
        public static void BinaryDeSerializationFn()
        {
           
            FileStream stream = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<Contact> listofcontact =(List<Contact>) bf.Deserialize(stream);
            stream.Close();
            foreach(Contact contact in listofcontact)
            {
                Console.WriteLine(contact);
            }
            Console.WriteLine("Binary Deserialization Completed Succesfully");
        }
    }
}
