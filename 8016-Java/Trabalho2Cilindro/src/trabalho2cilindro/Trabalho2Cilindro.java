/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package trabalho2cilindro;

/**
 *
 * @author Gabriela
 */
public class Trabalho2Cilindro {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Cilindro cilindro1 = new Cilindro(2,3);
        Cilindro cilindro2 = new Cilindro(2,3);
        CilindroComPeso cp = new CilindroComPeso(2, 3, 4);
        
        System.out.println("cilindro1 Raio: "+cilindro1.obterRaio());
        System.out.println("cilindro1 Altura: "+cilindro1.obterAltura());
        System.out.println("cilindro1 Volume: "+cilindro1.obterVolume());
        System.out.println("cilindro2 Raio: "+cilindro2.obterRaio());
        System.out.println("cilindro2 Altura: "+cilindro2.obterAltura());
        System.out.println("cilindro2 Volume: "+cilindro2.obterVolume());
        System.out.println("Reduz Raio: "+cilindro1.reduzRaio());
        System.out.println("CilindroComPeso Raio: "+cp.obterRaio());
        System.out.println("CilindroComPeso Altura: "+cp.obterAltura());
        System.out.println("CilindroComPeso Densidade: "+cp.getDensidade());        
    }
    
}
