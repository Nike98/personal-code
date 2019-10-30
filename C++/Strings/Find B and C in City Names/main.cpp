#include<iostream>

using namespace std;

int main()
{
    char city[100][100];
    int num;

    cout << " Enter the Number of Cities you want to enter: ";
    cin >> num;

    cout << "Enter the Cities : \n" << endl;
    for (int i = 0; i < num; i++)
        cin >> city[i];

    cout << "\n\n Cities Entered by you are : \n" << endl;
    for (int i = 0; i < num; i++)
        cout << " " << city[i] << endl;

    int k = 0;

    cout << "\n\n City Names with the Letter b or c are : \n" << endl;

    for (int i = 0; i < num; i++){
        if ((city[i][k] == 'b') || (city[i][k] == 'c'))
            cout << " " << city[i] << endl;
    }

    return 0;
}
