/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package exemplo9b;

/**
 *
 * @author Gabriela
 */
        
public class Triangulo extends Forma2D{
    private int base;
    private int altura;
        
    public void DefinirAltura(int a){
        altura = a;
        area = base*altura;
    }
    
    public int ObterAltura(){        
        return altura;
    }
    
    public void DefinirBase(int b){
        base = b;  
        area = base*altura;
    }
    
    public int ObterBase(){        
        return base;
    }

}
