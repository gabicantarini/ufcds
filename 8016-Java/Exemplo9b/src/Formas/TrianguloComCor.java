/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Formas;

/**
 *
 * @author Gabriela
 */
public class TrianguloComCor extends Triangulo{
    private String cor; 
    
    public void setCor(String c){
        cor = c;        
    }
    
    public String getCor(){        
        return cor;
    }
    
    public TrianguloComCor(int a, int b, String c){
        altura=a;
        base=b;
        cor=c;
        area=altura*base/2;
        System.out.println(+base+","+altura+","+cor);
    }
}
