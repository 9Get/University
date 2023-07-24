#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

class Point
{
	int x;
	int y;
	int z;
	
public:

	Point(int x, int y, int z) : x(x), y(y), z(z)
	{}

	Point operator+(const Point& obj)const {
		return Point(x + obj.x, y + obj.y, z + obj.z);
	}

	Point operator*(const Point& obj)const {
		return Point(x * obj.x, y * obj.y, z * obj.z);
	}

	Point operator+(int var)const {
		return Point(x + var, y + var, z + var);
	}

	Point operator*(int var)const {
		return Point(x * var, y * var, z * var);
	}

	Point& operator=(const Point& obj) {
		if (this == &obj) return *this;
		x = obj.x;
		y = obj.y;
		z = obj.z;
		return *this;
	}

	Point operator++ (int i) {
		Point temp(x, y, z);
		x++;
		y++;
		z++;
		return temp;
	}

	Point& operator++ () {
		x++;
		y++;
		z++;
		return *this;
	}

	bool operator==(int compare)const {
		return(y == compare);
	}

	bool operator>(const int compare)const {
		return(y > compare);
	}

	int GetX() {
		return x;
	}

	int GetY() {
		return y;
	}

	int GetZ() {
		return z;
	}

	friend Point operator+ (int i, const Point& obj);

	void Print() {
		std::cout << "X: " << x << "\tY: " << y << "\tZ: " << z << std::endl << std::endl;
	}
};

Point operator+ (int i, const Point& obj) {
	return Point(i + obj.x, i + obj.y, i + obj.z);
}


int main()
{
	Point pointA(2, 3, 7);
	Point pointB(2, -4, 3);
	Point pointC(5, 0, 1);

	Point pointSum(0,0,0);
	Point pointMultiplication(0, 0, 0);
	
	
	std::cout << "\tSum:\n";
	pointSum = pointA + pointB;
	pointSum.Print();
	std::cout << "\tMultiplication:\n";
	pointMultiplication = pointB * pointC;
	pointMultiplication.Print();
	std::cout << "\tSum (point and variable):\n";
	pointSum = pointA + 5;
	pointSum.Print();
	std::cout << "\tSum (variable and point):\n";
	pointSum = 2 + pointA;
	pointSum.Print();
	std::cout << "\tMultiplication (point and variable):\n";
	pointMultiplication = pointB * 2;
	pointMultiplication.Print();
	std::cout << "\tPrefix increment:\n";
	++pointA;
	pointA.Print();
	std::cout << "\tPostfix increment:\n";
	pointB++;
	pointB.Print();

	
Point pointArray[3] = { {2, 4, 1}, {0, 1, 3}, {5, -2, 1} };
	int maxAxisY = pointArray[0].GetY();
	Point pointArraySum(0, 0, 0);
	for (int i = 0; i < 3; i++) {
		pointArraySum = pointArraySum + pointArray[i];
		if (pointArray[i] > maxAxisY) maxAxisY = pointArray[i].GetY();
	}

	std::cout << "Max Y: " << maxAxisY << std::endl;
	std::cout << "Medium X: " << pointArraySum.GetX() / 3 << std::endl;
	std::cout << "Medium Y: " << pointArraySum.GetY() / 3 << std::endl;
	std::cout << "Medium Z: " << pointArraySum.GetZ() / 3 << std::endl;

	
int findZ = 3;
	for (int i = 0; i < 3; i++) {
		if (pointArray[i] == findZ) {
			std::cout << "Point has been found" << std::endl;
			pointArray[i].Print();
		}
	}
}