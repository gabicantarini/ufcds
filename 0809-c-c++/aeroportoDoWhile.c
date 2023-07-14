#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
  
void cabecalho();
int validar_hora(int hora);
int validar_minuto(int minuto);

int main(){
    int hp=0,mp=0,hd=0,md=0,hc=0,mc=0;
    char continuar;
    setlocale(LC_ALL,"");
    do{
        system("cls");
        cabecalho();
        printf("PARTIDA\n\n");
        // validar hora da partida
        do{
            printf("HORA:");
            scanf("%d",&hp);
        }while(validar_hora(hp)==0);
        // validar minuto da partida
        do{
            printf("MINUTO:");
            scanf("%d",&mp);
        }while(validar_minuto(mp)==0);
        printf("\n\nDURAÇÃO\n\n");
        // validar hora da duração
        do{
            printf("HORA:");
            scanf("%d",&hd);
        }while(validar_hora(hd)==0);
        // validar minuto da duração
        do{
            printf("MINUTO:");
            scanf("%d",&md);
        }while(validar_minuto(md)==0);
        // calcular a hora e o minuto da chegada
        hc=hp+hd;
        mc=mp+md;

        if(mc>59){
            hc++;
            mc-=60;
        }
        if(hc>23){
            hc-=23;
            printf("\nO voo chegou no dia seguinte !");
        }
        else{
            printf("\nO voo chegou no próprio dia.");
        }

        printf("\nÀs %d horas e %d minutos.",hc,mc);
        fflush(stdin);
        printf("\nDigite Ss para continuar ou outra tecla para sair:");
        scanf("%c",&continuar);

    }while(continuar=='S' || continuar=='s');

    return(0);    
}

void cabecalho(){
   printf ("  00   000  000    00   000    00   000  00000  00\n");
   printf (" 0  0  0    0  0  0  0  0  0  0  0  0  0   0   0  0 \n");
   printf (" 0000  000  000   0  0  000   0  0  000    0   0  0\n");
   printf (" 0  0  0    0  0  0  0  0     0  0  0  0   0   0  0\n");
   printf (" 0  0  000  0   0  00   0      00   0   0  0    0 0 \n\n\n");
}

int validar_hora(int hora){
    if(hora<0 || hora>23){
        return(0);
    }
    else{
        return(1);
    }
}

int validar_minuto(int minuto){
    if(minuto<0 || minuto>59){
        return(0);
    }
    else{
        return(1);
    }
}