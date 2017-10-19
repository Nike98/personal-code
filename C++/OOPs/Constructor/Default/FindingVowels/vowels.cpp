#include <iostream>

using namespace std;

class Vowels
{
public:
    Vowels ()
    {
        char input;

        cout << " Enter a single character : ";
        cin >> input;

        if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u'){
            cout << "\n\n The given input is a Lower case Vowel" << endl;
        }
        else if (input == 'A' || input == 'E' || input == 'I' || input == 'O' || input == 'U'){
            cout << "\n\n The given input is an Upper case Vowel" << endl;
        }
        else{
            cout << "\n\n It is a Consonant" << endl;
        }
    }
};

int main ()
{
    Vowels word;

    return 0;
}
