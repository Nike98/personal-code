///
/**
 *  Define a class to represent a Bank Account.
 *  Include the following members:
 *
 *  Data Members:
 *  1. Name of the Depositor
 *  2. Account Number
 *  3. Type of Account
 *  4. Balance amount in the Account
 *
 *  Member Functions:
 *  1. To assign initial values
 *  2. To deposit an amount
 *  3. To withdraw amount after checking the balance
 *  4. To display the name and the balance
 */
///

#include <iostream>

using namespace std;

class Account{
private:
    string name = "Nikhil";
    long ac_no = 1231234567;
    string ac_type = "Savings";
    float balance = 4500.00;

public:
    void Display(){
        cout << "\n\n Name: " << name << endl;
        cout << " Account Number: " << ac_no << endl;
        cout << " Account Type: " << ac_type << endl;
        cout << " Current Balance: " << balance << endl;
    }

    void Withdraw(){
        float amount;
        cout << "\n Enter the amount to be Withdrawn: ";
        cin >> amount;

        balance -= amount;

        cout << "\n The Account Balance after the Withdrawal: " << balance << endl;
    }

    void Deposit(){
        float amount;
        cout << "\n Enter the Amount to be Deposited: ";
        cin >> amount;

        balance += amount;

        cout << "\n The Account Balance after Deposit: " << balance << endl;
    }
};

int main()
{
    Account ac;

    int choice;
    do{
        cout << "\n\n WELCOME" << endl;
        cout << " 1. Display" << endl;
        cout << " 2. Deposit" << endl;
        cout << " 3. Withdraw" << endl;
        cout << " 4. Exit" << endl;
        cout << " Enter your choice: ";
        cin >> choice;
        switch(choice){
        case 1:
            ac.Display();
            break;
        case 2:
            ac.Deposit();
            break;
        case 3:
            ac.Withdraw();
            break;
        }
    } while (choice < 4);

    return 0;
}
