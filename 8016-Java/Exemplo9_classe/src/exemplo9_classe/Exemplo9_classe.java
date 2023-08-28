/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package exemplo9_classe;
import veiculos.Bicicleta;


/**
 *
 * @author Gabriela
 */
public class Exemplo9_classe {

       public static void main(String[] args) {
        
        Bicicleta bike1= new Bicicleta();
        bike1.cor = "yellow";
        bike1.numeroDeRodas = 2;
        bike1.peso = 2.23;
        
        Bicicleta bike2= new Bicicleta();
        bike2.cor = "Azul gira";
        bike2.numeroDeRodas = 3;
        bike2.peso = 1.68;
        
        System.out.println("A bicicleta 1 tem a cor: "+bike1.cor + ", o número de rodas: " + bike1.numeroDeRodas+ " e o peso: "+bike1.peso+".");
        System.out.println("\n A bicicleta 2 tem a cor: "+bike2.cor + ", o número de rodas: " + bike2.numeroDeRodas+ " e o peso: "+bike2.peso+".");
    
     
    }
    
}
