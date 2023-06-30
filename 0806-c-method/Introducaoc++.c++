/*Introdução*/

#include <stdio.h>


class Bicicleta {
public:
    int cor;
    int numeroDeRodas;
};

int main()
{
    Bicicleta bike1;
    
    bike1.cor=4;
    bike1.numeroDeRodas=5;
    printf("Cor: %d\n",bike1.cor);
    printf("numero de rodas: %d\n", bike1.numeroDeRodas);

    return 0;
};