/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package Formas;


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
        TrianguloComCor t1 = new TrianguloComCor(10,15,"rosa");
        
        t1.DefinirAltura(10);
        t1.DefinirBase(5);
        
        System.out.println("n\t1\n");
        System.out.println("Altura: " + t1.ObterAltura());
        System.out.println("Base: " + t1.ObterBase());
        System.out.println("Área: " + t1.ObterArea());
        System.out.println("Cor: " + t1.getCor());
        
       
    }
    
}
