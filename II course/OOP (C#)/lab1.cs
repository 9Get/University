using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Test
    {
        public int x;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*string name = "Stas";
            int age = 18;
            Console.WriteLine("What is your name?");
            name=Console.ReadLine();
            Console.WriteLine("Hello,"+"Stas");
            Console.WriteLine("Hello," + name);
            Console.WriteLine("input age");
            string str = Console.ReadLine();
            //age = int.Parse(str);
            bool flaf = int.TryParse(str, out age);
            if (flaf)
                Console.WriteLine($"Hello, name={name} age={age * 2}");
            else
                Console.WriteLine("error");
            Console.WriteLine("Hello,name={0} age={1}{0}", name,age);//1v
            //Console.WriteLine($"Hello, name={name} age={age*2}");//2v
            */
            //int n = 2, k = 3;
            //Console.WriteLine("hello" + n + k);
            //Console.WriteLine(n + k);
            //Console.WriteLine(n.ToString() + k);
            //var l = 4;
            //int[] array = { 1, 2, 3 };
            //int[] array2 = new int[3];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"array[{i}] = {array[i]}");
            //    array[i] *= 2;
            //}
            //foreach (var temp in array)
            //{
            //    //temp *= 2;
            //    Console.WriteLine($"array={temp}");
            //}
            //int a = 3, b = 4;
            //a = b; b = 9;
            //Test test1 = new Test();
            //Test test2 = new Test();
            //test1.x = 8;
            //test2.x = 9;
            //test2 = test1;
            //test1.x = 3;
            //Console.WriteLine($"test1.x = {test1.x} test2.x = {test2.x}");
            //int y = 6;
            //float f = (float)y;
            //y = (int)f;
            //double d = f;
            //f = (float)d;
            //Console.ReadLine();

            Console.WriteLine("What do you want to enter? (Name or Age)");
            string userRequest = Console.ReadLine();
            //int num = Convert.ToInt32(Console.ReadLine());

            switch (userRequest)
            {
                case "Name":
                    string name = Console.ReadLine();
                    Console.WriteLine($"Your name is {name}.");
                    break;

                case "Age":
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Your age is {age}.");
                    break;

                default:
                    Console.WriteLine("ERROR! Check your request!");
                    break;
            }

            Console.ReadKey();
        }
    }
}