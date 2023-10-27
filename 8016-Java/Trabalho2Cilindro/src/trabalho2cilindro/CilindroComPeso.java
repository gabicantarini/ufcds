/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package trabalho2cilindro;

/**
 * 
 *
 * 
 * @author Gabriela
 */
public class CilindroComPeso extends Cilindro{
    private int densidade;
    public double peso;
    
    public int getDensidade(){
        return densidade;
    }
    public void setDensidade( int d){
        densidade=d;
    }
    
    public double getPeso(){
        peso= obterVolume()*densidade;
        return peso;
    }    
    
    public void CilindroComPeso(int r, int a, int d){
        definirRaio(r);
        definirAltura(a);
        densidade=d;
    }
    
    public CilindroComPeso(int r, int a, int d){
        definirRaio(r=1);
        definirAltura(a=1);
        densidade=1;
    }
}
