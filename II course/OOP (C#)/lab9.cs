using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr9
{
    class MyExeption : Exception
    {
        public int ErrorCode { get; }

        public MyExeption(string msg, int errorCode) : base(msg)
        {
            ErrorCode = errorCode;
        }
        
    }
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================Task 1-3=========================");
            int varA = 3, varB = 0;
            int[] array = { 1, 2, 3, 4, 5 };
            try
            {
                try
                {
                    varA /= varB;
                }
                catch (DivideByZeroException dbzExeption) 
                { 
                    Console.WriteLine(dbzExeption);
                    throw new OutOfMemoryException();
                }
                array[5] = 1;
            }
            catch(OutOfMemoryException oomExeption)
            {
                Console.WriteLine(oomExeption.StackTrace);
            }
            catch 
            {
                Console.WriteLine("Catch without parameters");
            }

            Console.WriteLine("===========================Task 4-6=========================");
            int varC = 0;

            try
            {
                varC = varA / varB;
            }
            catch(DivideByZeroException) when (varA == 0)
            {
                Console.WriteLine("varC = 0");
            }
            catch(DivideByZeroException dbzExeption)
            {
                Console.WriteLine(dbzExeption);
            }
            try
            {
                throw new MyExeption("Example exeption", 1);
            }
            catch(MyExeption myExeption)
            {
                Console.WriteLine($"{myExeption.Message + myExeption.ErrorCode}");
            }

            finally
            {
                Console.WriteLine("\nfinally worked");
            }

            Console.WriteLine("===========================Task 7=========================");
            
            int[] numbers = null;

            try
            {
                numbers[0] = 1;
            }
            catch (NullReferenceException nrExeption)
            {
                Console.WriteLine(nrExeption);
            }

            try
            {
                string strEmpty = null;
                int num = int.Parse(strEmpty);
            }
            catch(ArgumentException aExeption)
            {
                Console.WriteLine(aExeption);
            }

            try
            {
                List<int> list = new List<int>() { 1, 2, 3 };
                list.Add(5);
            }
            catch (InvalidOperationException ioexaption)
            {
                Console.WriteLine(ioexaption);
            }

            Console.ReadLine();
        }
    }
}