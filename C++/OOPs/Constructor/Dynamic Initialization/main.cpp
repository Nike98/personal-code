#include<iostream>

using namespace std;

class Demo
{
public:
    Demo(int size)
    {
        int arr[size];

        cout << "\n Enter the " << size << " elements of the Array ..." << endl;
        for (int i = 0; i < size; i++)
            cin >> arr[i];

        cout << "\n\n The Entered Array is ..." << endl;
        for (int i = 0; i < size; i++)
            cout << " " << arr[i] << endl;
    }
};

int main()
{
    int size;
    cout << " Enter the Size of the Array: ";
    cin >> size;
    Demo obj(size);
    return 0;
}
