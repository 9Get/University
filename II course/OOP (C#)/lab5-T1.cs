using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace LR_5
{
    abstract partial class ParticipantOfCompetition
    { 
        public ParticipantOfCompetition(string surname, string sex, int numberOfMedals)
        {
            this.surname = surname;
            this.sex = sex;
            this.numberOfMedals = numberOfMedals;
        }
    
    }

    sealed class Example : ParticipantOfCompetition
    {
        public int Field { get; set; }
        
        public Example():this(3)
        {
            this.Field++;
            
        }
        public Example(int field):base("None","None",0)
        {
            this.Field = field;
            
        }
        public Example(string surname, string sex, int numberOfMedals, int field) : base(surname, sex, numberOfMedals)
        {
            this.Field = field;
            
        }
        public override string ToString()
        {
            return $"Surname: {surname}\nSex: {sex}\nNumber of medals: {numberOfMedals}\nExample field: {Field}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //ParticipantOfCompetition participant = new ParticipantOfCompetition("Andreev", "Male", 15);   error, ParticipantOfCompetition is an abstract class
            Example exampleObj = new Example("Kogut", "Female", 23, 15);
            Console.WriteLine(exampleObj.ToString());

            Console.WriteLine();

            char[] str = { 'q', 'w', 'e', 'r', 't', 'y', 'e', '1', '2', '3' };
            String str1 = new String(str);
            Console.WriteLine(str1);
            String str2 = "ABC123";
            Console.WriteLine(str2);
            String str3 = new String('a', 5);
            Console.WriteLine(str3);
            String str4 = new String(str, 0, 5);
            Console.WriteLine(str4);
            String str5 = "qqqqqqqqqqqqqqqqqqq";

            Console.WriteLine();

            str2.Replace('A','D');
            Console.WriteLine(String.Concat(str1, str2));
            Console.WriteLine(str1.LastIndexOf('e'));
            String str7 = str5.ToUpper();
            Console.WriteLine(str7);
            Console.WriteLine(str5);
            str3.Remove(3);

            Console.WriteLine();

            String str6 = "ABC123";
            Console.WriteLine(Object.ReferenceEquals(str2, str6));
            Console.WriteLine(String.IsInterned(str2));

            Console.WriteLine(String.Equals(str2[2], str6[2]));
            Console.WriteLine(Object.Equals(str2[2], str6[2]));
            Console.ReadLine();
       }
    }
}