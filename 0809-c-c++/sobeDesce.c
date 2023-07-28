#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <locale.h>

int nivel, numeroTentativas, tentativasJogador, numeroMisterio;

void menu(){
    printf("\n\n\n  *-*-*-*-*-*-*   JOGO SOBE E DESCE   *-*-*-*-*-*-* "); 
    printf("Escolha como começar: ");
    printf("\n\n1- Receber o número mistério a partir de um sorteio ");
    printf("\n2- Escolha o número mistério  ");
    printf("\n3- Escolha o número de tentativas ");
    printf("\n9- Digite 9 para encerrar o jogo.");
}

void sorteio(){
    do{
    printf("Escolha o nível do jogo: ");
    printf("\n 1 ");
    printf("\n 2 ");
    printf("\n 3 ");
    printf("\nDigite o nível do jogo: ");
    scanf("%d",&nivel);
  
   }while (nivel<1 || nivel>3);
  
   
   if (nivel==1){
  
   const int min=1;
   const int max=100;
   srand(time(NULL));
   numeroMisterio=(rand() % (max-min+1))+min;     
   printf("%d",numeroMisterio); 
   }
   
   if (nivel==2){
       
   const int min=1;
   const int max=1000;
   srand(time(NULL));
   numeroMisterio=(rand() % (max-min+1))+min;     
   printf("%d",numeroMisterio); 
   }
    if (nivel==3){
       
   const int min=1;
   const int max=10000;
   srand(time(NULL));
   numeroMisterio=(rand() % (max-min+1))+min;     
   printf("%d",numeroMisterio); 
   }

    printf("\nDigite o número de tentativas: ");
    printf("\nComecou, dê enter para adivinhar o número e boa sorte!... ");
    scanf("%d", &numeroTentativas);
    

    int tentativa;
    int acertou = 0;
    
    for (int i = 1; i <= numeroTentativas; i++) {
        printf("Tentativa %d de %d: ", i, numeroTentativas);
        scanf("%d", &tentativa);

        if (tentativa == numeroMisterio) {
            printf("Você acertou o número misterioso. Parabéns!!  %d\n", numeroMisterio);
            acertou = 1;
            break;
        }
    }

    if (!acertou) {
        printf("Acabaram as tentativas. Você não acertou o número misterioso: %d\n", numeroMisterio);
    }
}

void manual() {
  
    do {
        printf("Digite o nível do jogo (1 a 3): ");
        scanf("%d", &nivel);
    } while (nivel <= 0 || nivel > 3);

    if (nivel == 1) {
        do {
            printf("Digite o número mistério entre 1 e 100: ");
            scanf("%d", &numeroMisterio);
        } while (numeroMisterio < 1 || numeroMisterio > 100);
    }
    
     if (nivel==2){
        do{
        printf("Digite o número mistério entre 1 e 1000: ");
        scanf("%d",&numeroMisterio);
        }
        while (numeroMisterio <1 || numeroMisterio>1000);
        }
        
        if (nivel==3){
        do{
        printf("Digite o número mistério entre 1 e 10000: ");
        scanf("%d",&numeroMisterio);
        }
   
        while (numeroMisterio <1 || numeroMisterio>10000);
    } else {
        printf("Nível não implementado.\n");
        return;
    }

    printf("\nDigite o número de tentativas: ");
    scanf("%d", &numeroTentativas);

    int tentativa;
    int acertou = 0;
    
    for (int i = 1; i <= numeroTentativas; i++) {
        printf("Tentativa %d de %d: ", i, numeroTentativas);
        scanf("%d", &tentativa);

        if (tentativa == numeroMisterio) {
            printf("Parabéns!! Você acertou o número misterioso: %d\n", numeroMisterio);
            acertou = 1;
            break;
        }
    }

    if (!acertou) {
        printf("Acabaram as tentativas. Você não acertou o número misterioso: %d\n", numeroMisterio);
    }
}

int main() {
    setlocale(LC_ALL,"");
   int numeroMisterio=0;
   int opcao=0;
    do{
    
        menu();
       
        printf("\n\nEscolha a opção de jogo desejada: ");
        scanf("%d",&opcao);
        switch(opcao){
            case 1:
            sorteio();
            break;
            case 2:
            manual();
            case 9:
            printf("\n\nFim do jogo! ");
    }
    } while(opcao!=9);
        system("cls") ;
    

    return 0;
}
    