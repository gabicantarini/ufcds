#include <stdio.h>
//Create a method named myFunction and call it inside main().

int myFunction(int x) {
  return 5 + x;
}

int main() {
  
    printf("%d", myFunction(3));

    return 0;
}