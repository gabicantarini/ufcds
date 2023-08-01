public class Exemplo8_If {
    /**
     * @parm args the command line arguments
     */
    public static void main(String[] args){
        int a=10;
        int b=3;
        if(a<b)
            System.out.println("a menor que b");
        else
            System.out.println("a maior ou igual que b");

        if ((a>9) && (b>2))
            System.out.println("a maior que 9 e b maior que 2");
        

        if ((a>9) || (b>2))
            System.out.println("a maior que 9 ou b maior que 2");
    }
}

