// Crie uma função em C, do tipo void, que receba 3 números e apresente o maior.
#include <stdio.h>

void maiorDeTres(int num1, int num2, int num3) {
    int maior = num1;

    if (num2 > maior) {
        maior = num2;
    }

    if (num3 > maior) {
        maior = num3;
    }

    printf("O maior número é: %d\n", maior);
}

int main() {
    int num1, num2, num3;
    printf("Digite três números: ");
    scanf("%d %d %d", &num1, &num2, &num3);

    maiorDeTres(num1, num2, num3);

    return 0;
}




