/*
Uma instituição de ensino realizou uma pesquisa sobre os eleitores de um município que participaram
numa dada eleição. Crie um programa que leia o total de votos brancos, nulos e válidos. Calcule e
escreva a percentagem que cada um representa em relação ao total de eleitores.
*/

#include <stdio.h>
#include <math.h>

int main() {
    float brancos, nulos, validos, total;

    printf("Digite o nÃºmero de votos em branco: ");
    scanf("%f", &brancos);

    printf("Digite o nÃºmero de votos nulos: ");
    scanf("%f", &nulos);

    printf("Digite o nÃºmero de votos vÃ¡lidos: ");
    scanf("%f", &validos);

    total = brancos + nulos + validos;

    printf("\nA %% de votos em branco foi %.2f %%\n", round((brancos / total) * 100));
    printf("A %% de votos nulos foi %.2f %%\n", round((nulos / total) * 100));
    printf("A %% de votos vÃ¡lidos foi %.2f %%\n", round((validos / total) * 100));

    return 0;
}