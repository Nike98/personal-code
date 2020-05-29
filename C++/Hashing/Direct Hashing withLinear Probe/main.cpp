///
/**
 *      WAP to implement Direct Hashing Algorithm
 *      and use Linear Probe method to resolve the collisions.
 */
///

#include<iostream>
#include<conio.h>
#include<stdlib.h>

#define MAX 100

using namespace std;

class Hash
{
private:
    int pos;
    int a[MAX];

public:
    Hash()
    {
        for (int i = 0; i < MAX; i++)
            a[i] = -999;
    }

    void display()
    {
        system("cls");
        cout << "\n\n";

        for (int i = 0; i < MAX; i++)
            cout << "\t" << a[i];
        cout << "\n";
        getch();
    }

    int insert()
    {
        int data;
        int count = 0;
        cout << "\n Enter the data: ";
        cin >> data;
        pos = direct_hash(data);

        if (pos > MAX)
            pos = 0;

        while (a[pos] != -999){
            pos = linear_probe(pos);
            count++;

            if (count > MAX){
                cout << "\n\n Memory is Full." << endl;
                return 0;
            }
        }

        if (a[pos] == -999)
            a[pos] = data;

        cout << "\n\n Data recorded successfully." << endl;
        getch();
    }

    int direct_hash(int key) { return key; }

    int linear_probe(int key)
    {
        if ((key - 1) > MAX)
            return 0;
        return (key + 1);
    }
};

int main()
{
    Hash hash;
    int choice;

    do {
        system("cls");
        cout << "\n\n ****** << DIRECT HASHING >> ******\n\n"
             << " 1. Insert\n"
             << " 2. Display\n"
             << " 3. Exit\n\n"
             << " Enter your choice: ";
        cin >> choice;

        switch (choice){
        case 1:
            hash.insert();
            break;
        case 2:
            hash.display();
            break;
        }
    } while (choice < 3);
    return 0;
}


































