///
/**
 *      On a certain day the British pound was equivalent to $1.487 USD,
 *      the French Franc was $0.172, the German Deutsch mark was $0.584,
 *      and the Japanese Yen was $0.0095.
 *
 *      Write a program that allows the user to enter an amount in dollars,
 *      and then displays this value converted to these four monetary units.
 */
///


#include <iostream>

using namespace std;

int main()
{
    // Rates of 1 Dollar on a certain day
    float british_pound = 1.487;
    float french_franc = 0.172;
    float german_deu = 0.584;
    float jap_yen = 0.0095;
    float input;

    cout << " Enter the amount in Dollars: ";
    cin >> input;

    cout << "\n\n British Pound: " << input * british_pound << endl;
    cout << " French Francs: " << input * french_franc << endl;
    cout << " German Deutsch: " << input * german_deu << endl;
    cout << " Japanese Yen: " << input * jap_yen << endl;

    return 0;
}
