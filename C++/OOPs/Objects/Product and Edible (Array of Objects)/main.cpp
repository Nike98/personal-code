///
/**
 *      Write a program which contains a class "Product" with member’s
 *      prod_id & product_name as its data members. Another class "Edible"
 *      inherits product class contains weight & price as its data members.
 *      Both the classes contain functions to accepts the data from user &
 *      then print it on screen. Main program should contain array of object of size 5.
 */
///

#include<iostream>
#include<string>

using namespace std;

class Product
{
private:
    int prod_id;
    string prod_name;

public:
    void getProdData();
    void Prod_Display();
};

class Edible : public Product
{
private:
    float weight, price;

public:
    void getData();
    void Display();
};

void Product::getProdData()
{
    cout << "\n\n Enter the Product ID : ";
    cin >> prod_id;

    cout << " Enter the Product Name : ";
    cin >> prod_name;
}

void Product :: Prod_Display()
{
    cout << "\n\n Product ID : " << prod_id << endl;
    cout << " Product Name : " << prod_name << endl;
}

void Edible::getData()
{
    cout << " Enter the Weight : ";
    cin >> weight;

    cout << " Enter the Price : ";
    cin >> price;
}

void Edible::Display()
{
    cout << " Weight : " << weight << endl;
    cout << " Price : " << price << endl;
}

int main()
{
    Edible arr[10];

    int count = 0;
    char ch;

    do {
        arr[count].getProdData();
        arr[count].getData();
        count++;
        cout << "\n Input another value (y/n)? : ";
        cin >> ch;
    } while (ch != 'n');

    for (int i = 0; i < count; i++){
        arr[i].Prod_Display();
        arr[i].Display();
    }

    return 0;
}
