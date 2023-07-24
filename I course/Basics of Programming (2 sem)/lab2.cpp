#include <iostream>

void function1(float a, float b, float c)
{
	std::cout << a / c << "\t" << b / c << std::endl;
	std::cout << "\nA= " << a << "\nB= " << b << std::endl;
}

void function2(float* a, float* b, float c)
{
	*a /= c;
	*b /= c;
	std::cout << "\nA= " << *a << "\nB= " << *b << std::endl;
}

void function3(float& a, float& b, float c)
{
	a /= c;
	b /= c;
	std::cout << "\nA= " << a << "\nB= " << b << std::endl;
}

int main()
{
	float variableA = 4, variableB = 6, variableC = 2;
	
	std::cout << "Function 1" << std::endl;
	function1(variableA, variableB, variableC);

	std::cout << "\nFunction 2" << std::endl;
	function2(&variableA, &variableB, variableC);

	std::cout << "\nFunction 3" << std::endl;
	function3(variableA, variableB, variableC);
}
