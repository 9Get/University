using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.IO;

namespace LR13
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public Person() { }
        
        public override string ToString()
        {
            return $"Name: {Name}, age: {Age}, country: {Country}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person { Name = "Zhongli", Age = 830, Country = "Liyue" };
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            using (FileStream file = new FileStream("C:\\Users\\9Get\\Desktop\\XmlFile.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(file, person1);
            }
            using (FileStream file = new FileStream("C:\\Users\\9Get\\Desktop\\XmlFile.xml", FileMode.OpenOrCreate))
            {
                Person person2 = (Person)xmlSerializer.Deserialize(file);
                Console.WriteLine(person2);
            }
            Console.ReadLine();
        }
    }
}