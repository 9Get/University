#include <iostream>
#include <cstring>

class Factory
{
    std::string surnameOfEngineer[3];
    int size = 0;

public:
    void AddingArrayElements(std::string str) {
        if (size < 3) {
            surnameOfEngineer[size] += str;
            std::cout << surnameOfEngineer[size++] << std::endl;
        }
        else {
            std::cout << "Error (247)" << std::endl;
        }
    }

    void FindingAndOutput() {
        std::string temp;
        std::cin >> temp;
        for (int i = 0; i < size; i++) {
            if (surnameOfEngineer[i].find(temp) != std::string::npos){
                std::cout << surnameOfEngineer[i] << std::endl;
            }
        }
    }

    void FindingAndOutputSubstring(std::string substr) {
        for (int i = 0; i < size; i++) {
            if (surnameOfEngineer[i] == substr) std::cout << surnameOfEngineer[i] << std::endl;
        }
    }

    void ReplaceArrayElements(int element)
    {
        std::cout << surnameOfEngineer[element].replace(2,6, "qwerty") << std::endl;
    }

    void ReturnSubtring(int element) {
        std::cout << surnameOfEngineer[element].substr(3, 5) << std::endl;
    }

    void ConversionStringToC(int element) {
        printf("%s",surnameOfEngineer[element].c_str());
    }
};

int main()
{
    Factory factory1;
    factory1.AddingArrayElements("Ramirez");
    factory1.AddingArrayElements("Bryant");
    factory1.AddingArrayElements("Thompson");
    factory1.AddingArrayElements("Niko");

    std::cout << std::endl;

    factory1.FindingAndOutput();

    std::cout << std::endl;

    factory1.FindingAndOutputSubstring("Bryant");

    std::cout << std::endl;

    factory1.ReplaceArrayElements(1);

    std::cout << std::endl;

    factory1.ReturnSubtring(1);

    std::cout << std::endl;

    factory1.ConversionStringToC(2);
}