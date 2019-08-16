///
/**
 *      Electricity Board charges the following rates for
 *      domestic Users to discourage large
 *      consumption of energy:
 *
 *      a) For 1st 100 units : 120ps/Unit
 *      b) For next 200 units : 150ps/Unit
 *      c) Beyond 300 units : 200ps/Unit
 *
 *      All users are charged a minimum of Rs.50 if
 *      total amount is greater than 300 and additional
 *      charge of 15% is added.
 *
 *      WAP to read Name of user, No. of Units consumed
 *      and print the charge with the names.
 */

 #include<stdio.h>
 //#include<conio.h>

 int main()
 {
     char name[20];
     float units, charged_rate, total_bill, surcharge = 0;
     //clrscr();

     // Intro
     printf("\n\n\t ELECTRICITY BOARD CHARGES");
     printf("\n\t Discourage Large Consumption of Energy\n");

     // Asking for the User's Name
     printf("\n Enter User Name: ");
     scanf("%s", &name);

     // Asking User for the Number of Units Consumed
     printf("\n\n Enter the Number of Units Consumed: ");
     scanf("%f", &units);

     // Manipulation of the Chargeable Amount Starts here
     if (units <= 100)
        charged_rate = units * 1.20;
     else if (units <= 200)
        charged_rate = units * 1.50;
     else
        charged_rate = units * 2.00;

     // Adding the Surcharge of 15% if total charged amount is greater than 300
     if (charged_rate > 300)
        surcharge = charged_rate * 0.15;

     // Calculating the Total bill with the minimum Rs.50 charge
     total_bill = 50 + surcharge + charged_rate;

     // Displaying the final bill amount to the User
     printf("\n\n Name of the User: %s", name);
     printf("\n Total Bill Amount: %f", total_bill);

     //getch();
     return 0;
 }
