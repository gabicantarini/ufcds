/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package exemplo9b;


/**
 *
 * @author Gabriela
 */
public class Exemplo9b {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //Triangulo triangulo1 = new Triangulo();
        TrianguloComCor triangulo1 = new TrianguloComCor();
        
        triangulo1.DefinirAltura(10);
        triangulo1.DefinirBase(5);
        triangulo1.DefinirCor("Yellow");
        
        System.out.println("Altura: " + triangulo1.ObterAltura());
        System.out.println("Base: " + triangulo1.ObterBase());
        System.out.println("Área: " + triangulo1.ObterArea());
        System.out.println("Cor: " + triangulo1.ObterCor());
        
    }
    
}
