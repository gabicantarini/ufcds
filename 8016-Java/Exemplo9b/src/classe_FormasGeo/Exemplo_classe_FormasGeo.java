/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package classe_FormasGeo;
import Formas.TrianguloComCor;

/**
 *
 * @author Gabriela
 */
public class Exemplo_classe_FormasGeo {
    
    public static void main(String[] args){
        TrianguloComCor t1= new TrianguloComCor(20,4,"azul");
        System.out.println(t1.ObterBase());
        System.out.println(t1.ObterAltura());
        System.out.println(t1.ObterArea());
        System.out.println(t1.getCor());
    }
}
