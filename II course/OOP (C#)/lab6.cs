using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    sealed class Worker
    {
        readonly string name;
        int age;

        public Worker() {}
        public Worker(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public static Worker operator+ (Worker worker1, Worker worker2)
        {
            return new Worker(worker1.name, worker1.age + worker2.age);
        }

        public static Worker operator++(Worker worker)
        {
            return new Worker(worker.name, worker.age++);
        }

        public static Worker operator -(Worker worker, int num)
        {
            return new Worker(worker.name, worker.age - num);
        }

        public static explicit operator Int32(Worker worker)
        {
            return worker.age;
        }

        public static implicit operator Worker(int num)
        {
            return new Worker("None", num);
        }

        public int Age
        {
            get => age;
        }

        public bool FindName(Worker [] workerArr, String str)
        {
            for(int i = 0; i<workerArr.Length; i++)
            {
                if (workerArr[i].name == str) return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Name: {name}\nAge: {age}";
        }

    }

    static class MethodWorker
    {
        public static int AverageAge(this Worker worker, params Worker[] workers)
        {
            int sum = 0;
            foreach (var element in workers)
            {
                sum += element.Age;
            }

            return sum / workers.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            Worker worker1 = new Worker("Mark", 23);
            Worker worker2 = new Worker("Mark", 28);
            Worker worker3 = new Worker("Mark", 31);

            Console.WriteLine($"Average age of workers: { worker.AverageAge(worker1, worker2, worker3)}");

            worker = worker3 + worker1;

            Console.WriteLine($"Operator of + :{worker.Age}");
            Console.WriteLine($"Operator of ++ :{worker1++.Age}");
            Console.WriteLine(worker1.Age);

            int varA = 18;
            worker = worker2 - varA;
            Console.WriteLine($"Operator of - :{worker.Age}");

            Console.WriteLine();
            varA = worker2.Age;
            Console.WriteLine($"varA = {varA}");

            int varB = (int)worker1.Age;
            Console.WriteLine($"varA = {varB}");

            Worker[] workerArr = { worker1, worker2, worker3 };
            String strToFind = Console.ReadLine();

            if (worker.FindName(workerArr, strToFind)) Console.WriteLine("The string is in the array");
            else Console.WriteLine("The string is not in the array");

            Console.ReadLine();
        }
    }
}