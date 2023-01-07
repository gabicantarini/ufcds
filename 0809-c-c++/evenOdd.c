// Crie uma função em C, do tipo void, que receba um número entre 0 e 50 e devolva a informação se o número é par ou ímpar.

#include <stdio.h>

void verificarParImpar(int numero) {
    if (numero % 2 == 0) {
        printf("O número %d é par.\n", numero);
    } else {
        printf("O número %d é ímpar.\n", numero);
    }
}

int main() {
    int numero;
    printf("Digite um número entre 0 e 50: ");
    scanf("%d", &numero);

    if (numero >= 0 && numero <= 50) {
        verificarParImpar(numero);
    } else {
        printf("Número inválido. Digite um número entre 0 e 50.\n");
    }

    return 0;
}




