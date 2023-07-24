using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR14
{
    public sealed class Singleton
    {
        private static Singleton _instance;

        private Singleton() { }

        public static Singleton GetInstance() => _instance == null ? (_instance = new Singleton()) : _instance;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            if (singleton1 == singleton2) Console.WriteLine("Singleton works, both variables contain the same instance.");
            else Console.WriteLine("Singleton failed, variables contain different instances.");
            Console.ReadLine();
        }
    }
}