using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    class ParticipantOfCompetition
    {
        protected string surname;
        protected string sex;
        protected int numberOfMedals;
        public static int count;

        public readonly int var = 1;

        static ParticipantOfCompetition() => count = 1;
        public ParticipantOfCompetition(string surname, string sex, int numberOfMedals)
        {
            this.surname = surname;
            this.sex = sex;
            this.numberOfMedals = numberOfMedals;
            count++;
        }

        public int NumberOfMedals
        {
            set => numberOfMedals = value;
            get => numberOfMedals;
        }

        static public double CoefficientOfMedals(int numberOfMedals)
        {
            const double COEFFICIENT = 0.2;
            return numberOfMedals * COEFFICIENT;
        }

        static public double VariableCoefficientOfMedals(int numberOfMedals, int var)
        {
            const double COEFFICIENT = 0.2;
            return numberOfMedals * COEFFICIENT * var;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ParticipantOfCompetition participant1 = new ParticipantOfCompetition("Алексеев", "Male", 23);
            int[] array = { 1, 5, 7, -1, 13, 0, -4, 6, 2 };
            Array.Sort(array);
            foreach(var element in array)
            {
                Console.Write($"{element}  ");
            }

            Console.WriteLine();

            Array.Reverse(array);
            foreach (var element in array)
            {
                Console.Write($"{element}  ");
            }

            Console.WriteLine();

            Array.Resize(ref array, 5);
            foreach (var element in array)
            {
                Console.Write($"{element}  ");
            }

            Console.WriteLine($"\nCoefficient of medals {ParticipantOfCompetition.CoefficientOfMedals(participant1.NumberOfMedals)}");

            int exVar = 4;
            Console.WriteLine($"{ParticipantOfCompetition.VariableCoefficientOfMedals(participant1.NumberOfMedals, exVar)}");

            Console.WriteLine(ParticipantOfCompetition.count);

            Console.ReadLine();
        }
    }
}