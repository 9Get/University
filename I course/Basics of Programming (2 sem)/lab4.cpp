#include <iostream>
// 1 Task
int FuncSumArray(int array[][8], int SIZE, int sum)
{
	for (int i = 0; i < SIZE; i++) {
		for (int j = 0; j < SIZE; j++) {
			if (i >= j && i + j <= SIZE + 1) {
				sum += array[i][j];
			}
		}
	}

	return sum;
}
void PrintArray(int array[][8], int SIZE){
    for(int i = 0; i < SIZE; i++){
        for(int j = 0; j < SIZE; j++){
            std::cout << array[i][j] << " ";
        }
        std::cout << std::endl;
    }
}
int main()
{
	int const SIZE = 8;
	int array[SIZE][SIZE];
	int sum = 0;

	for (int i = 0; i < SIZE; i++) {
		for (int j = 0; j < SIZE; j++) {
			array[i][j] = rand() % 10;
		}
	}

	std::cout << FuncSumArray(array, SIZE, sum) << std::endl;
    PrintArray(array, SIZE);
}

//2 Task
#include <iostream>

int main()
{
	int const M = 3, N = 3;
	int matrixA[M][N];
	int matrixB[M][N];
	int matrixC[M][N];

	for (int i = 0; i < M; i++) {
		for (int j = 0; j < N; j++) {
			std::cin >> matrixA[i][j];
		}
	}

	std::cout << std::endl;

	for (int i = 0; i < M; i++) {
		for (int j = 0; j < N; j++) {
			std::cin >> matrixB[i][j];
		}
	}

	std::cout << std::endl;

	for (int i = 0; i < M; i++) {
		for (int j = 0; j < N; j++) {
			matrixC[i][j] = matrixA[i][j] + matrixB[i][j];
			std::cout << matrixC[i][j];
		}
        std::cout << std::endl;
	}
}
