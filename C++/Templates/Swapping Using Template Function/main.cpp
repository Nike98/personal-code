///
/**
 *      WAP to implement function template for swapping
 *      of 2 integers and floating point numbers.
 */
///

#include<iostream>

template<class T>
void swap(T&i, T&j)
{
    T temp;
    temp = i;
    i = j;
    j = temp;
}

int main()
{
    int i, j;
    float a, b;

    std::cout << " INTEGER VALUES...\n";
    std::cout << " Enter the 1st Integer Value : ";
    std::cin >> i;
    std::cout << " Enter the 2nd Integer Value : ";
    std::cin >> j;

    std::cout << "\n\n FLOAT VALUES...\n";
    std::cout << " Enter the 1st value : ";
    std::cin >> a;
    std::cout << " Enter the 2nd value : ";
    std::cin >> b;

    swap(i, j);
    std::cout << "\n\n INTEGER VALUES AFTER SWAPPING...\n";
    std::cout << " 1st value : " << i << "\n";
    std::cout << " 2nd value : " << j;

    swap(a, b);
    std::cout << "\n\n FLOAT VALUES AFTER SWAPPING...\n";
    std::cout << " 1st value : " << a << "\n";
    std::cout << " 2nd value : " << b;

    return 0;
}
