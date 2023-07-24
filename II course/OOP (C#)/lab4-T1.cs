using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    struct MyStruct
    {
        int field1;
        int field2;

        public MyStruct(int field1, int field2)
        {
            this.field1 = field1;
            this.field2 = field2;
        }

        public int Field1
        {
            set => field1 = value;
            get => field1;
        }

        public int Field2
        {
            set => field2 = value;
            get => field2;
        }

        public override string ToString()
        {
            return $"field1: {field1},  field2: {field2}";
        }
    }
    class ParticipantOfCompetition
    {
        protected string surname;
        protected string sex;
        protected int numberOfMedals;

        public int Func1(int []arr) 
        {
            return arr[0] = 0;
        }

        public void Func2(MyStruct myStruct)
        {
            myStruct.Field1 = 23;
            myStruct.Field2 = 14;
        }

        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void Func3(out int varA)
        {
            varA = 19;
        }

        public void Func4(params int[] a)
        {
            foreach(var element in a)
            {
                Console.WriteLine($"i: {element}");
            }
        }

        public int Func5(int x, int y, int z = 6)
        {
            return x * y * z;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ParticipantOfCompetition participant1 = new ParticipantOfCompetition();
            int[] arr = { 1, 2, 3 };
            Console.WriteLine($"[0]arr: { participant1.Func1(arr)}");
            MyStruct myStruct = new MyStruct(12,12);

            participant1.Func2(myStruct);
            Console.WriteLine(myStruct.ToString());

            int varA = 5, varB = 7;
            participant1.Swap(ref varA, ref varB);
            Console.WriteLine($"varA: {varA},   varB: {varB}");

            int varC;
            participant1.Func3(out varC);
            Console.WriteLine($"varC: {varC}");

            participant1.Func4(1, 5, 32, 7);
            Console.WriteLine(participant1.Func5(y: 3, x: 2)); 



            Console.ReadKey();
        }
    }
}