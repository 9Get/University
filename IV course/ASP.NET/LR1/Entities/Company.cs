using System;

namespace LR1.Entities
{
	public class Company
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public int BranchesNumber { get; set; }
		public Company()
		{
			Name = string.Empty;
			Address = string.Empty;
			BranchesNumber = 0;
		}
		public Company(string name, string address, int branchesNumber)
		{
			Name = name;
			Address = address;
			BranchesNumber = branchesNumber;
		}
		public override string ToString()
		{
			return $"Name: {Name};\nAddress: {Address};\nNumber of branches: {BranchesNumber}.\n";
		}
	}
}