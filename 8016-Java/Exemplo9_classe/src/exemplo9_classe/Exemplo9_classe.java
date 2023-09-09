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
        bike1.DenifirCor("yellow");
        bike1.DefinirNumeroDeRodas(2);
        bike1.DefinirPeso(1.93);
        
        
        Bicicleta bike2= new Bicicleta();
        bike2.DenifirCor("Azul gira");
        bike2.DefinirNumeroDeRodas(3);
        bike2.DefinirPeso(1.68);
        
        System.out.println("A bicicleta 1 tem a cor: "+ bike1.ObterCor() + ", o número de rodas: " + bike1.ObterNumeroDeRodas() + " e o peso: "+bike1.ObterPeso()+".");
        System.out.println("\n A bicicleta 2 tem a cor: "+ bike2.ObterCor() + ", o número de rodas: " + bike2.ObterNumeroDeRodas() + " e o peso: "+bike2.ObterPeso()+".");
    
        BicicletaComMotor bike3=new BicicletaComMotor();
        bike3.DenifirCor("green");
        bike3.DefinirNumeroDeRodas(3);
        bike3.motor = "Suzuki";
        
        bike3.MostrarMotor();
        //bike3.MostrarCor();
        
            
    }
    
}
