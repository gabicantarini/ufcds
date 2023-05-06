#include <stdio.h>
//In the following loop, when the value is "4", jump directly to the next value.
int main() {

    
    for (int i = 0; i < 10; i++) {
      if (i == 4) {
        
        continue;
      }
      printf("%d\n", i);
    }

    return 0;
}