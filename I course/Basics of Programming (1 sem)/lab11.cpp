#include <iostream>

int main() {
	int N1 = 3, N2 = 7;
	char S1[27] = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	char S2[27] = "abcdefghijklmnopqrstuvwxyz";
	char S3[11] = "";

	for (int i = 0; i < N1; i++) {
		S3[i] = S1[i];
	}

	for (int i = 27 - N2, j = 3; i < 27; i++, j++) {
		S3[j] += S2[i];
	}
	
	for (int i = 0; i < N2 + N1; i++) {
		std::cout << S3[i];
	}
}