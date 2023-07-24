#include <iostream>
#define _CRT_SECURE_NO_WARNINGS

template <class T1, class T2>
class Engineer     // №1
{
	T1 workExperience;
	T2 salary;

public:
	Engineer() : workExperience(0), salary(0) {}
	Engineer(T1 workExperience, T2 salary) : workExperience(workExperience), salary(salary) {}

	void Print()const
	{
		std::cout << "Work experience: " << workExperience << "\tSalary: " << salary << std::endl;
	}

	T1 GetWorkExperience();
};

template<class T1, class T2>
T1 Engineer<T1, T2>::GetWorkExperience() {
	return workExperience;
}

template<class T>                    // №2
T MaxValue(T a, T b) {
	return a > b ? a : b;
}

template<class T1, class T2>         // №3
T1 FuncSum(T2 a, T2 b) {
	return a + b;
}

template<class T, int sizeI, int sizeJ>             // №4
void FuncPrintArray(T array[][sizeJ]) {
	for (int i = 0; i < sizeI; i++) {
		for (int j = 0; j < sizeJ; j++) {
			std::cout << array[i][j] << "  ";
		}
	}
}

template<int T2, class T1 = int>                // №5
class ExampleArray
{
	T1 array[T2];

public:
	ExampleArray() {
		for (int i = 0; i < T2; i++) {
			array[i] = rand() % 5+1;
		}
	}

	void PrintArray()const {
		for (int i = 0; i < T2; i++) {
			std::cout << array[i] << "  ";
		}
	}
};

template<class T1, class T2>			// №6
class Point
{
	T1 x;
	T2 y;

public:
	Point(T1 x, T2 y) : x(x), y(y) {}
	
	T1 Multiply();
};

template<class T1, class T2>
T1 Point<T1, T2>::Multiply()
{
	std::cout << "no string x*y" << std::endl;
	return x * y;
}

template<class T>
class Point <T, std::string>
{
	T x;
	std::string y;

public:
	Point(T x, std::string y) : x(x), y(y) {}

	std::string Multiply();
};

template<class T>
std::string Point<T, std::string>::Multiply() {
	std::cout << "string x+y= ";
	return x + y;
}

int main()
{
	Engineer<int, int> engineer1(3, 15000);
	Engineer<float, double> engineer2(4.5f, 15000.50);			// №1
	engineer1.Print();
	engineer2.Print();

	std::cout << std::endl;
	
	std::cout << MaxValue(2, 5) << std::endl;					
	std::cout << MaxValue(4.3f, 1.2f) << std::endl;				// №2
	std::cout << MaxValue(10.3, 5.7) << std::endl;
	std::cout << MaxValue(4, 12) << std::endl;

	std::cout << std::endl;

	std::cout << FuncSum<int>(2, 5) << std::endl;					// №3
	std::cout << FuncSum<int, float>(4, 7.4f) << std::endl;
	
	std::cout << std::endl;

	float array[][3] = { {1,2,3}, {4,5,6}, {7,8,9} };				// №4
	FuncPrintArray<float, 3, 3>(array);

	std::cout << std::endl;

	ExampleArray<4, int> exampleArray;				// №5
	exampleArray.PrintArray();

	std::cout << std::endl;

	Point<int, int> point1(3, 5);				// №6
	Point<std::string, std::string> point2("abc", "def");
	
	point1.Multiply();
	point2.Multiply();
}