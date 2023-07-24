using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    public enum Months
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }

    public static class MethodForEnum
    {
        public static void CheckMonth(this Months mth)
        {
            if ((int)mth == 3) Console.WriteLine("Spring came!!!");
        }
    }

    class Worker<Type> {
        String name;
        Type age = default(Type);
        public static Type salary = default(Type);

        public Worker(String name, Type age)
        {
            this.name = name;
            this.age = age;
        }
        public static Type SumOfSalary<Type>(params Worker<Type>[] workers)
        {
            Type sum = default(Type);
            for(int i = 0; i < workers.Length; i++)
            {
                sum += (dynamic)workers[i].age;
            }
            return sum;
        }
    }


    class Program
    {
        public void PrintInfoMonth (Months month)
        {
            switch (month)
            {
                case Months.January: 
                    Console.WriteLine("January");
                    break;
                case Months.February:
                    Console.WriteLine("February");
                    break;
                case Months.March:
                    Console.WriteLine("March");
                    break;
                case Months.April:
                    Console.WriteLine("April");
                    break;
                case Months.May:
                    Console.WriteLine("May");
                    break;
                case Months.June:
                    Console.WriteLine("June");
                    break;
                case Months.July:
                    Console.WriteLine("July");
                    break;
                case Months.August:
                    Console.WriteLine("August");
                    break;
                case Months.September:
                    Console.WriteLine("September");
                    break;
                case Months.October:
                    Console.WriteLine("October");
                    break;
                case Months.November:
                    Console.WriteLine("November");
                    break;
                case Months.December:
                    Console.WriteLine("December");
                    break;
                default: Console.WriteLine("Entered the wrong month");
                    break;
            }
        }
        static void Main(string[] args)
        {
            String[] strEnum = Enum.GetNames(typeof(Months));
            Program program = new Program();

            for(int i = 1; i<strEnum.Length + 1; i++)
            {
                program.PrintInfoMonth((Months)i);
            }

            Months month1 = Months.December;
            Months month2 = Months.March;

            Console.WriteLine();

            month1.CheckMonth();
            month2.CheckMonth();

            Console.WriteLine();

            Worker<int>.salary = 20000;
            Worker<int> worker1 = new Worker<int>("Mark", 24);
            Worker<int> worker2 = new Worker<int>("Den", 43);
            Worker<int> worker3 = new Worker<int>("Jo", 31);

            Console.WriteLine($"Sum of ages { Worker<int>.SumOfSalary<int>(worker1, worker2, worker3)}");

            Console.ReadLine();
        }
    }
}