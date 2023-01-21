using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace FileIOOperation
{
    public class SerializatioOpearion
    {
        //Binary Serialization Operation
        public static void BinarySerializationFn()
        {
            string path = @"C:\Users\hksol\source\repos\FileIOOperation\FileIOOperation\Files\BinaryData.txt";
            try
            {
                List<Contact> contact = new List<Contact>()
                {
                    new Contact() {Id = 363, Name="Hitesh", Age= 26},
                    new Contact() {Id = 364, Name="Dheeraj", Age= 24},
                    new Contact() {Id = 365, Name="Surya", Age= 28},
                };
                FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, contact);
                stream.Close();
                Console.WriteLine("Binary Serialization Completed Succesfully");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //Binary DeSerialization Operation
        public static void BinaryDeSerializationFn()
        {
            string path = @"C:\Users\hksol\source\repos\FileIOOperation\FileIOOperation\Files\BinaryData.txt";
            try
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                List<Contact> listofcontact = (List<Contact>)bf.Deserialize(stream);
                stream.Close();
                foreach (Contact contact in listofcontact)
                {
                    Console.WriteLine(contact);
                }
                Console.WriteLine("Binary Deserialization Completed Succesfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //JSON Serialization Operation
        public static void JSONSerializationFn()
        {
            string path = @"C:\Users\hksol\source\repos\FileIOOperation\FileIOOperation\Files\JSONData.json";
            try
            {
                List<Contact> contact = new List<Contact>()
                {
                    new Contact() {Id = 363, Name="Manish", Age= 26},
                    new Contact() {Id = 364, Name="Dheeraj", Age= 24},
                    new Contact() {Id = 365, Name="Ramesh", Age= 28},
                };
                string jsonData = JsonConvert.SerializeObject(contact);
                File.WriteAllText(path, jsonData);
                Console.WriteLine("JSON Serialization Completed Succesfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //JSON DeSerialization Operation
        public static void JSONDeSerializationFn()
        {
            string path = @"C:\Users\hksol\source\repos\FileIOOperation\FileIOOperation\Files\JSONData.json";
            try
            {
                string jsonData = File.ReadAllText(path);
                List<Contact> contacts = JsonConvert.DeserializeObject<List<Contact>>(jsonData);
                foreach (Contact contact in contacts)
                {
                    Console.WriteLine(contact);
                }
                Console.WriteLine("JSON Deserialization Completed Succesfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //XML Serialization Operation
        public static void XMLSerializationFn()
        {
            string path = @"C:\Users\hksol\source\repos\FileIOOperation\FileIOOperation\Files\XMLData.xml";
            try
            {
                List<Contact> contact = new List<Contact>()
                {
                    new Contact() {Id = 363, Name="Manish", Age= 26},
                    new Contact() {Id = 364, Name="Dheeraj", Age= 24},
                    new Contact() {Id = 365, Name="Ramesh", Age= 28},
                };
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Contact>));
                StreamWriter sw = new StreamWriter(path);
                xmlSerializer.Serialize(sw, contact);
                Console.WriteLine("XML Serialization Successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //XML DeSerialization Operation
        public static void XMLDeSerializationFn()
        {
            try
            {
                string path = @"C:\Users\hksol\source\repos\FileIOOperation\FileIOOperation\Files\XMLData.xml";
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Contact>));
                FileStream stream = new FileStream(path, FileMode.Open);
                List<Contact> record = (List<Contact>)xmlSerializer.Deserialize(stream);
                foreach (Contact contact in record)
                {
                    Console.WriteLine(contact);
                }
                Console.WriteLine("XML Deserialization Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
