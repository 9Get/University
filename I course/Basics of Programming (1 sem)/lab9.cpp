#include <iostream>

int* arrayInitializator(int size) {
	int* array = new int[size];

	for (int i = 0; i < size; i++) {
		array[i] = rand();
	}

	return array;
}

int* arrayIterator(int* array, int size, int P) {
	int* newArray = new int[size];
	int index = 0;
	for (int i = 0; i < size; i++) {
		if(array[i] > P){
			newArray[index] = array[i];
			index++;
		}
	}

	return newArray;
}

int positiveElementsCounter(int* array, int size) {
	int count = 0;
	for (int i = 0; i < size; i++) {
		if (array[i] > 0) {
			count++;
		}
	}
    
	return count;
}

int main() {
	int P, size = 10;
	std::cin >> P;

	int* array = arrayInitializator(size);
	int* newArray = arrayIterator(array, size, P);

	std::cout << std::endl;
	std::cout << positiveElementsCounter(newArray, size);

	delete[] array;
}