#include <stdio.h>
//Complete the switch statement, and add the correct keyword at the end to specify some code to run if there is no case match in the switch statement.
int main() {

    int day = 4;
    switch (day) {
    
    case  1:
        printf("Saturday");
        
    break;
    
    case  2:
        printf("Sunday");
        
    break;
    
    default:
        printf("Weekend");
    }

    return 0;
}

