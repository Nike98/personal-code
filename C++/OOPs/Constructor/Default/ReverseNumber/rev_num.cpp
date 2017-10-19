#include<iostream>

using namespace std;

class Reverse
{
private:
    int num, rev_num = 0, rem;
public:
    Reverse()
    {
        cout << " Enter the Number : ";
        cin >> num;

        while (num != 0){
            rem = num % 10;
            rev_num = rev_num * 10 + rem;
            num /= 10;
        }

        cout << "\n\n The Reversed Number = " << rev_num << endl;
    }
};

int main ()
{
    Reverse number;

    return 0;
}
