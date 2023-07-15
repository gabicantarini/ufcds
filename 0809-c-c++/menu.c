// Crie uma função em C, do tipo void, que receba um número entre 0 e 50 e devolva a informação se o número é par ou ímpar.

#include <stdio.h>

void verificarStatusAluno(float notaFinal) {
    if (notaFinal > 12) {
        printf("Aprovado\n");
    } else if (notaFinal >= 10 && notaFinal <= 12) {
        printf("Exame\n");
    } else {
        printf("Reprovado\n");
    }
}

void calcularDesconto(float valor, float percentual) {
    float desconto = valor * (percentual / 100.0);
    printf("O valor do desconto é: %.2f\n", desconto);
}

void verificarParImpar(int numero) {
    if (numero % 2 == 0) {
        printf("O número %d é par.\n", numero);
    } else {
        printf("O número %d é ímpar.\n", numero);
    }
}

void encontrarMaior(int num1, int num2, int num3) {
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


    return 0;
}





 