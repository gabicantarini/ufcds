/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Formas;

/**
 *
 * @author Gabriela
 */
        
public class Triangulo extends Forma2D{
    protected int base;
    protected int altura;
        
    @Override
    public int ObterArea(){
        return base*altura/10;
    }

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
