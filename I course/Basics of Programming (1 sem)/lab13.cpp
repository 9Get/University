#include <iostream>
#include <fstream>
#include <string>
#include <cctype>
#include <cmath>

int main() {
    std::ifstream inputFile("fileA.txt");
    std::ofstream outputFile("fileB.txt");

    if (!inputFile) {
        std::cout << "Failed to open file" << std::endl;
        return 1;
    }

    if (!outputFile) {
        std::cout << "Failed to create or open file" << std::endl;
        return 1;
    }

    std::string line;
    while (std::getline(inputFile, line)) {
        std::string punctuations;
        for (char c : line) {
            if (std::ispunct(abs(c))) {
                punctuations += c;
            }
        }
        if (!punctuations.empty()) {
            outputFile << punctuations << std::endl;
        }
    }

    inputFile.close();
    outputFile.close();

    std::cout << "File created successfully file_B.txt" << std::endl;

    return 0;
}