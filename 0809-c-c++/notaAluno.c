//Crie uma função em C, do tipo void, que receba a nota final de um aluno (entre 0 e 20) 
// e escreva “Aprovado” (Se maior do que 12), “Exame” (Entre 10 e 12), “Reprovado” (Se menor do que 10).

# include <stdio.h>



int main() {
    int notaFinal;

    printf("Qual a nota final do aluno? %d", notaFinal);

    if(notaFinal > 12) {
        printf("APROVADO %d", notaFinal);
    };

    return 0;
}
