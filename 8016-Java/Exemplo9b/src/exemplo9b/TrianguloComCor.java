/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package exemplo9b;

/**
 *
 * @author Gabriela
 */
public class TrianguloComCor extends Triangulo{
    private String cor;
    
    public void DefinirCor(String c){
        cor = c;        
    }
    
    public String ObterCor(){        
        return cor;
    }
}
