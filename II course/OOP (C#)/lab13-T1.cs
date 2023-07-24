using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.IO;

namespace LR13
{
    [Serializable]
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

    [DataContract]
    public class Student
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public int Group { get; set; }

        public Student() { }

        public override string ToString()
        {
            return $"Name: {Name}, age: {Age}, group: {Group}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person { Name = "Venti", Age = 760, Country = "Mondstadt" };
            SoapFormatter soapFormatter = new SoapFormatter();

            using(FileStream file = new FileStream("C:\\Users\\9Get\\Desktop\\SFile.dat", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(file, person1);
            }

            using (FileStream file = new FileStream("C:\\Users\\9Get\\Desktop\\SFile.dat", FileMode.Open))
            {
                Person person2 = (Person)soapFormatter.Deserialize(file);
                Console.WriteLine(person2);
            }

            Student student1 = new Student { Name = "Albedo", Age = 546, Group = 120 };
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Student));
            using (FileStream file = new FileStream("C:\\Users\\9Get\\Desktop\\JSFile.json", FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(file, student1);
            }
            using (FileStream file = new FileStream("C:\\Users\\9Get\\Desktop\\JSFile.json", FileMode.OpenOrCreate))
            {
                Student student2 = (Student)jsonSerializer.ReadObject(file);
                Console.WriteLine(student2);
            }
            Console.ReadLine();
        }
    }
}