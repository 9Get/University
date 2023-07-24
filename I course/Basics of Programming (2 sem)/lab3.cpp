#include <iostream>

int main()
{
    //1.1
    int* pointerA = new int;

    //1.2
    std::cout << "\t1.2\n" << *pointerA << std::endl << std::endl;

    //1.3
    *pointerA = 7;

    //1.4
    std::cout << "\t1.4\n" << *pointerA << std::endl << std::endl;

    //1.5
    delete pointerA;

    //1.6
    int* pointerMem = new int[3];

    //1.7
    std::cout << "\t1.7\n" << pointerMem[2] << std::endl << std::endl;

    //1.8
    pointerMem[0] = 2;
    pointerMem[1] = 10;
    pointerMem[2] = 15;

    //1.9
    std::cout << "\t1.8\n" << pointerMem[0] << std::endl;
    std::cout << pointerMem[1] << std::endl;
    std::cout << pointerMem[2] << std::endl << std::endl;

    //1.10
    delete[]pointerMem;

    //2.
    int* ptrMemLeak = new int;
    *ptrMemLeak = 10;
    int varA = 11;
    ptrMemLeak = &varA;

    //3.
    int* ptr = new int[3];
    ptr[1] = 10;
    delete ptr;
}
