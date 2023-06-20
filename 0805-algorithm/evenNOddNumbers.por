/*1. Escrever um algoritmo que:
    a) Gere um vetor A de 20 elementos inteiros entre 1 e 20;
    b) Construa e imprima um outro conjunto B formado da seguinte maneira:
    → os elementos de índice par têm o valor de A dividido por 2;
    → os elementos de índice ímpar têm o valor de A multiplicado por 3.
*/

programa {
    
    inclua biblioteca Util  

  funcao inicio() {
    inteiro A[20], B[20] 
    inteiro elementosPar = 0, elementosImpar = 0
    //escreva("\nElementos A: \n") 
    para(inteiro i = 0; i < 20; i++)
    {
        A[i] = (i+1)

    }
    
    para (inteiro i = 0; i < 20; i++) {
        
        se(i % 2 == 0)
        {
            elementosPar = A[i] / 2
            //elementosPar = A[i] / 2
            escreva("Elementos A: [", A[i], "] Elementos B - PAR: ", "[", elementosPar, "]", "\n")
            
        }
      
        senao
        {
            elementosImpar = A[i] * 3
            escreva("Elementos A: [", A[i], "] Elementos B - Ímpar: ", elementosImpar, "]\n")
        }
        
    }
    

  }
}