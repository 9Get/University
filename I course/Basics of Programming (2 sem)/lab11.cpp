#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

class Employee
{
	char name[15];

protected:	
	char surname[20];

public:

	Employee() : Employee("NONE","NONE")
	{
		std::cout << "Constructor (Employee)\n";
	}

	Employee(const char* name) : surname("NONE")
	{
		strcpy(this->name, name);
		std::cout << "Constructor (Employee)\n";
	}

	Employee(const char* name, const char* surname)
	{
		strcpy(this->name, name);
		strcpy(this->surname, surname);
		std::cout << "Constructor (Employee)\n";
	}

	Employee(const Employee& employee) {
		strcpy(this->name, employee.name);
		strcpy(this->surname, employee.surname);
		std::cout << "Copy constructor\n";
	}

	~Employee()
	{
		std::cout << "Destructor (Employee)\n";
	}

	void Print() {
		std::cout << "\nSurname of employee: " << surname << "\nHis name: " << name ;
	}
};

class Engineer : public Employee
{
	int workExperience;

public:
	Engineer() : workExperience(0)
	{
		std::cout << "Constructor (Engineer)\n";
	}

	Engineer(int workExperience) : workExperience(workExperience)
	{
		std::cout << "Constructor (Engineer)\n";
	}

	Engineer(const char* name, const char* surname) : Employee(name, surname), workExperience(0)
	{
		std::cout << "Constructor (Engineer)\n";
	}

	Engineer(const char* name, const char* surname, int workExperience) : Employee(name, surname), workExperience(workExperience)
	{
		std::cout << "Constructor (Engineer)\n";
	}

	Engineer(const Engineer& engineer) : Employee(engineer), workExperience(engineer.workExperience)
	{
		std::cout << "Copy constructor\n";
	}

	~Engineer() 
	{
		std::cout << "Destructor (Engineer)\n";
	}

	using Employee::Employee;

	void Print() {
		Employee::Print();
		std::cout << "\nHis work experience: " << workExperience << std::endl << std::endl;
	}
};

int main()
{
	Engineer engineer1("Mao", "Long", 20);
	engineer1.Print();

	Engineer engineer2("March", "Alex");
	engineer2.Print();

	Engineer engineer3(engineer1);
	engineer3.Print();
}