/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package veiculos;

/**
 *
 * @author Gabriela
 */
public class Bicicleta {
    private String cor;
    private int numeroDeRodas;
    private double peso;
    
    public String ObterCor(){
        return cor;
    }
    
    public void DenifirCor(String c){
        cor=c;
    }
    
    public int ObterNumeroDeRodas(){
        return numeroDeRodas;
    }
     
    public int DefinirNumeroDeRodas(int d){
        return numeroDeRodas=d;
    }
    
    public double ObterPeso(){
        return peso;
    } 
    
    public double DefinirPeso(double p){
        return peso = p;
    } 
          
    
}