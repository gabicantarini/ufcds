/* Crie um algoritmo que preencha uma matriz 5x5, com números entre 10 e 20, 
e mostre os elementos da diagonal esquerda, os elementos da diagonal direita, 
a soma dos elementos da diagonal esquerda e a soma dos elementos da diagonal direita. */

programa {
  inclua biblioteca Util --> x
  funcao inicio() {
    inteiro matriz[5][5]
    inteiro de=0, dd=0
    para(inteiro linha=0;linha<5;linha++)
    {
      para(inteiro coluna=0;coluna<5;coluna++)
      {
        matriz[linha][coluna]= x.sorteia(10,20)
      }  
    }

    escreva("\nElementos da matriz\n")
    para(inteiro linha=0;linha<5;linha++)
    {
      para(inteiro coluna=0;coluna<5;coluna++)
      {    
        escreva(matriz[linha][coluna],"  ")
      }
      escreva("\n")
    }    
   
    escreva("\nElementos da diagonal esquerda\n")
    para(inteiro i=0;i<5;i++)
    {
      escreva(matriz[i][i]," - ")
      de+=matriz[i][i]
    }
    escreva("\nA soma dos elementos da diagonal esquerda é ",de)
    
    escreva("\nElementos da diagonal direita\n")
    para(inteiro i=0;i<5;i++)
    {
      escreva(matriz[i][4-i]," - ")
      dd+=matriz[i][4-i]
    }
    escreva("\nA soma dos elementos da diagonal direita é:  ",dd)
  }
}