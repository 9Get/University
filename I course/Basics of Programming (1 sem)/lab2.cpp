#include <iostream>
#include <cmath>

int main() {
	float a = 0, b = 0, S = 0, P = 0;

	std::cout << "Cathetus: ";
	std::cin >> a;

	S = 0.5 * pow(a, 2) * tan(a);
	b = 2 * S / a;
	P = b + 2 * S / b + sqrt(pow(4 * S, 2) / pow(b, 2) + pow(b, 2));
	std::cout << "S: " << S << "\nP: " << P;
}