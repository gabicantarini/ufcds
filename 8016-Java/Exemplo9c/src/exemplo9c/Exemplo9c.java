/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package exemplo9c;

import Entidades.Cliente;

/**
 *
 * @author Gabriela
 */
public class Exemplo9c {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Humano miguel = new Humano();
        Humano gabriela = new Humano();        
        miguel.setAltura(165);
        miguel.setPeso(67);
        miguel.setNome("Miguelito");
        int x = miguel.getAltura();
        int w = miguel.getPeso();
        String nm = miguel.getNome();
        System.out.println("O apelido do Miguel é: " + nm + "; a altura é: " +x+"; o peso é: "+w);
        
        gabriela.setAltura(163);
        gabriela.setPeso(70);
        gabriela.setNome("Gabi");
        int y = gabriela.getAltura();
        int z = gabriela.getPeso();
        String nom = gabriela.getNome();
        System.out.println("O apelido da Gabriela é: " + nom +"; a altura é: " +y+"; o peso é: "+z);
        
        Cidadao c1=new Cidadao();
        
        c1.setNome("Alfredozinho");
        c1.setPeso(100);
        c1.setId("Passaporte 1345ZA");
        
        String texto=c1.getNome();
        int p=c1.getPeso();
        String doc=c1.getId();
        System.out.println("O apelido do Alfredo é: " + texto + "; o peso é: " +p+"; a identidade é: : "+doc);
    
        
        
        Cliente cl1 = new Cliente(123456789, "nome", 167, 65, "Miguel");
        cl1.setNome("Cecília");
        cl1.setAltura(23);
        cl1.setPeso(21);
        cl1.setId("CC 100300400");
        cl1.setNif(200312456);
        
        System.out.println("O apelido do Alfredo é: " + cl1.getNome() + "; o peso é: " + cl1.getPeso()+"; a identidade é: : "+cl1.getId() + "; o NIF é: : "+cl1.getNif());
    
    
    }
    
}
