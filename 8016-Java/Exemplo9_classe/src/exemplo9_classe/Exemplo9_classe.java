/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package exemplo9_classe;
import veiculos.Bicicleta;
import veiculos.BicicletaComMotor;
//import veiculos.Tractor;

/**
 *
 * @author Gabriela
 */
public class Exemplo9_classe {

       public static void main(String[] args) {
        
           
        Bicicleta bike1= new Bicicleta();
        bike1.setCor("yellow");
        bike1.setNumeroDeRodas(2);
        bike1.setPeso(1.93);
        
        
        Bicicleta bike2= new Bicicleta();
        bike2.setCor("Azul gira");
        bike2.setNumeroDeRodas(3);
        bike2.setPeso(1.68);
        
        System.out.println("A bicicleta 1 tem a cor: "+ bike1.getCor() + ", o número de rodas: " + bike1.setNumeroDeRodas() + " e o peso: "+bike1.setPeso()+".");
        System.out.println("\n A bicicleta 2 tem a cor: "+ bike2.getCor() + ", o número de rodas: " + bike2.setNumeroDeRodas() + " e o peso: "+bike2.setPeso()+".");
    
        BicicletaComMotor bike3=new BicicletaComMotor();
        bike3.setCor("green");
        bike3.setNumeroDeRodas(3);
        bike3.motor = "Suzuki";
        
        bike3.MostrarMotor();
        //bike3.MostrarCor();        
            
    }
    
}
