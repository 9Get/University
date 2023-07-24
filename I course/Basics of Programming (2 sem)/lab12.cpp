#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

class Employee
{
	char name[15];

protected:
	char surname[20];
	int age;

public:

	Employee() : Employee("NONE", "NONE", 0) {}
	Employee(const char* name) : surname("NONE"), age(0) {}
	Employee(const char* name, const char* surname): age(0)
	{
		strcpy(this->name, name);
		strcpy(this->surname, surname);
	}
	Employee(const char* name, const char* surname, int age) : age(age)
	{
		strcpy(this->name, name);
		strcpy(this->surname, surname);
	}

	virtual ~Employee()
	{
		std::cout << "Destructor (Employee)\n";
	}

	int GetAge() {
		return age;
	}

	virtual void Print()const {
		std::cout << "\nSurname of employee: " << surname << "\nHis name: " << name << "\nHis age: " << age;
	}
};
	// virtual void Foo() = 0;

class Engineer : public Employee
{
	int workExperience;

public:
	Engineer() : workExperience(0) {}
	Engineer(int workExperience) : workExperience(workExperience) {}
	Engineer(const char* name, const char* surname) : Employee(name, surname), workExperience(0) {}
	Engineer(const char* name, const char* surname, int workExperience) : Employee(name, surname), workExperience(workExperience) {}
	Engineer(const char* name, const char* surname, int workExperience, int age) : Employee(name, surname, age), workExperience(workExperience) {}
	~Engineer()
	{
		std::cout << "Destructor (Engineer)\n";
	}

	using Employee::Employee;

	void Print()const override {
		Employee::Print();
		std::cout << "\nHis work experience: " << workExperience << std::endl << std::endl;
	}
};

class Handyman final : public Employee
{
	char nameOfSpecialty[20];

public:
	Handyman(const char* name, const char* surname) : Employee(name, surname), nameOfSpecialty("NONE") {}
	Handyman(const char* name, const char* surname, const char* nameOfSpecialty) : Employee(name, surname)
	{
		strcpy(this->nameOfSpecialty, nameOfSpecialty);
	}
	Handyman(const char* name, const char* surname, const char* nameOfSpecialty, int age) : Employee(name, surname, age)
	{
		strcpy(this->nameOfSpecialty, nameOfSpecialty);
	}

	~Handyman()
	{
		std::cout << "Destructor (Handyman)\n";
	}

	using Employee::Employee;

	void Print()const override {
		Employee::Print();
		std::cout << "\nHis specialty: " << nameOfSpecialty << std::endl << std::endl;
	}
};

void Print(const Employee& employee)
{
	employee.Print();
}

void Print(const Employee* employee)
{
	employee->Print();
}

float MiddleAge(Employee* employee[], int countOFEmployees)
{
	float sum = 0;
	for (int i = 0; i < countOFEmployees; i++)
	{
		sum += employee[i]->GetAge();
	}
	return sum / countOFEmployees;
}
int main()
{
	Employee* engineer = new Engineer("Ma", "Long", 3, 29);
	Print(*engineer);
	delete engineer;

	Employee* handyman = new Handyman("Jo", "Destr", "Deliveryman", 25);
	Print(*handyman);
	delete handyman;

	Employee* employees[] = { new Engineer("Nick", "Joster", 12, 45), new Engineer("Max", "Brown", 7, 29), new Handyman("Oleg", "Panchov","Loader", 32) };
	std::cout << "\nMiddle age of employees - " << MiddleAge(employees, 3) << std::endl;

	for (int i = 0; i < 3; i++) {
		delete* (employees + i);
	}
}