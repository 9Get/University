#define _USE_MATH_DEFINES

#include <iostream>
#include <cmath>

float calculateFirstFormula(float x, float y, float z) {
	return abs(pow(x, y / x) - cbrt(y / x)) + sqrt(x) - (pow(y, 2) - 8 * x) / exp(3);
}

float calculateSecondFormula(float x, float y, float z) {
	return y * pow(tan(x), 2) - (z + cos(130 * M_PI / 180)) / (pow(sin(x / y), 2));
}

float calculateSqrt(int a, float b) {
	return sqrt(a + b);
}

int main() {
	double a, b, x, y, z;
	std::cin >> x >> y >> z;
	a = (int)calculateFirstFormula(x, y, z);
	b = calculateSecondFormula(x, y, z);
	std::cout << calculateSqrt(a, b);
}