/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package exemplo9b;

/**
 *
 * @author Gabriela
 */
public class Forma3D {
    private int aresta;
    public void DefinirAresta(int h){
        aresta = h;
        int volume = aresta * aresta * aresta;
    }
    
    public int ObterAresta(){
        return aresta;
    }
}
