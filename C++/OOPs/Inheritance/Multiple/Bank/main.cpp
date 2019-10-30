///
/**
 *      Create a class account that stores customer name, account number
 *      and type of the account. From this derive the classes cur_acc and
 *      sav_acc  to make them more specific to their requirements.
 *      Include necessary member functions in order to achieve the following tasks:
 *
 *        -> Accept deposit from customer and update the balance.
 *        -> Display the balance.
 *        -> Compute and deposit interest.
 *        -> Permit withdrawal and update the balance.
 *        -> Check for the minimum balance, impose penalty necessary, and update the balance.
 */
///


#include<iostream>
#include<string>
#include<math.h>

using namespace std;

class Account
{
protected:
    string name, ac_type;
    long long ac_no;
    float balance;

public:
    Account(){
        // Delete if Empty
    }

    void Input(){
        cout << " Enter your Name : ";
        cin >> name;
        cout << " Enter the Account Number : ";
        cin >> ac_no;
        cout << " Enter the Account Type : ";
        cin >> ac_type;
        //fflush(stdin);
        cout << " Enter the Balance : ";
        cin >> balance;
    }

    void Display(){
        cout << "\n\n Customer Name : " << name << endl;
        cout << " Account Number : " << ac_no << endl;
        cout << " Account Type : " << ac_type << endl;
        cout << " Balance : " << balance << endl;
    }

    void Deposit(){
        float amount;
        cout << "\n\n Enter the Amount to be Deposited : ";
        cin >> amount;
        balance += amount;
    }
};

class Sav_Acc : public Account {
private:
    float interest;
public:
    float compute_Interest(){
        int time, rate = 10;

        cout << " Enter the Time : ";
        cin >> time;

        interest = balance * pow(1 + rate/100.0, time) - balance;

        return interest;
    }

    void update_Balance(){
        balance += compute_Interest();
    }

    void withdrawal(){
        float amount;

        cout << "\n\n Enter the Amount to be Withdrawn : ";
        cin >> amount;

        if (balance >= amount)
            balance -= amount;
        else
            cout << "\n\n The Amount cannot be Withdrawn due to Insufficient Balance." << endl;
    }
};

class Cur_Acc : public Account {
private:
    int penalty;

public:
    int min_bal(){
        int ret = 1;

        if (balance < 500){
            penalty = 50;
            balance -= penalty;
            ret = 0;
        }
        else
            cout << "\n\n No Penalty Imposed." << endl;
        return ret;
    }

    void withdrawal(){
        int amount;

        cout << "\n\n Enter the Amount to be Withdrawn : ";
        cin >> amount;

        int check = min_bal();
        if (check == 1)
            balance -= amount;
        else
            cout << "\n\n The Amount cannot be Withdrawn due to Insufficient Balance." << endl;
    }
};

int main()
{
    Cur_Acc curAc;
    Sav_Acc savAc;

    cout << "\n\n ***********WELCOME TO THE BANK***********\n" << endl;

    // CURRENT ACCOUNT
    curAc.Input();
    curAc.Display();
    curAc.Deposit();
    curAc.Display();
    curAc.withdrawal();
    curAc.Display();

    // SAVINGS ACCOUNT
    savAc.Input();
    savAc.Display();
    savAc.Deposit();
    savAc.Display();
    savAc.withdrawal();
    savAc.Display();

    return 0;
}
