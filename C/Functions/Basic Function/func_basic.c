
/**
 *  This is the example use of normal/basic
 *  functions in C.
 */

 int main()
 {
    loop();
    printf("\n A function was executed");
    return;
 }

 int loop()
 {
     for (int i = 1 ; i <= 10 ; i++){
        printf(" %d\n", i);
     }
     return;
 }
