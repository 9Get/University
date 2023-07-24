using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_2
{
	struct StructForExample //: StructParticipantOfCompetition
	{ }

	struct StructParticipantOfCompetition
	{
		string surname;
		string sex;
		int numberOfMedals;

		public StructParticipantOfCompetition(string surname)
		{
			this.surname = surname;
			this.sex = "None";
			this.numberOfMedals = 0;
		}

		public StructParticipantOfCompetition(string surname, string sex)
		{
			this.surname = surname;
			this.sex = sex;
			this.numberOfMedals = 0;
		}

		public StructParticipantOfCompetition(string surname, string sex, int numberOfMedals)
		{
			this.surname = surname;
			this.sex = sex;
			this.numberOfMedals = numberOfMedals;
		}

		public override string ToString()
		{
			return $"\tSurname: {surname.ToString()}\n\tSex: {sex.ToString()}\n\tNumber of medals: {numberOfMedals.ToString()}";
		}
	}

	class ParticipantOfCompetition //: StructParticipantOfCompetition
	{
		/*internal*/
		string surname;
		public string sex;
		int numberOfMedals;

		public ParticipantOfCompetition(string surname, string sex, int numberOfMedals)
		{
			this.surname = surname;
			this.sex = sex;
			this.numberOfMedals = numberOfMedals;
		}
		public override bool Equals(object obj)
		{
			if ((obj == null) || !this.GetType().Equals(obj.GetType()))
			{
				return false;
			}
			else
			{
				ParticipantOfCompetition particip = (ParticipantOfCompetition)obj;
				return (sex == particip.sex) && (numberOfMedals == particip.numberOfMedals);
			}
		}

		public override string ToString()
		{
			return $"\tSurname: {surname.ToString()}\n\tSex: {sex.ToString()}\n\tNumber of medals: {numberOfMedals.ToString()}";
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random();

			int[] arr1;
			int[] arr2 = { 1, 3, 7, 4 };

			Console.WriteLine(arr2.Sum());
			Console.WriteLine(arr2.Length);


			int[,] arr3;

			int n = rand.Next(1, 5);
			int m = rand.Next(1, 5);
			int count = 1;
			int product = 1;
			int[,] arr4 = new int[n, m];

			int rows = arr4.GetLength(0);
			int columns = arr4.Length / rows;

			Console.WriteLine($"Array has {rows} rows and {columns} columns.");

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					arr4[i, j] = rand.Next(1, 10);
				}
			}

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					if (i % 2 == 0) count *= arr4[i, j];
				}
			}

			Console.WriteLine($"\n{count}");

			int[][] jagged = { new[] { 1, 2, 3 }, new[] { 7, 8, 9 } };

			for (int i = 0; i < jagged.Length; i++)
			{
				for (int j = 0; j < jagged[i].Length; j++)
				{
					if (i % 2 == 0) product *= jagged[i][j];
				}
			}

			Console.WriteLine($"{product}");

			int number;
			int countOfNumbers = 0;

			Console.WriteLine("Enter number.");
			number = Convert.ToInt32(Console.ReadLine());

			foreach (var item in arr2)
			{
				if (item == number) countOfNumbers++;
			}
			Console.WriteLine($"Count of numbers found {countOfNumbers}.\n");

			Console.WriteLine("Enter number for two dimensional array.");
			number = Convert.ToInt32(Console.ReadLine());

			countOfNumbers = 0;
			foreach (var item in arr4)
			{
				if (item == number) countOfNumbers++;
			}
			Console.WriteLine($"Count of numbers found {countOfNumbers}.\n");

			Console.WriteLine("Enter number for stepped array.");
			number = Convert.ToInt32(Console.ReadLine());

			countOfNumbers = 0;
			foreach (var item in jagged)
			{
				foreach (var temp in item)
				{
					if (temp == number) countOfNumbers++;
				}
			}
			Console.WriteLine($"Count of numbers found {countOfNumbers}.\n\n");

			ParticipantOfCompetition participant1 = new ParticipantOfCompetition("Фролов", "Male", 23);
			ParticipantOfCompetition participant2 = new ParticipantOfCompetition("Екимов", "Male", 17);
			Console.WriteLine(participant2.ToString());

			if (participant2.Equals(participant1)) Console.WriteLine("YES");
			else Console.WriteLine("NO");

			if (participant2.Equals(participant1)) Console.WriteLine("Identical personalities");
			else Console.WriteLine("Different personalities");

			Console.WriteLine("\n");
			StructParticipantOfCompetition structParticipant1 = new StructParticipantOfCompetition();
			StructParticipantOfCompetition structParticipant2 = new StructParticipantOfCompetition("Кудряшов");
			StructParticipantOfCompetition structParticipant3 = new StructParticipantOfCompetition("Калугина", "Female");
			StructParticipantOfCompetition structParticipant4 = new StructParticipantOfCompetition("Шмелева", "Female", 17);
			StructParticipantOfCompetition structParticipant5 = new StructParticipantOfCompetition("Шмелева", "Female", 17);

			if (structParticipant4.Equals(structParticipant5)) Console.WriteLine("Identical personalities");
			else Console.WriteLine("Different personalities");

			structParticipant3.ToString();

			Console.ReadKey();
		}
	}
}