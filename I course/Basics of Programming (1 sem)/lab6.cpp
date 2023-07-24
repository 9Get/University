#include <iostream>
#include <cmath>

int main() {
	double x = 1;
	while (x <= 2) {
		std::cout << x << "\t" << sin(pow(x, 1 / 2)) + exp(2) - 3 << std::endl;
		x += 0.1;
	}
}