#include<iostream>

using namespace std;

class sample
{
private:
    static int count;
public:
    sample();
    void dispaly();
};

int sample :: count = 0;
    sample :: sample()
    {
        ++count;
    }
void sample :: dispaly()
{
    cout << " Counter Values : " << count << endl;
}

int main ()
{
    sample ob1, ob2, ob3, ob4;
    ob4.dispaly();
    return 0;
}
