#include <stdio.h>
#include <string.h>

int main()
{
    char nome[20];
    
    printf("dê o seu nome: ");
    scanf("%s", nome);

    if (strcmp(nome, "gabriela") == 0)
            printf("Que nome tão bonito!\n");
        else
            printf("Há melhor.\n");        
    
    return 0;

}