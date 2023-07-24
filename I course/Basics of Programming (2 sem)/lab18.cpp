#include <iostream>

using std::cout;
using std::endl;
using std::cin;

class Engineer
{
	std::string nameEng;
	int age;

public:
	Engineer():nameEng("None"), age(0) {}
	Engineer(std::string name, int age): nameEng(name), age(age) {}

	friend std::ostream& operator<<(std::ostream& out, const Engineer& eng);
	friend std::istream& operator>>(std::istream& input, Engineer& eng);
};

std::ostream& operator<<(std::ostream& out, const Engineer& eng) {
	return out << "Name: " << eng.nameEng << ", age: " << eng.age << "\n";
}

std::istream& operator>>(std::istream& in, Engineer& eng) {
	return cin >> eng.nameEng >> eng.age;
}

int main()
{
	Engineer eng1("Mark", 28);
	cout << eng1;

	Engineer eng2;
	cin >> eng2;
	cout << eng2;
}