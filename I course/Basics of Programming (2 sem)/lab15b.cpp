#include <iostream>
#include <vector>
#include <algorithm>

bool Foo(int a, int b) {
	return a > b;
}

struct ForSort {
	bool operator()(int a, int b) {
		return a < b;
	}
};

int main()
{
	std::vector<int> vec1;
	std::vector<int> vec2(3);
	std::vector<int> vec3(3, 230703);
	std::vector<int> vec4{ 2, 3, 0, 7, 0, 3 };
	
	int maxVec4 = vec4.at(0);
	
	for (int i = 0; i < vec4.size(); i++) {
		std::cout << vec4.at(i) << "   ";
	}

	for (auto i : vec4) {
		if (maxVec4 < i) maxVec4 = i;
	}
	std::cout << std::endl << "\nMaximum element of the vector: " << maxVec4 << std::endl;

	int sum = 0;
	std::vector<int>::iterator iterVec4 = vec4.begin();
	while(iterVec4 != vec4.end()){
		sum += *iterVec4++;
	}
	std::cout << "\nSum of all elements of the last vector: " << sum << std::endl;

	std::cout << "\nThe number of occurrences of the number 2: " << count(vec4.begin(), vec4.end(), 2) << std::endl;

	vec4.push_back(9);
	
	std::cout << std::endl;

	copy(vec4.begin(), vec4.end(), std::ostream_iterator<int>(std::cout, "   "));

	std::cout << std::endl;

	sort(vec4.begin(), vec4.end());
	for (auto i : vec4) {
		std::cout << i << "   ";
	}

	std::cout << std::endl;

	sort(vec4.begin(), vec4.end(), Foo);
	for (auto i : vec4) {
		std::cout << i << "   ";
	}

	std::cout << std::endl;
	vec4.at(2) = 9;

	ForSort forSort;
	sort(vec4.begin(), vec4.end(), forSort);
	for (auto i : vec4) {
		std::cout << i << "   ";
	}
}