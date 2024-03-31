#include <stdio.h>
 
//definição da classe Biblioteca

class Bicicleta{

public:

	int cor; //atributo cor inteiro e público
	int numeroRodas; //atributo numero#Rodas inteiro e público
	int marca; //atributo marca inteiro e público

};
 

void main()
{
    Bicicleta bike1;
    Bicicleta bike2;

    //define atributo cor
    bike1.cor=4; 
    bike2.cor=5;

    //define atributo numeroRodas
    bike1.numeroRodas=5;
    bike2.numeroRodas=6;

    //define atributo marca
    bike1.marca=100;
    bike2.marca=150;

    //apresenta no ecrã atributos bike 1
    printf("BIKE 1%d\n");
    printf("cor:%d\n", bike1.cor);
    printf("numero de rodas:%d\n", bike1.numeroRodas);
    printf("marca:%d\n", bike1.marca);

    //apresenta no ecrã atributos bike 
    printf("BIKE 2%d\n");
    printf("cor:%d\n", bike2.cor);
    printf("numero de rodas:%d\n", bike2.numeroRodas);
    printf("marca:%d\n", bike2.marca);

    while (1);

}