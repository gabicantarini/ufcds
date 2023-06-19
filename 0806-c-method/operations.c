#include <stdio.h>
#include <string.h>

int main()
{
    int ope1, ope2;
    char operacao[5];
    
    printf("dê o primeiro operando: ");
    scanf("%d", &ope1);
    
    printf("dê o segundo operando: ");
    scanf("%d", &ope2);
    
    printf("Escolha a operação (+, -, x, /): ");
    scanf("%s", operacao);

    if (strcmp(operacao, "+") == 0)
        printf("%d\n",ope1+ope2);
    
    if (strcmp(operacao, "-") == 0)
        printf("%d\n",ope1-ope2);
        
    if (strcmp(operacao, "x") == 0)
        printf("%d\n",ope1*ope2);
        
    if (strcmp(operacao, "/") == 0)
        printf("%d\n",ope1/ope2);

    return 0;
}