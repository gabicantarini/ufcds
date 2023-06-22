programa {    
     
        /*
        2. Crie uma matriz 5x5 com números aleatórios entre 1 e 15: 
        a) Mostre os valores. 
        b) Apresente os valores da diagonal esquerda e a respetiva média. 
        c) Apresente os valores da diagonal direita e a respetiva média. 
        */
    inclua biblioteca Util --> x  
    funcao inicio() {
        inteiro matriz[15][15]
        inteiro diagonalEsquerda = 0       
        inteiro diagonalDireita = 0 
        inteiro mediaDiagonalEsquerda = 0       
        inteiro mediaDiagonalDireita = 0 
        
        para (inteiro linha = 0; linha < 15; linha++) {
            para (inteiro coluna = 0; coluna < 15; coluna++) {
                matriz[linha][coluna] = x.sorteia(1, 15)
                escreva("[", matriz[linha][coluna], "] ")
            }
            escreva("\n") 
        }
            //escreva("\nDiagonal Esquerda: ")
        para(inteiro i = 0; i < 5; i++){
            se (i < 3) {
                escreva("DIAG ESQ: [", i, "]\n")
                diagonalEsquerda = diagonalEsquerda + 1
            } 
            se (i> 3) {
                escreva("DIAG DIR: [", i, "]\n")
                diagonalDireita = diagonalDireita + 1
            } 
        }
    
        
        /*escreva("\nContagem final:\n")
        escreva("Média Diagonal Esquerda: ", diagonalEsquerda, "\n")
        escreva("Média Diagonal Direita: ", diagonalDireita, "\n")*/
    }
}
