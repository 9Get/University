#include <iostream>
#include "windows.h"

using namespace std;

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	int a = 0, b = 1;

	cout << "a= " << a << endl;
	cout << "b= " << b << endl;

	cout << "Address of variable а: " << &a << endl;
	cout << "Address of variable b: " << &b << endl;
}
