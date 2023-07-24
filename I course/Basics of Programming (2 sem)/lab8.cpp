#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

class Student
{
	char name[20];
	int age;
	static int amountOfStudents;
	const int ID = 0;

public:

	Student(const char* name, int age, int id) : age(age), ID(id)
	{
		strcpy(this->name, name);
		amountOfStudents++;
	}

	static void PrintAmountOfStudents() {
		std::cout << "Amount of students: " << amountOfStudents << std::endl;
	}

	void PrintInfo()const {
		std::cout << "Name of student: " << name << "\t\tAge: " << age << "\t\tID: " << ID << std::endl << std::endl;
	}
};

int Student::amountOfStudents = 0;

int main()
{
	Student::PrintAmountOfStudents();
	Student student1("Dave", 21, 2413978);
	student1.PrintInfo();
	Student::PrintAmountOfStudents();
	Student student2("Nick", 20, 2413979);
	Student student3("Jo", 20, 2413980);
	student2.PrintInfo();
	student3.PrintInfo();
	Student::PrintAmountOfStudents();
}