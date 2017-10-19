#include <iostream>

using namespace std;

class SimpleIntrest
{
public:
    SimpleIntrest (int price, int years, float roi)
    {
        float si;

        si = (price * roi * years) / 100;

        cout << " The Simple Interest = " << si << endl;
    }

    ~SimpleIntrest (){
        cout << "\n The Destructor Function is called" << endl;
    }
};

int main ()
{
    SimpleIntrest *simInt;

    simInt = new SimpleIntrest(500, 10, 5);

    delete simInt;

    return 0;
}
