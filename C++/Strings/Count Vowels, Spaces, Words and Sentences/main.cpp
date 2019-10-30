#include<iostream>
#include<string.h>

using namespace std;

int main()
{
    string str;
    int vowels = 0, spaces = 0, words = 1, sentences = 0;

    cout << " Enter the String : ";
    getline(cin, str);

    for (int i = 0; i < str.length(); i++){
        if (str[i] == 'a' || str[i] == 'A' || str[i] == 'e' || str[i] == 'E' ||
            str[i] == 'i' || str[i] == 'I' || str[i] == 'o' || str[i] == 'O' ||
            str[i] == 'u' || str[i] == 'U')
            vowels++;

        else if (str[i] == ' '){
            spaces++;
            words++;
        }

        else if (str[i] == '.' || str[i] == '?' || str[i] == '!')
            sentences++;
    }

    cout << "\n\n The number of Vowels are : " << vowels << endl;
    cout << "\n\n The number of Spaces are : " << spaces << endl;
    cout << "\n\n The number of Words are : " << words << endl;
    cout << "\n\n The number of Sentences are : " << sentences << endl;

    return 0;
}
