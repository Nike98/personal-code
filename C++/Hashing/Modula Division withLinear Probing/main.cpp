///
/**
 *      WAP to implement Modulo Division Hashing Algorithm in an
 *      array size of 13 and use Linear Probe method to resolve
 *      the collisions.
 */
///

#include<iostream>
#include<conio.h>
#include<stdlib.h>

#define MAX 13

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
        pos = moduloDiv_hash(data);

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

    int moduloDiv_hash(int key) { return (key % MAX); }

    int linear_probe(int key)
    {
        if ((key + 1) > MAX)
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
        cout << "\n\n ****** << HASHING - MODULO DIVISION >> ******\n\n"
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


































