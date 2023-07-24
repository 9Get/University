//1 Task
#include <iostream>
#include <vector>

using std::cout;
using std::endl;
using std::vector;

class MyException : public std::exception
{
public:
	MyException(const char* mess) : std::exception(mess) {}
};

int main()
{
	int varA = 3, varB = 0, varC = 0, varD = 0;
	vector<int> vec{ 3,12,4 };

	try {
		//throw MyException("Test Exception");
		try {
			if (!varB) throw "ERROR | division by ZERO\n";
			varC = varA / varB;
		}
		catch (int ex) {
			cout << "Int error. " << ex << endl;
		}
		catch (const char* ex) {
			cout << ex;
		}
		catch (...) {
			cout << "Please, check your requests!\n";
			return 0;
		}

		if(!varC) throw "ERROR | division by ZERO\n";
		varD = varB + varA / varC;
	}
	catch (const char* ex) {
		cout << ex;
	}
	catch (MyException& ex) {
		cout << "ERROR | " << ex.what() << endl;
	}
	catch (...) {
		cout << "Please, check your requests!\n";
		return 0;
	}

	try {
		vec.at(3);
		vec.push_back(5);
	}
	catch (std::out_of_range& oorEx) {
		cout << "ERROR | " << oorEx.what() << endl;
	}
	catch (std::bad_alloc& baEx) {
		cout << "ERROR | " << baEx.what() << endl;
	}
}

//2 Task
#include <iostream>
#include <vector>

using std::cout;
using std::cin;
using std::endl;
using std::vector;

int main()
{
	vector<int> vec{1, 5, 3};
	try {
		cout << vec.size() << endl;
		vec.resize(vec.max_size() + 10);

		for (int i = 0; i < 3; i++) {
			vec.push_back(rand() % 6);
		}

		vec.at(3);
	}
	catch (std::out_of_range& orEx) {
		cout << "ERROR | " << orEx.what() << endl;
	}
	catch (std::length_error& leEx) {
		cout << "ERROR | " << leEx.what() << endl;
	}
	catch (std::exception& ex) {
		cout << "ERROR | " << ex.what() << endl;
	}
	catch (...) {
		cout << "ERROR | Please, check your requests!\n";
	}
}