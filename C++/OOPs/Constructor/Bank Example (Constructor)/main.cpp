///
/**
 *      Write a class to represent a Bank Account with the following data members.
 *      1. Account Number
 *      2. Type of Account
 *      3. Balance Amount in Account
 *
 *      And a member function to get the details fro the User and display it
 *      and write a main method to test the class using Constructor.
 */
///

#include<iostream>
#include<string>

using namespace std;

class Bank
{
    long ac_no;
    string ac_type;
    float balance;
public:
    Bank(){
        getInput();
    }

    void getInput();
    void display();
};

void Bank :: getInput(){
    cout << " Enter the Account Number : ";
    cin >> ac_no;
    cout << " Enter the Account Type : ";
    cin >> ac_type;
    cout << " Enter the Account balance: ";
    cin >> balance;
}

void Bank :: display(){
    cout << "\n\n Account Number : " << ac_no << endl;
    cout << " Account Type : " << ac_type << endl;
    cout << " Account Balance : " << balance << endl;
}

int main()
{
    Bank bk;
    bk.display();

    return 0;
}
