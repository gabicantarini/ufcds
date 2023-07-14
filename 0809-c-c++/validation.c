// Crie uma função em C, do tipo void, que receba um caracter. Valida se é F/f ou M/m e escreve feminino ou masculino ou inválido.
#include <stdio.h>

void validarGenero(char caractere) {
    if (caractere == 'F' || caractere == 'f') {
        printf("Feminino\n");
    } else if (caractere == 'M' || caractere == 'm') {
        printf("Masculino\n");
    } else {
        printf("Inválido\n");
    }
}

int main() {
    char genero;
    printf("Digite um caractere (F/f para feminino, M/m para masculino): ");
    scanf(" %c", &genero);

    validarGenero(genero);

    return 0;
}





