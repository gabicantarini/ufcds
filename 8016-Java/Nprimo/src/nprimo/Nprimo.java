/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package nprimo;
import java.util.Scanner;
/**
 *
 * @author Gabriela
 */
public class Nprimo {

   public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("Digite um número primo: ");
        int numero = scan.nextInt();        
        //int numero=17;
        int resto=0;
        //o numero 2 não é superior ao i 
        //não passa pelo ciclo for e assume o resto=0 que foi declarado no início
        //se depois ficar if(resto==0) então o 2 não vai assumir como primo
        for (int i=2; i<=numero/2; i++){
            resto=numero%i;
            if(resto==0)
            break;           
            
        }
        if(resto==0)
            System.out.println("O número indicado não é primo.");
        else
            System.out.println("O número indicado é primo.");
    }
}
