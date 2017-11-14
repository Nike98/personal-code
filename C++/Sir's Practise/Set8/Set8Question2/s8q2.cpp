///
/**
  * ##############################################
  *
  *         WAP to Overload '<<' and
  *             '>>' operator.
  *
  * ##############################################
**/
///

#include <iostream>
#include <string.h>

using namespace std;

class MeData
{
private:
    string name;
    int age;
public:
    friend ostream &operator << (ostream &out, MeData &obj);
    friend istream &operator >> (istream &inp, MeData &obj);
        /**
            1. Friend keyword is used here so that it can modify this class
            2. The 'ostream' keyword is used here because << (insertion) operator is of ostream class
            3. Same is with istream keyword which include >> (extraction) operator
            4. Here we have to pass 2 parameters (as the function itself and it's object, as the class and it's object)
        **/
};

ostream &operator << (ostream &out, MeData &obj)
{
    out << " My Name is " << obj.name << " and my Age is " << obj.age << endl;
    return out;
}

istream &operator >> (istream &inp, MeData &obj)
{
    inp >> obj.name;
    inp >> obj.age;
    return inp;
}

int main ()
{
    cout << " Enter the Name and Age" << endl;

    MeData me;

    cin >> me;

    cout << "\n" << me << endl;

    return 0;
}
