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
    public int numeroDeRodas;
    public double peso;
    
    public String ObterCor(){
        return cor;
    }
    
    public void DenifirCor(String c){
        cor=c;
    }
}