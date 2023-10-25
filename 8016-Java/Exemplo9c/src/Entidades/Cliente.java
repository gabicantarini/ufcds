
/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Entidades;

import exemplo9c.Cidadao;

/**
 *
 * @author Gabriela
 */
public class Cliente extends Cidadao{
    private int nif;
    private int altura;
    private String ident;
    private int peso;
    private String nome;

    public int getNif() {
        return nif;
    }

    public void setNif(int n) {
        nif = n;
    }
    public Cliente(String no)
    {
        nome=no;
    }
    public String getIdent() {
        return ident;
    }

    public void setIdent(String id) {
        ident = id;
    }
    public Cliente(int n, String id, int a, int p, String no)
    {
        nif=n;
        ident=id;
        altura=a;
        peso=p;
        nome=no;
    }
    
    

    
}
