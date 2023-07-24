#include <iostream>
#include <cmath>

int main() {
	float a, b, c, x;
	std::cin >> a >> b >> c >> x;
	
	if (x + b < 10 && b)
		std::cout << pow(a, 3) * pow(x, 2) - b / c << std::endl;
	else if (x + b > 10 && b == 0)
		std::cout << a + (b - a) / (x - c) << std::endl;
	else
		std::cout << x / pow(c, 3) << std::endl;
}