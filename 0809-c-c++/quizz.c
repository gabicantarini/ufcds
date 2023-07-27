#include<stdio.h>    
#include<stdlib.h>  
#include<conio.h>    
    
struct play   
{    
    char name[20];    
    int score;    
    int rating;         
}p;    
    
void high_score();    
void start();    
void menu(); 
    
  

void main()    
{    
      
  menu();
    
 
}  


void menu(){
    // choice variable is declared  
    // in order to know the choice of the user  
    int choice = 0;  
    printf(" ******BEM VINDO AO JOGO********** \n ");  
    printf(" Digite 1 para começar o jogo. \n ");  
    printf(" Digite 2 para saber o score. \n "); 
    printf(" Digite 0 para sair \n ");  
    printf(" Escolha a sua opção: ");  
      
    scanf( "%d", &choice );    
      
   
    // multiplas opções

    switch(choice)    
    {    
        // começa o jogo 
        case 1:    
            start();    
            break;    
  
        // nivela o score  
        case 2:    
            high_score();    
            break;    
  
        // sai do jogo  
        default: exit(1);    
    }   
    return;
}


// encontra o maior socore

void high_score()    
{  
  
 
  // para escolher ficar ou sair do jogo 
  int ch;    
    
  
  // compara scores 
  //simula abrir um file para arquivar os scores
  FILE *fa;    
  if ( fa == NULL )    
  {    
    printf( "\n Ainda não há pontuações!!\n " );    
  }    
  else    
  {    
    printf( "\n Difinindo a pontuação!! \n\n " );    
    printf(" Nome     Pontos     Classificação\n " );    
    while(fscanf(fa," %s %d %d", p.name, &p.score, &p.rating) !=EOF )    
    {    
      printf( " .................................\n " );    
      printf( " %s     %d     %d star(s)\n\n ", p.name,p.score, p.rating );    
    }    
    // simula fechar um file 
    fclose(fa);    
    
  }    
 
  printf("\n Você quer continuar o jogo? Se sim, digite 1!! Caso contrário, digit1 0 :  " );    
  scanf( "%d", &ch );    
    
  // para continuar a jogar  
  if( ch == 1 )    
  {    
    start();    
  }    
  
  // para fechar o jogo  
  else    
  {    
    exit(1);    
  }    
    
}  
  
  
// começar o jogo 
void start()    
{    

    // guardar resposta  
    int answer;   
    // guardar contagem  
    int count = 0;    
  
    // guardar rating 
    char rating[20];    
      
    FILE *fa;    
    
    if(fa==NULL)    
    {    
        printf("Configurar informações!\n ");    
    }    
    
    
    printf( "\n Digite seu nome: " );  
    scanf( "%s", p.name );    
    
 
    printf(" Seja bem vindo ao Jogo de conhecimentos de Portugal\" %s \"   \n\n ", p.name);   
      
    printf(" O jogo vai começar!! Acerte o melhor de 4\n ");  
    printf(" Boa sorte!! ");  
      
      //primeira pergunta
    printf(" Perguta 1: \n");  
    printf(" Qual o nome do presidente de Portugal? \n 1. Marcelo Rebelo de Sousa \t \t 2. Lula da Silva \t \t 3. Paulo Ribeiro \t \t 4. Bill Gates \n\n ");    
    
    printf("Digita a sua opção: ");    
  
    scanf("%d", &answer);    

    if( answer == 1 )    
    {    
        printf(" Sua resposta está correta \n ");   
        printf(" Você ganhou 5 pontos !! \n\n ");  
        ++count;    
    }   
    else    
    {    
        printf("Sua resposta está errada. \n\n");    
    }     
      
      //segunda pergunta
    printf(" Pergunta 2: \n");  
    printf(" Qual a cor da bandeira? \n 1. Vermelha e Branca \t \t 2. PReta e Azul \t \t 3. Vermelha e Verde \t \t 4. Castanha e Verde \n\n ");    
    
    printf("Digita a sua opção: ");    

    scanf("%d", &answer);    
 
    if( answer == 3 )    
    {    
        printf("Sua resposta está correta \n ");   
        printf("Você ganhou 5 pontos  !! \n\n ");  
        ++count;    
    }   
 
    else    
    {    
        printf("Sua resposta está errada. \n\n");    
    }   
      
      //terceira pergunta
    printf(" Pergunta 3: \n");  
    printf(" Qual a população de Portugal ? \n 1. + de 10 M \t \t 2. - de 10 M \t \t 3. 30 M \t \t 4. 1 M \n\n ");    
    
    printf("Digita a sua opção: ");    
  

    scanf("%d", &answer);    

    if( answer == 1 )    
    {    
        printf("Sua resposta está correta \n ");   
        printf("Você ganhou 5 pontos !! \n\n ");  
        ++count;    
    }   
  
    else    
    {    
        printf(" Sua resposta está errada. \n\n");    
    }  
        
   

    
    // conferir as respostas   
    if(count > 0)    
    {    
        printf(" Você fez %d pontos \t \n", count * 5 );    
        printf(" Obrigada!! \n");  
        p.score = count * 5;    
  
 
        if( p.score >= 20 )    
        {    
            printf("Classificação: 5/5 \n");    
            p.rating = 5;    
        }    

        else if( p.score >= 20 && p.score < 15 )    
        {    
            printf("Classificação: 4/5 \n");    
            p.rating = 4;    
        }    

        else if(p.score < 15)    
        {    
            printf("Classificação: 2/5 \n");    
            p.rating = 2;    
        }    
 

    
        // gerar resultados    
    
        fprintf(fa, "%s %d %d", p.name, p.score, p.rating);    
        fclose(fa);    
    }    
    else    
    {    
        printf("Tente novamente\n"); 
        system("cls");
        menu();
    }    
} 