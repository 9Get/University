using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class ParticipantOfCompetition
	{
		protected string surname;
		protected string sex;
		protected int numberOfMedals;

		int[] id = new int[3];

		public int this[int i]
		{
			get => id[i];
			set => id[i] = value;
		}

		public void SetSurname(string surname)
		{
			this.surname = surname;
		}

		public string GetSurname()
		{
			return surname;
		}

		public void SetSex(string sex) => this.sex = sex;
		public string GetSex() => sex;

		public int NumberOfMedals
		{
			set { numberOfMedals = value; }
			get { return numberOfMedals; }
		}

		public int Age { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			ParticipantOfCompetition participant1 = new ParticipantOfCompetition();
			participant1.SetSurname("Алексеев");
			participant1.SetSex("Male");
			participant1.NumberOfMedals = 23;
			participant1.Age = 27;

			Console.WriteLine($"Surname: {participant1.GetSurname()},\nSex: {participant1.GetSex()},\nNumber of medals: {participant1.NumberOfMedals},\nAge: {participant1.Age}.");

			ParticipantOfCompetition participantIDArray = new ParticipantOfCompetition();

			participantIDArray[0] = 1001;
			participantIDArray[1] = 1002;
			participantIDArray[2] = 1003;

			Console.ReadLine();
		}
	}
}