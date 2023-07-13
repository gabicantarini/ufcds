//Crie uma função em C, do tipo void, que receba a nota final de um aluno (entre 0 e 20) 
// e escreva “Aprovado” (Se maior do que 12), “Exame” (Entre 10 e 12), “Reprovado” (Se menor do que 10).

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

int main() {
    float nota;
    printf("Digite a nota final do aluno (entre 0 e 20): ");
    scanf("%f", &nota);

    verificarStatusAluno(nota);

    return 0;
}
