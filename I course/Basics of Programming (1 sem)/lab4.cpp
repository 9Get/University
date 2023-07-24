#define _USE_MATH_DEFINES

#include <iostream>
#include <cmath>

int main() {
	double m;
	std::cin >> m;
	std::cout << (int)(m / 1000);

	std::cout << "\n==========\n";

	double a, b, x, y, z;
	std::cin >> x >> y >> z;
	a = abs(pow(x, y / x) - cbrt(y / x)) + sqrt(x) - (pow(y, 2) - 8 * x) / exp(3);
	b = y * pow(tan(x), 2) - (z + cos(130 * M_PI / 180)) / (pow(sin(x / y), 2));
	std::cout << a << '\n' << b;
}