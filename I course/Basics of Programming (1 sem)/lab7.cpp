#include <iostream>
#include <cmath>

int main() {
	float x;
	std::cin >> x;
	for (int i = 1; i < 6; i++) {
		std::cout << x << '\t' << 2 * log(i * x) + pow(x, 5);
	}
	std::cout << std::endl;
	for (int k = 1; k < 6; k++) {
		std::cout << x << '\t' << sin(k * x) + 2;
	}
}