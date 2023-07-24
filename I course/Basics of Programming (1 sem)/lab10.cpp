#define N 4
#define M 6

#include <iostream>

int arrayMinFinder(int (*array)[M]) {
	int min = array[0][0];
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < M; j++) {
			if (min > array[i][j])
				min = array[i][j];
		}
	}

	return min;
}

int arrayMaxFinder(int(*array)[M]) {
	int max = array[0][0];
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < M; j++) {
			if (max < array[i][j])
				max = array[i][j];
		}
	}

	return max;
}

int* indexOfElementArrayFinder(int(*array)[M], int element) {
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < M; j++) {
			if (array[i][j] == element) {
				return new int [2]{i, j};
			}
		}
	}

	return NULL;
}

void arrayInitialization(int(*array)[M]) {
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < M; j++) {
			array[i][j] = rand() % 10 + 1;
		}
	}
}

int main() {
	int array[N][M];
	arrayInitialization(array);

	int min = arrayMinFinder(array);
	int max = arrayMaxFinder(array);

	int* indices;
	indices = indexOfElementArrayFinder(array, min);
	std::cout << min << " - (" << indices[0] << "; " << indices[1] << ")" << std::endl;

	indices = indexOfElementArrayFinder(array, max);
	std::cout << max << " - (" << indices[0] << "; " << indices[1] << ")" << std::endl;
}