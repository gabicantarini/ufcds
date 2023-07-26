#include <stdio.h>
#include <stdlib.h>
#include <locale.h>


#define NOTAS 10

void menu();
void recolha(float lista[]);
void mostra_notas(float lista[]);
void media_notas(float lista[]);
void alterar_notas(float lista[]);
void maior_nota(float lista[]);
void contagem_aprovados(float lista[]);
void contagem_reprovados(float lista[]);

int main(){
   setlocale(LC_ALL,""); 
   float alunos[NOTAS];
   int opcao=0;
   do{
        
        menu(); 
        scanf("%d",&opcao);
        switch(opcao){
            case 1:
                recolha(alunos);
                break;
            case 2:
                mostra_notas(alunos);
                break;  
            case 3:
                media_notas(alunos);
                break;  
            case 4:
                alterar_notas(alunos);
                break;  
            case 5:
                maior_nota(alunos);
                break; 
            case 6:
                contagem_aprovados(alunos);
                break; 
            case 7:
                contagem_reprovados(alunos);
                break;    
            case 0:
                printf("Fim do prgrama !!!A aplicação irá fechar dentro de 3 segundos\n");
                break;
            default:
                printf("Opção inválida !!!\n");
        }

   }while(opcao!=0); 

   return 0;
}

void menu(){
    printf("\nGestão de Notas\n");
    printf("\n1-Recolha de notas");
    printf("\n2-Mostra todas as notas");
    printf("\n3-Mostra a média das notas");
    printf("\n4-Alterar uma nota (indicando a posição)");
    printf("\n5-Mostar a nota mais alta");
    printf("\n6-Mostar uma contagem dos aprovados (nota>=10)");
    printf("\n7-Mostar uma contagem do reporovados (nota<10)");
    printf("\n0-Sair");
    printf("\n\nDigite a sua opção:");
}

void recolha(float lista[]){    
    printf("Recolha de notas\n");
    for(int i=0;i<NOTAS;i++){
        do{
           printf("Digite a %dª nota:",(i+1));
           scanf("%f",&lista[i]);
        }while(lista[i]<0 || lista[i]>20);
    }
    printf("\nRegisto de notas efetuado\n");
    
}

void mostra_notas(float lista[]){    
    printf("Listagem de notas\n");
    for(int i=0;i<NOTAS;i++){
        printf("\n%dª nota: %.2f",(i+1),lista[i]);
    }
    printf("\nFim de listagem\n");
    
}
void media_notas(float lista[]){
    float soma=0;
    
    printf("Média de notas\n");
    for(int i=0;i<NOTAS;i++){
        soma+=lista[i];
    }
    printf("\nA média das notas é %.2f\n",(soma/NOTAS));
    
}
void alterar_notas(float lista[]){
    int posicao=0;
   
    printf("Alterar nota\n");
    do{
        printf("Qual a nota que pretende alterar (de 1 a 10):");
        scanf("%d",&posicao);
    }while(posicao<1 || posicao>10);
    printf("\nA nota atual é %.2f",lista[posicao-1]);
    do{
        printf("\nDigite a nova nota:");
        scanf("%f",&lista[posicao-1]);
    }while(lista[posicao-1]<0 || lista[posicao-1]>20);    
    printf("\nNota alterada com sucesso\n");
       
}
void maior_nota(float lista[]){
    float maior=lista[0];
    
    printf("Maior nota\n");
    for(int i=0;i<NOTAS;i++){
       if(lista[i]>maior) maior=lista[i]; 
    }
    printf("\nA maior nota é %.2f\n",maior);
    
}
void contagem_aprovados(float lista[]){
    int aprovados=0;
    
    printf("Número de alunos aprovados\n");
    for(int i=0;i<NOTAS;i++){
       if(lista[i]>=10) aprovados++; 
    }
    printf("\nForam APROVADOS %d alunos.",aprovados);
    
}
void contagem_reprovados(float lista[]){
    int reprovados=0;
    
    printf("Número de alunos reprovados\n");
    for(int i=0;i<NOTAS;i++){
       if(lista[i]<10) reprovados++; 
    }
    printf("\nForam REPROVADOS %d alunos.",reprovados);
    
}