/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package trabalho2cilindro;

/**
 *
 * @author Gabriela
 */
public class Cilindro {
    private int raio;
    private int altura;   
    
    public int obterRaio(){
        return raio;
    }
    public void definirRaio(int r){
        raio=r;
    }
    public int obterAltura(){
        return altura;
    }
    public void definirAltura(int a){
        altura=a;
    }
    
    public double obterVolume(){
        //volume = ((double)4/3)*3.14*(r*r*r);
        return Math.PI*Math.pow(raio,2)*altura;
        
    }
    
    public double reduzRaio(){        
        return raio /2; 
    }
    
    public Cilindro(int r, int a){
        raio=r;
        altura=a;
    }
    
    public Cilindro(){
        raio=1;
        altura=2;
    }
}
