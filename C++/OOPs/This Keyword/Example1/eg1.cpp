#include <iostream>

using namespace std;

class A
{
private:
    int a;
public:
    void Val (int a){
        this -> a = a;
    }

    void Print () { cout << " The value of a = " << a << endl; }
};

int main ()
{
   A obj;

   obj.Val (5);
   obj.Print();

   return 0;
}
