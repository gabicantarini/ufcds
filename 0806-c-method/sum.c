#include <stdio.h>

int main()
{
    int j, k;
    
    printf("dê um valor: ");
    scanf("%d",&j);
    printf("dê outro valor: ");
    scanf("%d",&k);
  
    printf("%d\n",j+k);
    
    return 0;
}


    /*int littleMatrix[10];
    srand(time(NULL));
    
    // Fillout range between 1 n 100
    for (int i = 0; i < 11; i++) {
        littleMatrix[i] = rand() % 100;
        printf("Little Matrix [%d]: %d\n ",littleMatrix[i]);
    }*/

