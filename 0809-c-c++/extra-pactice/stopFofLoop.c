#include <stdio.h>
//Stop the loop if i is 5.
int main() {

  for (int i = 0; i < 10; i++) {
    if (i == 5) {
      
    break;
    }
    printf("%d\n", i);
  }
    return 0;
}